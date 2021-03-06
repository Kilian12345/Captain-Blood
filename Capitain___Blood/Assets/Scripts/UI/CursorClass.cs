﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.CursorLib
{
    [System.Serializable]
    public class ButtonBound
    {
        public Vector2 position;

        public static bool operator <(ButtonBound a, Vector3 b) { return a.position.x < b.x && a.position.y < b.y; }
        public static bool operator >(ButtonBound a, Vector3 b) { return a.position.x > b.x && a.position.y > b.y; }
        public static bool operator <(ButtonBound a, Vector2Int b) { return a.position.x < b.x && a.position.y < b.y; }
        public static bool operator >(ButtonBound a, Vector2Int b) { return a.position.x > b.x && a.position.y > b.y; }
        public static bool operator <(Vector3 a, ButtonBound b) { return a.x < b.position.x && a.y < b.position.y; }
        public static bool operator >(Vector3 a, ButtonBound b) { return a.x > b.position.x && a.y > b.position.y; }
        public static bool operator <(Vector2Int a, ButtonBound b) { return a.x < b.position.x && a.y < b.position.y; }
        public static bool operator >(Vector2Int a, ButtonBound b) { return a.x > b.position.x && a.y > b.position.y; }
    }

    [System.Serializable]
    public class Button
    {
        public ButtonBound bottomLeft;
        public ButtonBound upRight;

        public bool IsCursorOver(Transform _cursor)
        {
            return _cursor.position > bottomLeft && _cursor.position < upRight;
        }
    }

    [CreateAssetMenu(fileName ="Saving Buttons", menuName ="Buttons")]
    public class SaveButtons : ScriptableObject
    {
        public Button[] main;
        public Button[] galaxy;
        public Button[] planet;
        public Button[] landing;
        public Button[] upcom;
    }
}