using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TerrainGenerator : MonoBehaviour
{
    //EPISODE 2

    #region FBM
    [Header("FBM")]

    [SerializeField] int frequency;
    [SerializeField] int amplitude;
    [SerializeField] float octave;
    [SerializeField] int lacunarity;

    [Space]
    #endregion

    #region Preference
    [Header("PREFRENCES")]
    public bool Randomized = true;      //BOOL NOT IN TUTORIAL {Do you want the terrain generated each time?}
    public bool Animate = true;         //BOOL NOT IN TUTORIAL {Do you want it to be animated and move?
    public float Speed = 5;             //FLOAT NOT IN TUTORIAL {If animating, how fast?)
    //if Animate is true, it works with colliders (add a rigid body to a cube and place the cube above terrain)

    [Space]

    public int depth = 20;  //height from above

    public int width = 20;     //make a int named width and set it to a default of 256
    public int height = 20;    //make int named height and set it to a default of 256 [Length of terrain]

    public float Scale = 1;

    public float offsetX = 100;
    public float offsetY = 100;
    #endregion



    public void Start()
    {
       /* offsetX = Random.Range(0, 99999);
        offsetY = Random.Range(0, 99999);*/
    }


    void Update()
    {
        Terrain terrain = GetComponent<Terrain>();      //for Terrain Data
        terrain.terrainData = GenerateTerrain(terrain.terrainData);

        if (Animate == true)
        {
            offsetX += Time.deltaTime * Speed;
            offsetY += Time.deltaTime * Speed;
        }
    }


    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;

        terrainData.size = new Vector3(frequency, depth, amplitude);

        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }

    float[,] GenerateHeights()
    {

        float[,] heights = new float[frequency, amplitude];
        for (int x = 0; x < frequency; x++)
        {
            for (int y = 0; y < amplitude; y++)
            {
                  heights[x, y] = CalculateHeight(x, y);      //generate some perlin noise value
            }
        }



        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCord = (float)x / frequency * Scale;
        float yCord = (float)y / amplitude * Scale;

        if (Randomized == true)
        {
            xCord *= offsetX;
            yCord *= offsetY;
        }

        float total = 0;
        float totalAmplitude = 0;
        float result;

        for (int i = 0; i < octave; i++)
        {
            total += Mathf.PerlinNoise(xCord, yCord) * amplitude;
            totalAmplitude += amplitude;
           // amplitude *= (int)0.96f;
            frequency *= lacunarity;

        }

        return result = total / totalAmplitude;



        /*   if (offsetX <= 0) offsetX += Time.deltaTime * Speed;
           if (offsetY <= 0) offsetY += Time.deltaTime * Speed;*/


        //return Mathf.PerlinNoise(xCord, yCord);
    }
}
