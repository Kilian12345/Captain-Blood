using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    [ExecuteInEditMode]
    public class Terrain_manager : MonoBehaviour
    {
        public float speed = 0.01f;
        public int depth = 33;
        public int width = 65;
        public int height = 65;
        public float scale = 3.38f;

        public float offsetX;

        [Range(0.0f,3.0f)]public float multiplicateur = 1;

        #region Pattern

        void FlatCrisp_1()
        {depth = 20; multiplicateur = 1.16f;}

        void PlaineStart_2()
        { depth = 27; multiplicateur = 0.37f;}

        void MediumCrisp_3()
        { depth = 30; multiplicateur = 1.75f;}

        void HighCrisp_4()
        { depth = 44; multiplicateur = 1.68f;}

        void HardCrisp_5()
        { depth = 23; multiplicateur = 3f;}

        #endregion

        void Start()
        {

        }

        void Update()
        {
            TerrainPattern();
        }

        void TerrainPattern()
        {

        }

    }
}
