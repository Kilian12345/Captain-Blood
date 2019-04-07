﻿using System.Collections.Generic;
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
        public string csvSplittingCharacter;
        public string fileName;
        #endregion

        [MenuItem("Tools/Sentence CSV To JSON Generator")]
        public static void ShowWindow()
        {
            GetWindow<ToolCSVToJSON>("Sentence CSV To JSON Generator");
        }

        private void OnGUI()
        {
            //FILE NAME
            EditorGUILayout.BeginHorizontal();
            fileName = EditorGUILayout.TextField("File output name: ", fileName);
            EditorGUILayout.EndHorizontal();

            //SEPARATOR
            EditorGUILayout.BeginHorizontal();
            csvSplittingCharacter = EditorGUILayout.TextField("Separator", csvSplittingCharacter);
            EditorGUILayout.EndHorizontal();

            //CSV FILE
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("CSV File", EditorStyles.label);
            csvFile = EditorGUILayout.ObjectField(csvFile, typeof(TextAsset), true);
            EditorGUILayout.EndHorizontal();

            //GENERATOR BUTTON
            if (GUILayout.Button("Generate"))
            {
                TextAsset file = csvFile as TextAsset;

                Speech[] speeches = GetSpeechesFromCSVFile(file);

                GenerateFiles(speeches, fileName);

                AssetDatabase.Refresh();
            }
        }

        #region File management methods
        void GenerateFiles(Speech[] _speeches, string _fileName)
        {
            GenerateDirectory(_fileName);

            for (int i = 0; i < _speeches.Length; i++)
            {
                //TextAsset converted = new TextAsset(JsonConvert.SerializeObject(_speeches[i], Formatting.Indented));

                using (StreamWriter json = File.CreateText("Assets/Resources/Speeches/" + _fileName + "/" + _fileName + "_" + i + ".json"))
                {
                    json.Write(JsonConvert.SerializeObject(_speeches[i], Formatting.Indented));
                }
            }

            Debug.Log(csvFile.name+".csv successfully converted in JSON into "+_speeches.Length + " files.");
        }

        void GenerateDirectory(string _fileName)
        {
            if (Directory.Exists("Assets/Resources/Speeches/" + _fileName)) return;

            Directory.CreateDirectory("Assets/Resources/Speeches/" + _fileName);
            Debug.Log("Directory " + _fileName + " created in: Assets/Resources/Speeches/.");
        }
        #endregion

        #region CSV to JSON methods
        Sentence[] DataToSentences(int[][] _data)
        {
            Sentence[] result = new Sentence[_data[0].Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Sentence();

                for (int j = 3; j < 11; j++)
                {
                    result[i].AddWord((Word)_data[j][i]);
                }
            }

            return result;
        }

        int[][] TextDataToIntData(string[] _data)
        {
            int[][] tmp = new int[_data.Length][];

            for (int i = 0; i < _data.Length; i++)
            {
                string[] segmentedData = _data[i].Split(csvSplittingCharacter.ToCharArray()[0]);
                tmp[i] = new int[segmentedData.Length];

                for (int j = 0; j < segmentedData.Length; j++)
                {
                    tmp[i][j] = int.Parse(segmentedData[j]);
                }
            }

            int[][] result = new int[tmp[0].Length][];

            for (int columns = 0; columns < tmp[0].Length; columns++)
            {
                result[columns] = new int[tmp.Length];

                for (int raws = 0; raws < tmp.Length; raws++)
                {
                    result[columns][raws] = tmp[raws][columns];
                }
            }

            return result;
        }

        string[] SplitFileLines(string _data)
        {
            return _data.Split('\n');
        }

        Speech[] GetSpeechesFromCSVFile(TextAsset _file)
        {
            string[] textLines = SplitFileLines(_file.text);

            int[][] allData = TextDataToIntData(textLines);

            int[] ids = allData[1];
            Sentence[] sentences = DataToSentences(allData);

            Speech[] result = new Speech[ids[ids.Length - 1] + 1];

            List<SentenceType>[] types = new List<SentenceType>[result.Length];
            List<AnswerRequirements>[] requirements = new List<AnswerRequirements>[result.Length];
            List<Sentence>[] speechSentences = new List<Sentence>[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                types[i] = new List<SentenceType>();
                requirements[i] = new List<AnswerRequirements>();
                speechSentences[i] = new List<Sentence>();
            }

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
        #endregion
    }
}