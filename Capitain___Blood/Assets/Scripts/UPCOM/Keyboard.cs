using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

namespace RetroJam.CaptainBlood
{
    public class Keyboard : MonoBehaviour
    {
        [SerializeField, Range(1, 40)] private float speed;
        [SerializeField] private Transform pointer;
        [SerializeField] private Tilemap tm;
        [SerializeField] private TextMeshProUGUI textField;
        [SerializeField] DialoguesManager manager;

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

            Interact();
        }

        public void Scroll()
        {
            if (Input.GetAxis("Scroll") != 0)
            {
                transform.position -= new Vector3(Input.GetAxis("Scroll") > 0 ? Mathf.Pow(Input.GetAxis("Scroll"), 2) : -Mathf.Pow(Input.GetAxis("Scroll"), 2), 0, 0) * speed * Time.deltaTime;
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

        public void Selection(Vector3 _pos)
        {
            textField.text = "";

            if (_pos.x < -5.6 || _pos.y < -3.75 || _pos.x > 5.6 || _pos.y > -1.9) return;

            Vector3Int cursor = tm.WorldToCell(_pos);

            textField.text = dictionary[cursor].ToText();

            if (Input.GetButtonDown("Select1")) manager.player.AddWord(dictionary[cursor]);

        }

        public void Remove()
        {
            if (pointer.position.x < 5.95 || pointer.position.y < -2.7 || pointer.position.x > 7 || pointer.position.y > -1.9) return;

            if(Input.GetButtonDown("Select1"))
            {
                manager.player.RemoveWord();
            }
        }

        public void Interact()
        {
            Selection(pointer.position);
            Remove();

        }

    }
}