using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using RetroJam.CaptainBlood.GalaxyLib;

namespace RetroJam.CaptainBlood.Lang
{
    public enum MissionType { none, Code, SmallCode, Destroy, Teleport, Bring, Duplicate}
    public enum MissionStatus {none, Started, Achieved}
    public enum SpeechStatus { Said, Waiting, Valid}

    public class Speech
    {
        public Sentence[] sentences;
        public SentenceType[] types;
        public AnswerRequirements[] requirements;
        public SpeechStatus status;
        public AnswerCondition[] condition;
        
        private int index;

        public Speech(Sentence[] _sentences, SentenceType[] _types, AnswerRequirements[] _requirements, AnswerCondition[] _condition)
        {
            sentences = _sentences;
            types = _types;
            requirements = _requirements;
            condition = _condition;

            status = SpeechStatus.Waiting;
            index = 0;
        }

        public bool Check(Answer _answer)
        {
            for (int i = 0; i < condition.Length; i++)
            {
                if(condition[i].Check(_answer)) 
                {
                    return true;
                }
            }

            return false;
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

    [System.Serializable]
    public struct SpeechConnexion
    {
        public int trueStatement;
        public int falseStatement;
    }

    public class Dialogue
    {
        public Speech[] speeches;
        public List<Answer> answers;
        public int step;
        public SpeechConnexion[] stepConnexions;
        public Speech currentSpeech {get; private set;}

        public Dialogue(Speech[] _speeches)
        {
            speeches = _speeches;
            answers = new List<Answer>();
            step = 0;

            stepConnexions = new SpeechConnexion[speeches.Length];
            currentSpeech = speeches[step];
        }

        public Dialogue(Speech[] _speeches, SpeechConnexion[] _connexions)
        {
            speeches = _speeches;
            answers = new List<Answer>();
            step = 0;
            stepConnexions = _connexions;

            currentSpeech = speeches[step];
        }

        private void NextSpeech(bool _validation)
        {
            if(_validation) 
            {
                Debug.Log("Going to true step");
                step = stepConnexions[step].trueStatement;
            }
            else 
            {
                Debug.Log("Going to false step");
                step = stepConnexions[step].falseStatement;
            }

            Debug.Log("New speech step: "+step);
            currentSpeech = speeches[step];
            currentSpeech.status = SpeechStatus.Waiting;
        }

        public void Answering(Answer _playerAnswer)
        {
            answers.Add(_playerAnswer);

            NextSpeech(currentSpeech.Check(_playerAnswer));
        }
    }
}