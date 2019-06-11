using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Upcom
{
    public class Sentence
    {
        public Word[] words;

        public Sentence(params Word[] _words)
        {
            words = new Word[8];
            for (int i = 0; i < 8; i++)
            {
                words[i] = i < _words.Length ? _words[i] : Word.none;
            }
        }
    }

    public class SentenceElement
    {
        public Word word;
        public SentenceElement[] elements;
        public int index;
        public int hierarchy;

    }
}