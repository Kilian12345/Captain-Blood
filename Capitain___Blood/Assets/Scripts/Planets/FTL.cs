using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class FTL : EventsManager
    {
        public float speed;
        public bool play;

        [SerializeField] private ParticleSystem particle;

        // Start is called before the first frame update
        void Start()
        {
            particle.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O)) play = true;

            if (play) PlayParticles();
            else
            {
                particle.Stop(true);
            }
        }

        public void PlayParticles()
        {
            if (particle.isStopped) particle.Play();

            particle.startSpeed *= 1+Time.deltaTime * speed;

            var em = particle.emission;
            em.enabled = true;
            em.rateOverTime = particle.startSpeed *-0.8f;

            var sh = particle.shape;
            sh.enabled = true;
            sh.radius = 80 + Time.deltaTime * speed * 4;
        }

        public override void StartFTL()
        {
            play = true;
        }

    }
}