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

        private Dictionary<Vector3Int, Word> alienSentence = new Dictionary<Vector3Int, Word>();
        private Vector3Int[] alienField = new Vector3Int[8];
        private Dictionary<Vector3Int, Word> playerSentence = new Dictionary<Vector3Int, Word>();
        private Vector3Int[] playerField = new Vector3Int[8];

        private Dictionary<Word, Tile> icons = new Dictionary<Word, Tile>();


        private void Awake()
        {
            cam = Camera.main;
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
            WritePlayerSentence();
            ReadSentences();
        }

        public void InitializeSentences()
        {
            for (int i = 0; i < 8; i++)
            {
                alienField[i] = new Vector3Int(-9 + i, 1, 0);
                playerField[i] = new Vector3Int(1 + i, 1, 0);

                alienSentence[alienField[i]] = Word.none;
                playerSentence[playerField[i]] = Word.none;
            }
        }

        public void InitializeTiles()
        {
            //Tile[] tiles = Resources.LoadAll<Tile>("Words");

            //Debug.Log(tiles.Length);

            for (int i = 0; i < 120; i++)
            {
                icons[(Word)i] = Resources.Load<Tile>("Words/words_"+i);
            }
        }

        public void ReadSentences()
        {
            Vector3 _pos = pointer.position;

            if (_pos.x < -7.15 || _pos.y < -1.5 || _pos.x > 7.2 || _pos.y > -0.6) return;

            Vector3Int cursor = tm.WorldToCell(_pos);

            if (_pos.x < -0.8)
            {
                textField.text = alienSentence[cursor].ToText();
            }
            else if (_pos.x > 0.85)
            {
                textField.text = playerSentence[cursor].ToText();
            }
        }

        public void WritePlayerSentence()
        {
            for (int i = 0; i < 8; i++)
            {
                playerSentence[playerField[i]] = manager.player.words[i];
                tm.SetTile(playerField[i], icons[manager.player.words[i]]);
            }
        }
    }
}