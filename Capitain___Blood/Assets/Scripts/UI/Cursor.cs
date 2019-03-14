using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class Cursor : MonoBehaviour
    {
        [SerializeField, Range(1,40)] private float speed;
        private Camera cam;

        public Vector2 Debug1;

        private void Awake()
        {
            cam = Camera.main;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Move();

            Debug1 = cam.WorldToScreenPoint(transform.position);
        }

        public void Move()
        {
            Vector3 pos = cam.WorldToScreenPoint(transform.position);

            if (Input.GetAxis("Horizontal") != 0)
            {
                if ((pos.x >= 5 && pos.x <= 320)
                    || (pos.x < 5 && Input.GetAxis("Horizontal") > 0)
                    || (pos.x > 310 && Input.GetAxis("Horizontal") < 0))
                {
                    transform.position += new Vector3(Input.GetAxis("Horizontal") > 0 ? Mathf.Pow(Input.GetAxis("Horizontal"), 2) : -Mathf.Pow(Input.GetAxis("Horizontal"),2),0, 0) * speed * Time.deltaTime;
                }
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                if ((pos.y >= 2 && pos.y <= 87)
                    || (pos.y < 2 && Input.GetAxis("Vertical") > 0)
                    || (pos.y > 87 && Input.GetAxis("Vertical") < 0))
                {
                    transform.position += new Vector3(0,Input.GetAxis("Vertical") > 0 ? Mathf.Pow(Input.GetAxis("Vertical"), 2) : -Mathf.Pow(Input.GetAxis("Vertical"), 2), 0) * speed * Time.deltaTime;
                }
            }

            pos = cam.WorldToScreenPoint(transform.position);

            transform.position = cam.ScreenToWorldPoint(new Vector3(Mathf.Clamp(pos.x, 5, 310), Mathf.Clamp(pos.y, 2, 87), pos.z));


        }

        public bool AbleToMove(int _limit)
        {
            return ((cam.WorldToViewportPoint(transform.position).y < 0 || cam.WorldToScreenPoint(transform.position).y > _limit) && (cam.WorldToViewportPoint(transform.position).x < 0 || cam.WorldToViewportPoint(transform.position).x > 1));
        }

        public bool AbleToMove()
        {
            return ((cam.WorldToViewportPoint(transform.position).y > 0 && cam.WorldToScreenPoint(transform.position).y < 89) && (cam.WorldToViewportPoint(transform.position).x > 0 && cam.WorldToViewportPoint(transform.position).x < 1));
        }
    }
}