using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RetroJam.CaptainBlood
{
    public class CoordManager : MonoBehaviour
    {
        [SerializeField] private Vector2Int coord;
        [SerializeField] private Transform x;
        [SerializeField] private TextMeshProUGUI xScreen;
        [SerializeField] private Transform y;
        [SerializeField] private TextMeshProUGUI yScreen;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            LineManager();
            ScreenManager();
        }

        public void ScreenManager()
        {
            xScreen.text = coord.x.ToString();
            yScreen.text = coord.y.ToString();
        }

        public void LineManager()
        {
            x.localPosition = new Vector3(coord.x-128, 0);
            y.localPosition = new Vector3(0, coord.y-63);
        }
    }
}