using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
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
                Debug.Log("The Sentence " + this.ToString() + " is full. You can't add a new word.");
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
                Debug.Log("The Sentence " + this.ToString() + " is empty. You can't remove any word.");
            }
        }

        public void Clean()
        {
            words = new Word[8];
            for (int i = 0; i < 8; i++)
            {
                words[i] = Word.none;
            }

            size = 0;
        }
    }

    public class ContextBehaviors
    {
        public bool teleportable;
    }

    //[System.Serializable]
    public class Alien
    {
        public Word[] name { get; private set; }
        public float sympathy;
        public Dictionary<Word, GlossaryValues> glossary;

        public Alien()
        {
            SetName();
            CreateGlossary();

            sympathy = 0;
        }

        [JsonConstructor]
        public Alien(Word[] _name, float _sympathy, Dictionary<Word, GlossaryValues> _glossary)
        {
            name = _name;
            sympathy = _sympathy;
            glossary = _glossary;
        }

        public void SetName()
        {

            name = new Word[2];
            name[0] = (Word)Random.Range(2, 72);
            name[1] = (Word)Random.Range(2, 72);
        }

        public void CreateGlossary()
        {
            glossary = new Dictionary<Word, GlossaryValues>();

            glossary.Add(Words.nouns[0], new GlossaryValues(Random.value < .66f ? Random.value + 1 : -2 + Random.value,0));
            glossary.Add(Words.nouns[1], new GlossaryValues(Random.value + 1, 0));

            for (int i = 2; i < Words.nouns.Count; i++)
            {

                if (Words.nouns[i] == name[0] || Words.nouns[i] == name[1])
                {
                    glossary.Add(Words.nouns[i], new GlossaryValues(Random.value + 1, 0));
                }
                else
                {
                    float value = Random.value < .66f ? Random.value + 1 : -2 + Random.value;
                    glossary.Add(Words.nouns[i], new GlossaryValues(value, 0));
                }
            }
        }

        //[System.Serializable]
        public class GlossaryValues
        {
            public float value;
            public int iterations;

            [JsonConstructor]
            public GlossaryValues(float _value, int _iterations)
            {
                value = _value;
                iterations = _iterations;
            }
        }
    }

    public class Quest
    {

    }
}
