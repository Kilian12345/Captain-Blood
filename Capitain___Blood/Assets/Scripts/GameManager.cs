using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using TMPro;

namespace RetroJam.CaptainBlood
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Phase phase;
        [SerializeField] private Menu menu;
        [SerializeField] private Cursor cursor;

        [SerializeField] private TextMeshProUGUI currentX;
        [SerializeField] private TextMeshProUGUI currentY;

        [SerializeField] private Planet currentPlanet;

        private Phase lastPhase;

        //[SerializeField] private GalaxySCO save;

        public Vector2Int test;

        #region Classes
        [System.Serializable] public class Menu
        {
            public GameObject main, galaxy, planet, landing, upCom;

            public void SetActive(Phase _phase)
            {
                main.SetActive(false);
                galaxy.SetActive(false);
                planet.SetActive(false);
                landing.SetActive(false);
                upCom.SetActive(false);

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
                        planet.SetActive(true);
                        return;
                    case Phase.Landing:
                        landing.SetActive(true);
                        return;
                    case Phase.UpCom:
                        upCom.SetActive(true);
                        return;
                    default:
                        return;
                }
            }
        }
        #endregion

        private void Awake()
        {
            string save = File.ReadAllText(@"Saves\planets.json");
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.CheckAdditionalContent = true;

            Galaxy.Initialize(JsonConvert.DeserializeObject<Dictionary<Vector2Int, Planet>>(save, new Vec2DictionaryConverter()));

            //save.galaxy = Galaxy.planets;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            HandleMenus();

            Test();

            SavePlanets();

            CurrentCoordinates();

            SetPlanet(test);
        }

        public void HandleMenus()
        {
            if(phase != lastPhase)
            {
                menu.SetActive(phase);
                lastPhase = phase;

                SetCursorLimit(phase);
            }
        }

        public void Test()
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log(Galaxy.planets[test].name[0] + " - " + Galaxy.planets[test].name[1] + " - " + Galaxy.planets[test].name[2]);
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
        }
    }
}