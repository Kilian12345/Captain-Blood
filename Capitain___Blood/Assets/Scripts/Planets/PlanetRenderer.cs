using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RetroJam.CaptainBlood.GalaxyLib;

namespace RetroJam.CaptainBlood
{
    public class PlanetRenderer : MonoBehaviour
    {
        [SerializeField] private Material material;
        [SerializeField] private Texture[] texture;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ApplyRender(Planet _planet)
        {
            material.mainTexture = texture[(int)_planet.renderingValues.x];
        }
    }
}