using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class PlanetMovements : MonoBehaviour
    {
        [SerializeField] private float speedOfRotation;
        [SerializeField] private float framer;

        private float buffer = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Rotate();
        }

        public void Rotate()
        {
            buffer += Time.deltaTime;

            if (buffer > framer)
            {
                transform.Rotate(Vector3.up, speedOfRotation);
                buffer = 0;
            }
        }

        public void RotateOld()
        {
            transform.Rotate(Vector3.up, speedOfRotation * Time.deltaTime);
        }
    }
}