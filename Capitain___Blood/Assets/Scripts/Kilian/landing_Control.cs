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

        #region Static Speed

        [Space (20)]
         float speed0 = 0f;
         float speed1 = 0.5f;
         float speed2 = 1f;
         float speed3 = 1.5f;
         float speed4 = 2f;
         float variableSpeed = 0.1f;
        #endregion

        // Update is called once per frame
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
            moveVert += Input.GetAxis("Vertical") ;
            moveHori += Input.GetAxis("Horizontal") * speed;
            moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed * variableSpeed;


            y = transform.localPosition.y + moveVert * 0.05f;
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);

            for (int i = 0; i < terGen.Length; i++)
            {
                terGen[i].offsetY = moveHori * 0.05f;
                terGen[i].offsetX = moveFor;
            }   

            #region IF
            //if()
            #endregion

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
