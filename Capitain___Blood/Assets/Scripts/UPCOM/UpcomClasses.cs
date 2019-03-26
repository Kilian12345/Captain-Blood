using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Lang
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

    [System.Serializable]
    public class Alien
    {
        public Word[] name { get; private set; }
        public int sympathy;

        public void SetName()
        {
            name = new Word[2];
            name[0] = (Word)Random.Range(2, 72);
            name[1] = (Word)Random.Range(2, 72);
        }
    }

    public class Quest
    {

    }
}
