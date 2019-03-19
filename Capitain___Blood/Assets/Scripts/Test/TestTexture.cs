using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public class TestTexture : MonoBehaviour
    {
        private Texture2D texture;

        public int height;

        // Start is called before the first frame update
        void Start()
        {
            InitializeTexture();
        }

        // Update is called once per frame
        void Update()
        {
            HeightOfLine();

            TestLine();
        }

        public void TestLine()
        {
            CleanImage();
            DrawLine();

            texture.Apply(true);
        }

        public void HeightOfLine()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) height++;
            else if (Input.GetKeyDown(KeyCode.DownArrow)) height--;

            height = Mathf.Clamp(height, 0, 99);
        }

        public void InitializeTexture()
        {
            texture = new Texture2D(256, 100);

            GetComponent<RawImage>().material.mainTexture = texture;
        }

        public void CleanImage()
        {
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    texture.SetPixel(x, y, Color.black);
                }
            }
        }

        public void DrawLine()
        {
            for (int i = 0; i < 256; i++)
            {
                texture.SetPixel(i, height, Color.blue);
            }
        }
    }
}