using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using RetroJam.CaptainBlood.Lang;

namespace RetroJam.CaptainBlood
{
    public class DialoguesManager : EventsManager
    {
        [SerializeField] public Sentence alien;
        [SerializeField] public Sentence player;
        [SerializeField] GameManager manager;
        [SerializeField] TextAsset jsonFile;

        Speech alienSpeech;

        public List<Word> subject = new List<Word>();
        public List<Word> action = new List<Word>();
        public List<Word> @object = new List<Word>();
        public List<Word> complement = new List<Word>();

        bool isWriting;
        Queue<Sentence> alienSpeechSentences = new Queue<Sentence>();

        private void Awake()
        {
            alienSpeech = JsonConvert.DeserializeObject<Speech>(jsonFile.text);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R)) ReadPlayerSentence();
            AlienSpeechManager();
        }

        public void ReadPlayerSentence()
        {
            Debug.Log(player.Correctness());
            Debug.Log(player.SentenceEsteem(manager.alien));
            if (player.Correctness() != SentenceCorrectness.none)
            {
                Debug.Log(player.Construction());
                DebugStructure();
            }
            player.Clean();
        }

        public void DebugStructure()
        {
            Dictionary<WordFunction, List<Word>> dico = player.Structure();

            subject = dico[WordFunction.Subject];
            action = dico[WordFunction.Action];
            @object = dico[WordFunction.Object];
            complement = dico[WordFunction.Complement];
        }

        public void AlienSpeechManager()
        {
            if (Input.GetKeyDown(KeyCode.H)) AlienKeyboard(alienSpeech.Read());
        }

        public void AlienKeyboard(Sentence _sentence)
        {
            if (!isWriting) StartCoroutine(InsertWords(_sentence));
        }

        public void AddAlienWord(Word _word)
        {
            alien.AddWord(_word);
        }

        public IEnumerator InsertWords(Sentence _sentence)
        {
            isWriting = true;
            alien.Clean();

            for (int i = 0; i < 8; i++)
            {
                AddAlienWord(_sentence.words[i]);

                yield return new WaitForSeconds(.35f);
            }

            isWriting = false;
        }
    }
}