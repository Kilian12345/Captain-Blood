using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RetroJam.CaptainBlood
{
    public class landing_Control : MonoBehaviour
    {
        [SerializeField] TerrainGenerator[] terGen;
        [SerializeField] RectTransform UiImage;
        [SerializeField] Animator UiAnimator;
        [SerializeField] float cursorSensitivity;
        [Space]
        [SerializeField] Transform CurseurY;
        [SerializeField] GameObject[] speedBarBottom;

        [Space]
        [Header ("Value")]

        [SerializeField]float speed;
        [SerializeField]float moveVert;
        [SerializeField]float moveHori;
        [SerializeField]float moveFor;

        float moveHoriCursor;
        float y;
        float imageX;
        float pointA;
        float pointB;
        float currentObjective;
        float spawnLocation;
        float limiteLeft, limiteRight;

        #region Static Speed

        [Space (20)]
         [SerializeField] float[] variableSpeed;
         [SerializeField, Range(0,5)] int indexSpeed;
         bool gotInput;
        #endregion

        private void Start()
        {
            StartLandingSettings();
        }

        void StartLandingSettings()
        {
            pointA = Random.Range(20, 900);
            pointB = pointA + 50;
            currentObjective = Random.Range(pointA + 10, pointB - 10);
            spawnLocation = Random.Range(pointA + 10, pointB - 10);
           
            limiteLeft = currentObjective - 0.5f;
            limiteRight = currentObjective + 0.5f;

            Debug.Log("PointA" + pointA);
            Debug.Log("PointB" + pointB);
            Debug.Log("currentObjective" + currentObjective);
            Debug.Log("spawnLocation" + spawnLocation);

        }

        void Update()
        {
            LandingControl();
            CameraBehavior();
            Curseur();
            SpeedFunction();

            Debug.Log("limiteLeft" + limiteLeft);
            Debug.Log("limiteRight" + limiteRight);

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
            moveHoriCursor = Input.GetAxis("Horizontal") * 2;
            moveFor += /*(1-Mathf.Abs(Input.GetAxis("Forward")))* */ speed * variableSpeed[indexSpeed];

            ////////////////////////// Camera mouv
            y = transform.localPosition.y + moveVert * 2.5f;
            y = Mathf.Clamp(y, 0, 500);
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
            //

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].offsetY = spawnLocation;
                terGen[i].offsetY += moveHori * 0.05f;
                terGen[i].offsetX = moveFor;

                terGen[i].offsetY = Mathf.Clamp(terGen[i].offsetY, pointA, pointB);

                if (terGen[i].offsetY == pointA || terGen[i].offsetY == pointB)
                {moveHori = oldMoveHori;}

                ///////////////////////// Objectif Zone

                if(limiteLeft > terGen[i].offsetY)   {UiAnimator.SetBool("IsRight",true);}
                else {UiAnimator.SetBool("IsRight",false);}

                if (terGen[i].offsetY > limiteRight)   {UiAnimator.SetBool("IsLeft",true);}
                else {UiAnimator.SetBool("IsLeft",false);}

                //

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
        }
        void Curseur()
        {
            float fac = Mathf.Exp(-(Mathf.Pow(UiImage.localPosition.x/75,2)/(2*Mathf.Pow(.35f,2))));
            imageX = UiImage.localPosition.x + moveHoriCursor * fac;
            imageX = Mathf.Clamp(imageX, -100, 100);
            UiImage.localPosition = new Vector3(imageX, UiImage.localPosition.y, UiImage.localPosition.z);

            if (Input.GetAxis("Horizontal") == 0)
            {
                if (UiImage.localPosition.x > 0)
                {UiImage.localPosition = new Vector3(UiImage.localPosition.x - cursorSensitivity, UiImage.localPosition.y, UiImage.localPosition.z);}
            
                if (UiImage.localPosition.x < 0)
                {UiImage.localPosition = new Vector3(UiImage.localPosition.x + cursorSensitivity, UiImage.localPosition.y, UiImage.localPosition.z);}
            
            }

            Vector3 curY = CurseurY.localPosition;
            curY.x = CurseurY.localPosition.x;
            curY.y = (y * 100 /500) - 50;
            curY.z = CurseurY.localPosition.z;
            CurseurY.localPosition = curY;    
        }
        void SpeedFunction()
        {
            if(!gotInput)
            {
                if(Input.GetAxis("Forward") < -.5f)
                {
                    gotInput = true;
                    indexSpeed = Mathf.Clamp(indexSpeed-1, 1,5);
                }
                else if(Input.GetAxis("Forward") > .5f)
                {
                    gotInput = true;
                    indexSpeed = Mathf.Clamp(indexSpeed+1, 1,5);
                }
            }
            else
            {
                if(Input.GetAxis("Forward") > -.3f && Input.GetAxis("Forward") < .3f) gotInput = false;
            }

            for (int i = 0; i < speedBarBottom.Length; i++)
            {
               // speedBarBottom[i] = variableSpeed[indexSpeed];
            }
            
        }
        void OnCollisionEnter (Collision col)
        {
            if (col.gameObject.tag == "Terrain")
            {
                indexSpeed = 0;
            }
        }
          
    }

}
