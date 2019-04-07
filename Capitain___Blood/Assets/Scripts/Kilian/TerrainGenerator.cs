using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TerrainGenerator : MonoBehaviour
{
    //EPISODE 2
    Terrain_manager terrain_man;

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

    [SerializeField] float startOffset ;
    [SerializeField] float xCord;

    [Space (15)]
    [SerializeField] bool terrain1;
    [SerializeField] bool terrain2;
    [SerializeField] bool terrain3;

    [SerializeField] float multiplicator;
    float factor = 1;
    #endregion



    public void Start()
    {
        terrain_man = GetComponentInParent<Terrain_manager>();

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

        ValueUpdate();
    }

    void ValueUpdate ()
    {
        Speed = terrain_man.speed;
        depth = terrain_man.depth;
        width = terrain_man.width;
        height = terrain_man.height;
        Scale = terrain_man.scale; 

        if (terrain2 == true)
        {
            float value = 97.9289940828f * Scale / 100;
            float newXcord = xCord + value;
            xCord = newXcord;
        }

        if (terrain3 == true)
        {
            float value = 97.9289940828f * Scale / 100;
            float newXcord = xCord + value*2;
            xCord = newXcord;
        }
    }


    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;

        terrainData.size = new Vector3(width, depth, height);

        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                heights[x, y] = CalculateHeight(x, y);      //generate some perlin noise value
            }
        }

        return heights;
    }

    float CalculateHeight(int x, int y)
    {

        if(terrain2 || terrain3) factor = multiplicator;

        xCord = (float)x / width * Scale*multiplicator + offsetX + startOffset*factor ;
        float yCord = (float)y / height * Scale*multiplicator + offsetY;

        if (Randomized == true)
        {
            xCord *= offsetX;
            yCord *= offsetY;
        }


        return Mathf.PerlinNoise(xCord, yCord);
    }
}
