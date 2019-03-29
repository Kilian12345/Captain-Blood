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

        private void Awake()
        {
            Words.InitializeWords();
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
            player.Clean();
        }

    }
}