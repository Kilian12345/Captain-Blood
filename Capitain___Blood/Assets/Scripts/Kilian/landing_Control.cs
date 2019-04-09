using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class landing_Control : MonoBehaviour
    {
        [SerializeField] TerrainGenerator[] terGen;
        [SerializeField] GameObject UiImage;

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
            CameraBehavior();

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].GetComponent<Terrain>().materialTemplate.mainTextureOffset = new Vector2(terGen[i].offsetY,terGen[i].offsetX);
            }
        }

        void LandingControl()
        {
            float oldMoveHori = moveHori;
            float oldMoveVert = moveVert;
            moveVert = Input.GetAxis("Vertical");
            moveHori += Input.GetAxis("Horizontal") * speed;
            moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed * variableSpeed;

            ////////////////////////// Camera mouv
            y = transform.localPosition.y + moveVert * 2.5f;
            y = Mathf.Clamp(y, 0, 500);
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].offsetY = spawnLocation;
                terGen[i].offsetY += moveHori * 0.05f;
                terGen[i].offsetX = moveFor;

                terGen[i].offsetY = Mathf.Clamp(terGen[i].offsetY, pointA, pointB);

                if (terGen[i].offsetY == pointA || terGen[i].offsetY == pointB)
                {moveHori = oldMoveHori;}
            }

        }
        void CameraBehavior()
        {
            Quaternion transRotate = transform.localRotation;
            transRotate.x = Mathf.Lerp(0, 23, (y*2) / 1000 );
            transRotate.y = 0;
            transRotate.z = 0;
            transRotate.w = 0;
            transform.localRotation = Quaternion.Euler(transRotate.x, 0f, 0f); 

            Debug.Log(transform.localRotation);
        }
        void Curseur()
        {
            float imageX;
            imageX = UiImage.transform.localPosition.x + moveHori;
            imageX = Mathf.Clamp(y, 0, 500);
            UiImage.transform.localPosition = new Vector3(imageX, UiImage.transform.localPosition.y, UiImage.transform.localPosition.z);
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
