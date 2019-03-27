using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{


    public class Hyper_Space : MonoBehaviour
    {

        [SerializeField] ParticleSystem particleSystemStay;
        [SerializeField] ParticleSystem particleSystemLoop;

        [SerializeField] bool activated = false;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame

        private void LateUpdate()
        {
            if (!activated)
            {
                StayStill();
            }
        }

        void Update()
        {

           

            if (activated)
            {
                Activation();



            }

        }


        void StayStill()
        {

             particleSystemStay.Pause();
             particleSystemLoop.Pause();



        }

        void Activation()
        {

            particleSystemStay.Play();
            particleSystemLoop.Play();


            var main = particleSystemStay.main;
            main.startLifetime = 2;

            var main2 = particleSystemLoop.main;
            main2.startLifetime = 2;




        }
    }
}
