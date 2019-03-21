using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Phase phase;
        [SerializeField] private Menu menu;

        private Phase save;
        
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

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            HandleMenus();
        }

        public void HandleMenus()
        {
            if(phase != save)
            {
                menu.SetActive(phase);
                save = phase;
            }
        }
    }
}