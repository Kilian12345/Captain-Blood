using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landing_Control : MonoBehaviour
{

    TerrainGenerator terGen;

    [SerializeField] Transform cam;

    [SerializeField]float speed;
    [SerializeField]float moveVert;
    [SerializeField]float moveHori;
    [SerializeField]float moveFor;
    [SerializeField] float vertSpeed;

    float y;

    // Start is called before the first frame update
    void Start()
    {
        terGen = GetComponent<TerrainGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        LandingControl();
    }

    void LandingControl()
    {
        moveVert += Input.GetAxis("Vertical") ;
        moveHori += Input.GetAxis("ScrollHorizontal") * speed;
        moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed*0.1f +.004f;




        y = moveVert*vertSpeed;
        cam.localPosition = new Vector3(cam.localPosition.x, y, cam.localPosition.z);

        terGen.offsetY = moveHori;

        terGen.offsetX = moveFor;
        

    }

    void LandingControl2()
    {

    }
}
