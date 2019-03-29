using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{


    public class Hyper_Space : MonoBehaviour
    {

        [SerializeField] ParticleSystem particleSystemStay;
        [SerializeField] ParticleSystem particleSystemLoop;
        [SerializeField] ParticleSystem particleSystemEnd;

        [SerializeField] bool activated = false;
        [SerializeField] float timeWarp;



        // Start is called before the first frame update
        void Start()
        {
            particleSystemEnd.Pause();
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

            StartCoroutine(EndParticleEffect());

        }

        IEnumerator EndParticleEffect()
        {

            particleSystemStay.Play();
            particleSystemLoop.Emit(1);

            var main = particleSystemStay.main;
            main.startDelay = 10;

            yield return new WaitForSeconds(timeWarp);

            var mainloop = particleSystemLoop.main;
            mainloop.startLifetime = 0;

            yield return new WaitForSeconds(1);

            particleSystemEnd.Play();

            var mainEnd = particleSystemEnd.main;
            mainEnd.startLifetime = 2;


            yield return new WaitForSeconds(1);

            mainEnd.startDelay = 10;
            activated = false;

        }
    }
}
