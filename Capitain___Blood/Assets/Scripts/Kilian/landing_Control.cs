using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landing_Control : MonoBehaviour
{

   /*  TerrainGenerator terGen;

    [SerializeField] Transform camera;

    [SerializeField]float speed;
    [SerializeField]float moveVert;
    [SerializeField]float moveHori;
    [SerializeField]float moveFor;

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

        GetComponent<Terrain>().materialTemplate.mainTextureOffset = new Vector2(terGen.offsetY,terGen.offsetX);
    }

    void LandingControl()
    {
        moveVert += Input.GetAxis("Vertical") ;
        moveHori += Input.GetAxis("Horizontal") * speed;
        moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed*0.1f +.004f;




        y = camera.localPosition.y + moveVert * 0.05f;
        camera.localPosition = new Vector3(camera.localPosition.x, y, camera.localPosition.z);

        terGen.offsetY = moveHori * 0.05f;

        terGen.offsetX = moveFor;
        

    }*/
    [SerializeField] TerrainGenerator[] terGen;

    [SerializeField]float speed;
    [SerializeField]float moveVert;
    [SerializeField]float moveHori;
    [SerializeField]float moveFor;

    float y;

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
        moveFor += (1-Mathf.Abs(Input.GetAxis("Forward"))) * speed*0.1f +.004f;




        y = transform.localPosition.y + moveVert * 0.5f;
        transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);

        for (int i = 0; i < terGen.Length; i++)
        {
            terGen[i].offsetX = moveFor;
            terGen[i].offsetY = moveHori * 0.05f;
        }       

    }
}
