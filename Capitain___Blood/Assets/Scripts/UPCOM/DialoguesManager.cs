using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RetroJam.CaptainBlood.Lang;

namespace RetroJam.CaptainBlood
{
    public class DialoguesManager : EventsManager
    {
        [SerializeField] public Sentence alien;
        [SerializeField] public Sentence player;
        [SerializeField] GameManager manager;

        public List<Word> subject = new List<Word>();
        public List<Word> action = new List<Word>();
        public List<Word> @object = new List<Word>();
        public List<Word> complement = new List<Word>();

        private void Awake()
        {
            
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R)) ReadPlayerSentence();
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

    }
}