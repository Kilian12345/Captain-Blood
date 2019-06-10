using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Upcom
{
    public abstract class Word 
    {
        public string name;
        public float weight;

        private static float[] nounsValuesSet = new float[50];

        #region Words
        #region Verbs
        public static Verb Go { get { return new Verb("Go", ); } }
        #endregion
        #endregion

    }

    public class Verb : Word
    {


        public Verb(string _name, float _weight)
        {
            name = _name;
            weight = _weight;
        }

        public enum Type { }
    }

    public class Noun : Word
    {
        public Noun(string _name, float _weight)
        {
            name = _name;
            weight = _weight;
        }
    }

    public class Adjective : Word
    {
        public Adjective(string _name, float _weight)
        {
            name = _name;
            weight = _weight;
        }
    }

    public class Special : Word
    {
        public Special(string _name)
        {
            name = _name;
            weight = 0;
        }
    }
}