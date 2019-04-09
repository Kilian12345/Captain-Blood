using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RetroJam.CaptainBlood.MissionsLib;

namespace RetroJam.CaptainBlood
{
    public class MissionsManager : MonoBehaviour
    {
        public FindCode missionFindCode;

        // Start is called before the first frame update
        void Start()
        {
            missionFindCode = new FindCode();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}