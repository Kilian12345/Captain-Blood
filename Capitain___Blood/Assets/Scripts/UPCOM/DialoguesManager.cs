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
            player.Clean();
        }

    }
}