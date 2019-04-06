using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;
using RetroJam.CaptainBlood.Lang;

namespace RetroJam.CaptainBlood
{
    public class ToolCSVToJSON : EditorWindow
    {

        #region Variables
        public Object csvFile;
        public char csvSplittingCharacter;
        public string fileName;
        #endregion

        [MenuItem("Tools/Sentence CSV To JSON Creator")]
        public static void ShowWindow()
        {
            GetWindow<ToolCSVToJSON>("Sentence CSV To JSON Creator");
        }

        private void OnGUI()
        {
            //FILE NAME
            EditorGUILayout.BeginHorizontal();
            //GUILayout.Label("Nom Du Mat", EditorStyles.label);
            fileName = EditorGUILayout.TextField("File output name: ", fileName);
            EditorGUILayout.EndHorizontal();

            //CSV FILE
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("CSV File", EditorStyles.label);
            csvFile = EditorGUILayout.ObjectField(csvFile, typeof(TextAsset), true);
            EditorGUILayout.EndHorizontal();

            //BOUTON DE CREATION
            if (GUILayout.Button("Generate"))
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                TextAsset file = csvFile as TextAsset;

                /*Sentence[] sentences = GetSentenceFromCSVFile(file);

                Debug.Log(JsonConvert.SerializeObject(sentences));
                Debug.Log(sentences.Length);*/

                Speech[] speeches = GetSpeechesFromCSVFile(file);

                for (int i = 0; i < speeches.Length; i++)
                {

                    TextAsset converted = new TextAsset(JsonConvert.SerializeObject(speeches[i], Formatting.Indented));

                    using (StreamWriter json = File.CreateText("Assets/Resources/Speeches/" + fileName +"_"+i+ ".json"))
                    {
                        json.Write(JsonConvert.SerializeObject(speeches[i], Formatting.Indented));
                    }
                }
                AssetDatabase.Refresh();

                sw.Stop();

                Debug.Log("File generated in: " + sw.ElapsedMilliseconds + "ms.");
            }
        }


        Sentence[] DataToSentence(int[][] _data)
        {
            Sentence[] result = new Sentence[_data[0].Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Sentence();

                for (int j = 3; j < 11; j++)
                {
                    result[i].AddWord((Word)_data[i][j]);
                }
            }

            return result;
        }

        int[][] TextDataToIntData(string[] _data)
        {
            int[][] result = new int[11][];

            for (int i = 0; i < 11; i++)
            {
                result[i] = new int[_data.Length];

                string[] segmentedData = _data[i].Split(';');
                //Debug.Log("Amount of column in the file: " + segmentedData.Length);

                for (int j = 0; j < segmentedData.Length; j++)
                {
                    result[i][j] = int.Parse(segmentedData[j]);
                }
            }

            return result;
        }

        string[] SplitFileLines(string _data)
        {
            Debug.Log("Amount of line in the file: " + _data.Split('\n').Length);
            return _data.Split('\n');
        }

        Speech[] GetSpeechesFromCSVFile(TextAsset _file)
        {
            string[] textLines = SplitFileLines(_file.text);

            int[][] allData = TextDataToIntData(textLines);

            int[] ids = allData[1];
            Sentence[] sentences = DataToSentence(allData);

            Speech[] result = new Speech[ids[ids.Length - 1] + 1];

            List<SentenceType>[] types = new List<SentenceType>[result.Length];
            List<AnswerRequirements>[] requirements = new List<AnswerRequirements>[result.Length];
            List<Sentence>[] speechSentences = new List<Sentence>[result.Length];

            for (int i = 0; i < textLines.Length; i++)
            {
                types[ids[i]].Add((SentenceType)allData[0][i]);
                requirements[ids[i]].Add((AnswerRequirements)allData[0][i]);
                speechSentences[ids[i]].Add(sentences[i]);
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Speech(speechSentences[i].ToArray(), types[i].ToArray(), requirements[i].ToArray());
            }

            return result;

        }

        #region DEPRECATED CONTENT
        //DEPRECATED
        Sentence[] GetSentenceFromCSVFile(TextAsset _file)
        {
            string[] textSentences = SplitFileLines(_file.text);

            Sentence[] result = new Sentence[textSentences.Length];

            for (int i = 0; i < textSentences.Length; i++)
            {
                int[] sentence = TextDataToIntSentenceElements(textSentences[i]);

                result[i] = DataToSentence(sentence);
            }

            return result;
        }

        //DEPRECATED
        int[] TextDataToIntSentenceElements(string _data)
        {
            int[] result = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            string[] segmentedData = _data.Split(';');

            for (int i = 3; i < segmentedData.Length; i++)
            {
                result[i] = int.Parse(segmentedData[i]);
            }

            return result;
        }

        //DEPRECATED
        Sentence DataToSentence(int[] _data)
        {
            Sentence result = new Sentence();

            for (int i = 0; i < _data.Length; i++)
            {
                result.AddWord((Word)_data[i]);
            }

            return result;
        }
        #endregion

    }
}