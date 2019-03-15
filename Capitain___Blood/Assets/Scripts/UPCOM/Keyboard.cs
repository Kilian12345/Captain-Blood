using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace RetroJam.CaptainBlood
{
    public class Keyboard : MonoBehaviour
    {
        [SerializeField, Range(1, 40)] private float speed;
        [SerializeField] private Tilemap tm;

        private Dictionary<Vector3Int, Word> dictionary = new Dictionary<Vector3Int, Word>();

        private Camera cam;

        public Vector3Int debugPos;


        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;

            InitializeKeyboard();
        }

        // Update is called once per frame
        void Update()
        {
            Scroll();

            DebugMousePos();
        }

        public void Scroll()
        {
            if (Input.GetAxis("Scroll") != 0)
            {
                transform.position += new Vector3(Input.GetAxis("Scroll") > 0 ? Mathf.Pow(Input.GetAxis("Scroll"), 2) : -Mathf.Pow(Input.GetAxis("Scroll"), 2), 0, 0) * speed * Time.deltaTime;
            }

            if (transform.localPosition.x > 0 || transform.localPosition.x < -736)
            {
                transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, -736, 0), transform.localPosition.y, transform.localPosition.z);
            }
        }

        public void DebugMousePos()
        {
            Vector3 cursor = cam.ScreenToWorldPoint(Input.mousePosition);

            debugPos = tm.WorldToCell(cursor);

            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log(dictionary[debugPos]);
            }
        }

        public void InitializeKeyboard()
        {
            for (int i = 1; i < 120; i+=2)
            {
                dictionary[new Vector3Int(-7 + Mathf.FloorToInt(i / 2), 0, 0)] = (Word)i;
                dictionary[new Vector3Int(-7 + Mathf.FloorToInt(i / 2), -1, 0)] = (Word)i+1;
            }
        }
    }
}