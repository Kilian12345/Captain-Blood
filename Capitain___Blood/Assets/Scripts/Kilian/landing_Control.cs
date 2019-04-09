using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class landing_Control : MonoBehaviour
    {
        [SerializeField] TerrainGenerator[] terGen;

        [SerializeField]float speed;
        [SerializeField]float moveVert;
        [SerializeField]float moveHori;
        [SerializeField]float moveFor;

        float y;
        float pointA;
        float pointB;
        float currentObjective;
        float spawnLocation;

        #region Static Speed

        [Space (20)]
         float speed0 = 0f;
         float speed1 = 0.5f;
         float speed2 = 1f;
         float speed3 = 1.5f;
         float speed4 = 2f;
         float variableSpeed = 0.1f;
        #endregion

        private void Start()
        {
            StartLandingSettings();
        }

        void StartLandingSettings()
        {
            pointA = Random.Range(20, 900);
            pointB = pointA + 100;
            currentObjective = Random.Range(pointA + 20, pointB - 20);
            spawnLocation = Random.Range(pointA + 20, pointB - 20);

            Debug.Log("PointA" + pointA);
            Debug.Log("PointB" + pointB);
            Debug.Log("currentObjective" + currentObjective);
            Debug.Log("spawnLocation" + spawnLocation);

        }

        void Update()
        {
            LandingControl();

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].GetComponent<Terrain>().materialTemplate.mainTextureOffset = new Vector2(terGen[i].offsetY,terGen[i].offsetX);
            }
        }

        void LandingControl()
        {
            float oldMoveHori = moveHori;
            moveVert += Input.GetAxis("Vertical") ;
            moveHori += Input.GetAxis("Horizontal") * speed;
            moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed * variableSpeed;

            ////////////////////////// Camera mouv
            y = transform.localPosition.y + moveVert * 0.05f;
            y = Mathf.Clamp(y, 351, 400);
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].offsetY = spawnLocation;
                terGen[i].offsetY += moveHori * 0.05f;
                terGen[i].offsetX = moveFor;

                terGen[i].offsetY = Mathf.Clamp(terGen[i].offsetY, pointA, pointB);

                if (terGen[i].offsetY == pointA || terGen[i].offsetY == pointB)
                {
                   moveHori = oldMoveHori;

                }
            }

        }

        void OnCollisionEnter (Collision col)
        {
            if (col.gameObject.tag == "Terrain")
            {
                variableSpeed = speed0;
            }
        }

        
    }

}
