using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Lang
{
    public enum MissionCode { Code, Destroy, Teleport, Bring}
    public enum SpeechStatus { Said, Waiting, Valid}

    public class Speech
    {
        public Sentence[] sentences;
        public SentenceType[] types;
        public AnswerRequirements[] requirements;
        public SpeechStatus status;
        
        private int index;

        public Speech(Sentence[] _sentences, SentenceType[] _types, AnswerRequirements[] _requirements)
        {
            sentences = _sentences;
            types = _types;
            requirements = _requirements;

            status = SpeechStatus.Waiting;
            index = 0;
        }

        public Sentence Read()
        {
            Sentence result = new Sentence();

            result = sentences[index];
            index++;

            if (index == sentences.Length)
            {
                status = SpeechStatus.Said;
                index = 0;
            }

            return result;
        }
    }

    public class Dialogue
    {
        public Speech[] speeches;
        public Answer[] answers;
    }

    public class Mission
    {
        public Alien giver;
    }
}