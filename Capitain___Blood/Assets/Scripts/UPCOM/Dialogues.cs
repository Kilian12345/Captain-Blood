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
        public List<Answer> answers;
        public int step;

        public Dialogue(Speech[] _speeches)
        {
            speeches = _speeches;
            answers = new List<Answer>();
            step = 0;
        }
    }

    public class Mission
    {
        public Alien giver;
        public int currentPhase;
        public Vector2Int duplicateCoord;
        public MissionStatus status;


    }

    public class FindCode : Mission
    {
        public Part[] parts;
        public Word[] mainCode;

        public struct Part
        {
            public Vector2Int coord;
            public Alien alien;
            public Word[] code;
            public bool given;

            public void Initialize(Word[] _code)
            {
                alien = Galaxy.UnemployedAlien();
                coord = alien.coordinates;
                code = _code;
                given = false;
            }
        }

        public FindCode()
        {
            giver = Galaxy.UnemployedAlien();
            giver.mission = MissionType.Code;

            currentPhase = 0;
            duplicateCoord = Galaxy.SetDuplicate();
            status = MissionStatus.none;
            mainCode = Language.ReturnCode(Random.Range(0,99999999));

            parts = new Part[3];
            parts[0].Initialize(new Word[]{mainCode[0], mainCode[1], mainCode[2]});
            parts[1].Initialize(new Word[]{mainCode[3], mainCode[4]});
            parts[2].Initialize(new Word[]{mainCode[5], mainCode[6], mainCode[7]});
        }

        public Dialogue SetUpDialogue()
        {
            TextAsset[] files = Resources.LoadAll<TextAsset>("Speeches/FindCode");
            Speech[] speeches = new Speech[files.Length];

            for (int i = 0; i < speeches.Length; i++)
            {
                speeches[i] = JsonConvert.DeserializeObject<Speech>(files[i].text);
            }
            
            speeches[2].condition[0].words = mainCode;
            speeches[3].sentences[4] = Language.ReturnCoordinates(duplicateCoord);
            speeches[4].sentences[5] = Language.ReturnCoordinates(parts[0].coord);
            speeches[4].sentences[7] = Language.ReturnCoordinates(parts[1].coord);
            speeches[4].sentences[9] = Language.ReturnCoordinates(parts[2].coord);
            speeches[5].condition[0].words = mainCode;

            return new Dialogue(speeches);
        }
    }
}