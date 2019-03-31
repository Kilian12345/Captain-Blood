using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landing_Control : MonoBehaviour
{

    TerrainGenerator terGen;

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
    }

    void LandingControl()
    {
        moveVert += Input.GetAxis("Vertical") ;
        moveHori += Input.GetAxis("Horizontal") * speed;
        moveFor += Input.GetAxis("Forward") * speed;

        y = camera.localPosition.y + moveVert ;
        camera.localPosition = new Vector3(camera.localPosition.x, y, camera.localPosition.z);

        terGen.offsetY = moveHori;

        terGen.offsetX = moveFor;
        

    }
}
