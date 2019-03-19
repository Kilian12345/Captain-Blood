using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

namespace RetroJam.CaptainBlood
{
    public class SentencesMonitor : MonoBehaviour
    {
        [SerializeField] private Transform pointer;
        [SerializeField] private Tilemap tm;
        [SerializeField] private TextMeshProUGUI textField;
        [SerializeField] private DialoguesManager manager;

        private Camera cam;

        public Vector3Int debugPos;

        /*private Dictionary<Vector3Int, Word> alienSentence = new Dictionary<Vector3Int, Word>();
        private Vector3Int[] alienField = new Vector3Int[8];
        private Dictionary<Vector3Int, Word> playerSentence = new Dictionary<Vector3Int, Word>();
        private Vector3Int[] playerField = new Vector3Int[8];*/

        private Monitor player;
        private Monitor alien;

        private Dictionary<Glossary, Tile> icons = new Dictionary<Glossary, Tile>();

        public Word mot;


        public class Monitor
        {
            public Dictionary<Vector3Int, Glossary> sentence = new Dictionary<Vector3Int, Glossary>();
            public Vector3Int[] field = new Vector3Int[8];
        }


        private void Awake()
        {
            cam = Camera.main;

            mot = new Word(2, 3);
        }
        // Start is called before the first frame update
        void Start()
        {
            InitializeSentences();
            InitializeTiles();
        }

        // Update is called once per frame
        void Update()
        {
            WriteSentence(player, manager.player);
            WriteSentence(alien, manager.alien);
            ReadSentences();

            Test();
        }

        public void InitializeSentences()
        {
            alien = new Monitor();
            player = new Monitor();

            for (int i = 0; i < 8; i++)
            {
                alien.field[i] = new Vector3Int(-9 + i, 1, 0);
                player.field[i] = new Vector3Int(1 + i, 1, 0);

                alien.sentence[alien.field[i]] = Glossary.none;
                player.sentence[player.field[i]] = Glossary.none;
            }
        }

        public void InitializeTiles()
        {

            for (int i = 0; i < 120; i++)
            {
                icons[(Glossary)i] = Resources.Load<Tile>("Words/words_"+i);
            }
        }

        public void ReadSentences()
        {
            Vector3 _pos = pointer.position;

            if (_pos.x < -7.15 || _pos.y < -1.5 || _pos.x > 7.2 || _pos.y > -0.6) return;

            Vector3Int cursor = tm.WorldToCell(_pos);

            if (_pos.x < -0.8)
            {
                textField.text = alien.sentence[cursor].ToText();
            }
            else if (_pos.x > 0.85)
            {
                textField.text = player.sentence[cursor].ToText();
            }
        }

        public void WriteSentence(Monitor _monitor, Sentence _sentence)
        {
            for (int i = 0; i < 8; i++)
            {
                _monitor.sentence[_monitor.field[i]] = _sentence.words[i];
                tm.SetTile(_monitor.field[i], icons[_sentence.words[i]]);
            }
        }

        public void Test()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("Files created in the \"Saves\" directory, saving informations in json-format.");

                using (StreamWriter test = File.CreateText(@"Saves\test.json"))
                {
                    test.WriteLine(JsonUtility.ToJson(mot));
                }

            }
        }

    }
}