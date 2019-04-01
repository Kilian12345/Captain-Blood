using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using TMPro;
using RetroJam.CaptainBlood.GalaxyLib;
using RetroJam.CaptainBlood.Lang;

namespace RetroJam.CaptainBlood
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] public Phase phase;
        [SerializeField] private Menu menu;
        [SerializeField] private Cursor cursor;

        [SerializeField] private TextMeshProUGUI currentX;
        [SerializeField] private TextMeshProUGUI currentY;
        

        [SerializeField] public Planet currentPlanet;
        [SerializeField] public Alien alien;

        private Phase lastPhase;

        public static Events events = new Events();

        private System.Diagnostics.Stopwatch sw;

        //[SerializeField] private GalaxySCO save;

        //public Vector2Int test;

        #region Classes
        [System.Serializable] public class Menu
        {
            public GameObject main, galaxy, planetMenu, landing, upCom, keyboard, planet;

            public void SetActive(Phase _phase)
            {
                main.SetActive(false);
                galaxy.SetActive(false);
                planetMenu.SetActive(false);
                landing.SetActive(false);
                upCom.SetActive(false);
                keyboard.SetActive(false);
                planet.SetActive(false);

                switch (_phase)
                {
                    case Phase.MainMenu:
                        main.SetActive(true);
                        return;
                    case Phase.Galaxy:
                        galaxy.SetActive(true);
                        return;
                    case Phase.FTL:
                        return;
                    case Phase.Planet:
                        planetMenu.SetActive(true);
                        planet.SetActive(true);
                        return;
                    case Phase.Landing:
                        landing.SetActive(true);
                        return;
                    case Phase.UpCom:
                        upCom.SetActive(true);
                        keyboard.SetActive(true);
                        return;
                    default:
                        return;
                }
            }
        }
        #endregion

        private void Awake()
        {
            sw = new System.Diagnostics.Stopwatch();

            sw.Start();
            /*
            string save = File.ReadAllText(@"Saves\planets.json");
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.CheckAdditionalContent = true;*/

            Words.InitializeWords();
            Galaxy.Initialize(/*JsonConvert.DeserializeObject<Dictionary<Vector2Int, Planet>>(save, new Vec2DictionaryConverter())*/);
        }

        void Start()
        {

            sw.Stop();

            Debug.Log("Time to Initialize whole Game : " + sw.ElapsedMilliseconds + "ms.");
            currentPlanet = Galaxy.planets[new Vector2Int(Random.Range(0, 256), Random.Range(0, 126))];
            alien = currentPlanet.inhabitant;
        }

        void Update()
        {

            Test();

            SavePlanets();

            CurrentCoordinates();
        }

        public void Test()
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log(currentPlanet.name[0] + " - " + currentPlanet.name[1] + " - " + currentPlanet.name[2]);
            }
        }

        public void SavePlanets()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("Files created in the \"Saves\" directory, saving informations in json-format.");

                using (StreamWriter test = File.CreateText(@"Saves\planets.json"))
                {
                    test.WriteLine(JsonConvert.SerializeObject(Galaxy.planets, new Vec2DictionaryConverter()));
                }

            }
        }

        public void SetCursorLimit(Phase _phase)
        {
            switch (_phase)
            {
                case Phase.MainMenu:
                    cursor.SetHeight(87);
                    break;
                case Phase.Galaxy:
                    cursor.SetHeight(48);
                    break;
                case Phase.FTL:
                    cursor.SetHeight(50);
                    break;
                case Phase.Planet:
                    cursor.SetHeight(50);
                    break;
                case Phase.Landing:
                    cursor.SetHeight(87);
                    break;
                case Phase.UpCom:
                    cursor.SetHeight(87);
                    break;
                default:
                    break;
            }
        }

        public void CurrentCoordinates()
        {
            currentX.text = currentPlanet.coordinates.x.ToString();
            currentY.text = currentPlanet.coordinates.y.ToString();

        }

        public void SetPlanet(Vector2Int _coord)
        {
            currentPlanet = Galaxy.planets[_coord];
            alien = currentPlanet.inhabitant;
        }

        public void SetPhase(Phase _phase)
        {
            SetCursorLimit(_phase);
            menu.SetActive(_phase);
            phase = _phase;

        }
    }
}