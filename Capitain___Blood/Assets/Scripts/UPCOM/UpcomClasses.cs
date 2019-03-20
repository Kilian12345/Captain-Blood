using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    [System.Serializable]
    public class Sentence
    {
        public Glossary[] words;
        public int size { get; private set; }

        
        public Sentence()
        {
            words = new Glossary[8];
            for (int i = 0; i < 8; i++)
            {
                words[i] = Glossary.none;
            }

            size = 0;
        }

        public void AddWord(Glossary _word)
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
                words[size - 1] = Glossary.none;
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
        public Glossary[] name { get; private set; }
        public int sympathy;

        public void SetName()
        {
            name = new Glossary[2];
            name[0] = (Glossary)Random.Range(2, 72);
            name[1] = (Glossary)Random.Range(2, 72);
        }
    }

    public class Quest
    {

    }


}
