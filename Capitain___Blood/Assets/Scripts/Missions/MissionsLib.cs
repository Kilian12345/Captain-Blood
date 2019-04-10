using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using RetroJam.CaptainBlood.Lang;
using RetroJam.CaptainBlood.GalaxyLib;

namespace RetroJam.CaptainBlood.MissionsLib
{
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

            Debug.Log("Mission FindCode given to the alien in: "+giver.coordinates.x+"/"+giver.coordinates.y+".");

            currentPhase = 0;
            duplicateCoord = Galaxy.SetDuplicate();
            status = MissionStatus.none;
            int tmpCode = Random.Range(0,99999999);
            mainCode = Language.ReturnCode(tmpCode);
            Debug.Log("Mission FindCode use the following code: "+tmpCode);

            parts = new Part[3];
            parts[0].Initialize(new Word[]{mainCode[0], mainCode[1], mainCode[2]});
            parts[1].Initialize(new Word[]{mainCode[3], mainCode[4]});
            parts[2].Initialize(new Word[]{mainCode[5], mainCode[6], mainCode[7]});

            giver.dialogue = SetUpDialogue();
        }

        public FindCode(TextAsset[] _speechesFiles, SpeechConnexionSCO _sco)
        {
            giver = Galaxy.UnemployedAlien();
            giver.mission = MissionType.Code;

            Debug.Log("Mission FindCode given to the alien in: "+giver.coordinates.x+"/"+giver.coordinates.y+".");

            currentPhase = 0;
            duplicateCoord = Galaxy.SetDuplicate();
            status = MissionStatus.none;
            int tmpCode = Random.Range(0,99999999);
            mainCode = Language.ReturnCode(tmpCode, true);
            Debug.Log("Mission FindCode use the following code: "+tmpCode);

            parts = new Part[3];
            parts[0].Initialize(new Word[]{mainCode[0], mainCode[1], mainCode[2]});
            parts[1].Initialize(new Word[]{mainCode[3], mainCode[4]});
            parts[2].Initialize(new Word[]{mainCode[5], mainCode[6], mainCode[7]});

            giver.dialogue = SetUpDialogue(_speechesFiles, _sco);
        }

        public Dialogue SetUpDialogue()
        {
            Object[] files = Resources.LoadAll("Speeches/FindCode");

            TextAsset[] speechesFiles = new TextAsset[files.Length-1];
            for (int i = 0; i < speechesFiles.Length; i++)
            {
                speechesFiles[i] = files[i] as TextAsset;
            }
            
            SpeechConnexion[] connexions = (files[files.Length-1] as SpeechConnexionSCO).connexions;

            Speech[] speeches = new Speech[speechesFiles.Length];

            for (int i = 0; i < speeches.Length; i++)
            {
                speeches[i] = JsonConvert.DeserializeObject<Speech>(speechesFiles[i].text);
            }
            
            speeches[2].condition[0].words = mainCode;
            speeches[3].sentences[4] = Language.ReturnCoordinates(duplicateCoord);
            speeches[4].sentences[5] = Language.ReturnCoordinates(parts[0].coord);
            speeches[4].sentences[7] = Language.ReturnCoordinates(parts[1].coord);
            speeches[4].sentences[9] = Language.ReturnCoordinates(parts[2].coord);
            speeches[5].condition[0].words = mainCode;

            return new Dialogue(speeches, connexions);
        }

        public Dialogue SetUpDialogue(TextAsset[] _speechesFiles, SpeechConnexionSCO _sco)
        {

            TextAsset[] speechesFiles = _speechesFiles;
            
            SpeechConnexion[] connexions = _sco.connexions;

            Speech[] speeches = new Speech[speechesFiles.Length];

            for (int i = 0; i < speeches.Length; i++)
            {
                speeches[i] = JsonConvert.DeserializeObject<Speech>(speechesFiles[i].text);
            }
            
            speeches[2].condition[0].words = mainCode;
            speeches[3].sentences[4].words = Language.ReturnCoordinates(duplicateCoord).words;
            speeches[4].sentences[5] = Language.ReturnCoordinates(parts[0].coord);
            speeches[4].sentences[7] = Language.ReturnCoordinates(parts[1].coord);
            speeches[4].sentences[9] = Language.ReturnCoordinates(parts[2].coord);
            speeches[5].condition[0].words = mainCode;

            return new Dialogue(speeches, connexions);
        }
    }
}