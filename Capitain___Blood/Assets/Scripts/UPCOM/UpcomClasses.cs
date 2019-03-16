using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    [System.Serializable]
    public class Sentence
    {
        public Word[] words;
        public int size { get; private set; }

        
        public Sentence()
        {
            words = new Word[8];
            for (int i = 0; i < 8; i++)
            {
                words[i] = Word.none;
            }

            size = 0;
        }

        public void AddWord(Word _word)
        {
            if (size < 8)
            {
                words[size] = _word;
                size++;
            }
            else
            {
                Debug.Log("The Sentence " + this + " is full. You can't add a new word.");
            }
        }

        public void RemoveWord()
        {
            if (size > 0)
            {
                words[size - 1] = Word.none;
                size--;
            }
            else
            {
                Debug.Log("The Sentence " + this + " is empty. You can't remove any word.");
            }
        }
    }

    public class ContextBehaviors
    {
        public bool teleportable;
    }

    public class Alien
    {
        public Word[] name { get; private set; }

        public void SetName()
        {
            name = new Word[Random.Range(2, 3)];

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = (Word)Random.Range(1, 72);
            }
        }
    }

    public class Quest
    {

    }


}
