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
                TextAsset file = csvFile as TextAsset;

                Sentence[] sentences = GetSentenceFromCSVFile(file);

                Debug.Log(JsonConvert.SerializeObject(sentences));
                Debug.Log(sentences.Length);

                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                TextAsset converted = new TextAsset(JsonConvert.SerializeObject(sentences, Formatting.Indented));
                
                using (StreamWriter json = File.CreateText("Assets/Resources/Sentences/" + fileName + ".json"))
                {
                    json.Write(JsonConvert.SerializeObject(sentences,Formatting.Indented));
                }

                AssetDatabase.Refresh();

                sw.Stop();

                Debug.Log("File generated in: " + sw.ElapsedMilliseconds + "ms.");
            }
        }

        Sentence DataToSentence(int[] _data)
        {
            Sentence result = new Sentence();

            for (int i = 0; i < _data.Length; i++)
            {
                result.AddWord((Word)_data[i]);
            }

            return result;
        }

        int[] TextDataToIntData(string _data)
        {
            int[] result = new int[8] {0,0,0,0,0,0,0,0};

            string[] segmentedData = _data.Split(';');

            for (int i = 0; i < segmentedData.Length; i++)
            {
                result[i] = int.Parse(segmentedData[i]);
            }

            return result;
        }

        string[] SplitFileLines(string _data)
        {
            return _data.Split('\n');
        }

        Sentence[] GetSentenceFromCSVFile(TextAsset _file)
        {
            string[] textSentences = SplitFileLines(_file.text);

            Sentence[] result = new Sentence[textSentences.Length];

            for (int i = 0; i < textSentences.Length; i++)
            {
                int[] sentence = TextDataToIntData(textSentences[i]);

                result[i] = DataToSentence(sentence);
            }

            return result;
        }


    }
}