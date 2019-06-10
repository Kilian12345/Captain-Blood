using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Upcom
{
    public abstract class Word 
    {
        public string name;
        public float weight;
        public int valency;

        private static float[] nounsValuesSet = new float[50];

        #region Words
        #region Verbs
        public static Verb Go { get { return new Verb("Go", .25f, 2); } }
        public static Verb Want { get { return new Verb("Want", .25f, 3); } }
        public static Verb Teleport { get { return new Verb("Teleport", .25f, 2); } }
        public static Verb Give { get { return new Verb("Give", .75f, 3); } }
        public static Verb Like { get { return new Verb("Like", 1.0f, 2); } }
        public static Verb Say { get { return new Verb("Say", .25f, 3); } }
        public static Verb Know { get { return new Verb("Know", .5f, 2); } }
        public static Verb Search { get { return new Verb("Search", .5f, 2); } }
        public static Verb Help { get { return new Verb("Help", .75f, 2); } }
        public static Verb Destroy { get { return new Verb("Destroy", -1.0f, 2); } }
        public static Verb Free { get { return new Verb("Free", .85f, 2); } }
        public static Verb Kill { get { return new Verb("Kill", -.85f, 2); } }
        public static Verb Be { get { return new Verb("Be", .25f, 2); } }
        public static Verb Thank { get { return new Verb("Thank", .85f, 2); } }
        public static Verb Pray { get { return new Verb("Pray", .5f, 2); } }
        public static Verb Believe { get { return new Verb("Believe", .5f, 2); } }
        public static Verb Trade { get { return new Verb("Trade", .25f, 2); } }
        public static Verb Find { get { return new Verb("Find", .25f, 2); } }
        public static Verb See { get { return new Verb("See", .25f, 2); } }
        public static Verb Set { get { return new Verb("Set", .25f, 2); } }
        #endregion
        #endregion

    }

    public class Verb : Word
    {
        public SentenceConstruction construction;

        public Verb(string _name, float _weight, int _valency)
        {
            name = _name;
            weight = _weight;
            valency = _valency;
        }
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