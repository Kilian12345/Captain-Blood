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

        public Speech(Sentence[] _sentences, SentenceType[] _types, AnswerRequirements[] _requirements)
        {
            sentences = _sentences;
            types = _types;
            requirements = _requirements;

            status = SpeechStatus.Said;
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