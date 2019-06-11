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
        #region Adjectives
        public static Adjective Unknown { get { return new Adjective("Unknown", .8f); } }
        public static Adjective Forbidden { get { return new Adjective("Forbidden", .25f); } }
        public static Adjective Impossible { get { return new Adjective("Impossible", .2f); } }
        public static Adjective Urgent { get { return new Adjective("Urgent", .9f); } }
        public static Adjective Different { get { return new Adjective("Different", 1.0f); } }
        public static Adjective Small { get { return new Adjective("Small", .5f); } }
        public static Adjective Great { get { return new Adjective("Great", 1.5f); } }
        public static Adjective Strong { get { return new Adjective("Strong", 1.6f); } }
        public static Adjective Weak { get { return new Adjective("Weak", .4f); } }
        public static Adjective Bad { get { return new Adjective("Bad", .3f); } }
        public static Adjective Brave { get { return new Adjective("Brave", 1.3f); } }
        public static Adjective Good { get { return new Adjective("Good", 1.4f); } }
        public static Adjective Crazy { get { return new Adjective("Crazy", .4f); } }
        public static Adjective Poor { get { return new Adjective("Poor", .7f); } }
        public static Adjective Rich { get { return new Adjective("Rich", 1.3f); } }
        public static Adjective Dead { get { return new Adjective("Dead", .1f); } }
        public static Adjective Alive { get { return new Adjective("Alive", 1.1f); } }
        public static Adjective Sinful { get { return new Adjective("Sinful", .2f); } }
        public static Adjective Sacred { get { return new Adjective("Sacred", 1.5f); } }
        public static Adjective Known { get { return new Adjective("Known", 1.2f); } }
        public static Adjective Beautiful { get { return new Adjective("Beautiful", 1.3f); } }
        public static Adjective Disabled { get { return new Adjective("Disabled", .5f); } }
        public static Adjective Enabled { get { return new Adjective("Enabled", 1.5f); } }
        public static Adjective Stupid { get { return new Adjective("Stupid", .2f); } }
        #endregion
        #region Nouns
        public static Noun Me { get { return new Noun("Me", nounsValuesSet[0]); } }
        public static Noun You { get { return new Noun("Me", nounsValuesSet[1]); } }
        public static Noun Fear { get { return new Noun("Me", nounsValuesSet[2]); } }
        public static Noun Prison { get { return new Noun("Me", nounsValuesSet[3]); } }
        public static Noun Prisonner { get { return new Noun("Me", nounsValuesSet[4]); } }
        public static Noun Trap { get { return new Noun("Me", nounsValuesSet[5]); } }
        public static Noun Danger { get { return new Noun("Me", nounsValuesSet[6]); } }
        public static Noun Money { get { return new Noun("Me", nounsValuesSet[7]); } }
        public static Noun Information { get { return new Noun("Me", nounsValuesSet[8]); } }
        public static Noun Nonsense { get { return new Noun("Me", nounsValuesSet[9]); } }
        public static Noun RDV { get { return new Noun("Me", nounsValuesSet[10]); } }
        public static Noun Time { get { return new Noun("Me", nounsValuesSet[11]); } }
        public static Noun Idea { get { return new Noun("Me", nounsValuesSet[12]); } }
        public static Noun Code { get { return new Noun("Me", nounsValuesSet[13]); } }
        public static Noun Friend { get { return new Noun("Me", nounsValuesSet[14]); } }
        public static Noun Enemy { get { return new Noun("Me", nounsValuesSet[15]); } }
        public static Noun Warrior { get { return new Noun("Me", nounsValuesSet[16]); } }
        public static Noun Leader { get { return new Noun("Me", nounsValuesSet[17]); } }
        public static Noun Scientist { get { return new Noun("Me", nounsValuesSet[18]); } }
        public static Noun Sex { get { return new Noun("Me", nounsValuesSet[19]); } }
        public static Noun Reproduction { get { return new Noun("Me", nounsValuesSet[20]); } }
        public static Noun Male { get { return new Noun("Me", nounsValuesSet[21]); } }
        public static Noun Female { get { return new Noun("Me", nounsValuesSet[22]); } }
        public static Noun Identity { get { return new Noun("Me", nounsValuesSet[23]); } }
        public static Noun Parent { get { return new Noun("Me", nounsValuesSet[24]); } }
        public static Noun People { get { return new Noun("Me", nounsValuesSet[25]); } }
        public static Noun Peace { get { return new Noun("Me", nounsValuesSet[26]); } }
        public static Noun War { get { return new Noun("Me", nounsValuesSet[27]); } }
        public static Noun Death { get { return new Noun("Me", nounsValuesSet[28]); } }
        public static Noun Life { get { return new Noun("Me", nounsValuesSet[29]); } }
        public static Noun Home { get { return new Noun("Me", nounsValuesSet[30]); } }
        public static Noun Ship { get { return new Noun("Me", nounsValuesSet[31]); } }
        public static Noun Contact { get { return new Noun("Me", nounsValuesSet[32]); } }
        public static Noun Planet { get { return new Noun("Me", nounsValuesSet[33]); } }
        public static Noun Hour { get { return new Noun("Me", nounsValuesSet[34]); } }
        public static Noun Coordinates { get { return new Noun("Me", nounsValuesSet[35]); } }
        public static Noun Truth { get { return new Noun("Me", nounsValuesSet[36]); } }
        public static Noun Priest { get { return new Noun("Me", nounsValuesSet[37]); } }
        public static Noun Sanctuary { get { return new Noun("Me", nounsValuesSet[38]); } }
        public static Noun Fight { get { return new Noun("Me", nounsValuesSet[39]); } }
        public static Noun Species { get { return new Noun("Me", nounsValuesSet[40]); } }
        public static Noun Moon { get { return new Noun("Me", nounsValuesSet[41]); } }
        public static Noun Weapon { get { return new Noun("Me", nounsValuesSet[42]); } }
        public static Noun Infidel { get { return new Noun("Me", nounsValuesSet[43]); } }
        public static Noun Neighbour { get { return new Noun("Me", nounsValuesSet[44]); } }
        public static Noun Believer { get { return new Noun("Me", nounsValuesSet[45]); } }
        public static Noun Migrax { get { return new Noun("Me", nounsValuesSet[46]); } }
        public static Noun Yukas { get { return new Noun("Me", nounsValuesSet[47]); } }
        public static Noun Duplicates { get { return new Noun("Me", nounsValuesSet[48]); } }
        public static Noun Blood { get { return new Noun("Me", nounsValuesSet[49]); } }
        #endregion
        #region Special
        public static Special none { get { return new Special("", 0); } }
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
        public Special(string _name, float _weight)
        {
            name = _name;
            weight = _weight;
        }
    }
}