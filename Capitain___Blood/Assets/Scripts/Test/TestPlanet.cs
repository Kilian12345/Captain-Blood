using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class TestPlanet : MonoBehaviour
    {
        public Glossary[] name;
        public Vector2Int coordinates;
        public Glossary race;

        // Start is called before the first frame update
        void Start()
        {
            Planet planet = new Planet(coordinates, race);

            for (int i = 0; i < planet.name.Length; i++)
            {
                Debug.Log(planet.name[i].ToText());
            }

            Galaxy.Initialize();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}