using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_manager : MonoBehaviour
{
    public float speed = 0.01f;
    public int depth = 33;
    public int width = 65;
    public int height = 65;
    public float scale = 3.38f;

    [Range(0.0f,3.0f)]public float multiplicateur = 1;

}
