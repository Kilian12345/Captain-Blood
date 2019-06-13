using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Upcom
{
    public class Sentence
    {
        public Word[] words;
        public SentenceElement[] elements;

        public Sentence(params Word[] _words)
        {
            words = new Word[8];
            for (int i = 0; i < 8; i++)
            {
                words[i] = i < _words.Length ? _words[i] : Word.none;
            }
        }

        private void SetElements()
        {
            List<Word> list = words.ToList();
            int hierarchy = 0;

            for (int i = 7; i >= 0; i--)
            {
                if (list[i] == Word.none) list.RemoveAt(i);
            }

            while (list.Count > 0)
            {
                
            }
        }
    }

    public struct SentenceElement
    {
        public Word word;
        public SentenceElement[] elements;
        public int index;
        public int hierarchy;
    }
}