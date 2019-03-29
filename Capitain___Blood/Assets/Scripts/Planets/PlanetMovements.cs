using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class PlanetMovements : EventsManager
    {
        [SerializeField] private float speedOfRotation;
        [SerializeField] private float framer;

        private float buffer = 0;

        [SerializeField] private float graal;
        [SerializeField, Range(0, 10)] private float speed;
        private float time;

        [SerializeField] private bool isArriving;
        [SerializeField] private bool isAccelerating;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Lag();
            //TransformManager();

            transform.Rotate(Vector3.up, speedOfRotation);
            TransformManager();

            DebugInput();

            if (isArriving && !isAccelerating) PlanetArrival();
            else if (isAccelerating && !isArriving) PlanetDeparture();
        }

        public void Lag()
        {
            buffer += Time.deltaTime;

            if (buffer > framer)
            {
                transform.Rotate(Vector3.up, speedOfRotation);
                TransformManager();
                buffer = 0;
            }
        }

        public void TransformManager()
        {
            transform.localPosition = new Vector2(-4 * graal, graal);
            transform.localScale = new Vector3(4 * graal, 4 * graal, 4 * graal);
        }

        public void PlanetArrival()
        {
            time += Time.deltaTime * speed;

            graal = Mathf.Clamp(Mathf.Log10(time) + 1.5f / 1.5f, 0, 1);

            if(graal == 1)
            {
                time = 0;
                isArriving = false;
            }
        }

        public void PlanetDeparture()
        {
            time += Time.deltaTime * speed * 3;

            graal = Mathf.Clamp(Mathf.Pow(time,2.5f)+1, 1, 4);

            /*if (graal > 3)
            {
                GameManager.events.CallFTLDistortionIn();
                GameManager.events.CallStartFTL();
            }*/

            if (graal == 4)
            {
                time = 0;
                isAccelerating = false;
                graal = 0;
                GameManager.events.CallFTLDistortionIn();
                GameManager.events.CallStartFTL();
            }
        }

        public void DebugInput()
        {
            if(Input.GetKeyDown(KeyCode.F)&&!isAccelerating&&!isArriving)
            {
                if (graal == 0) isArriving = true;
                else isAccelerating = true;
            }
        }

        public override void InitializingFTL()
        {
            Debug.Log("Starting Acceleration");
            isAccelerating = true;
        }

        public override void SlowingDown()
        {
            Debug.Log("Starting slowing down");
            isArriving = true;
        }

    }
}