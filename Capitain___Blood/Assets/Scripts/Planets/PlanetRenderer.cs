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

        public void ApplyRender(Planet _planet)
        {
            material.mainTexture = texture[(int)_planet.renderingValues.x];
            material.color = ColorFromSeed((int)_planet.renderingValues.y);

            Debug.Log("ApplyRenderer");
        }

        private Color ColorFromSeed(int _seed)
        {
            float red = (Mathf.Floor(_seed / 10000) / 100) / 4 * 3 + .25f;
            float green = ((Mathf.Floor(_seed / 100) - Mathf.Floor(_seed / 10000) * 100) / 100)/ 4 * 3 + .25f;
            float blue = ((_seed - Mathf.Floor(_seed / 100) * 100) / 100)/ 4 * 3 + .25f;

            return new Color(red, green, blue);
        }
    }
}