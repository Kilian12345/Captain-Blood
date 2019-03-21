using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    [CreateAssetMenu(fileName = "New Galaxy", menuName = "Galaxy")]
    public class GalaxySCO : ScriptableObject
    {
        public Dictionary<Vector2Int, Planet> galaxy = new Dictionary<Vector2Int, Planet>();
    }
}