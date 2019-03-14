
using UnityEngine;
using System.Collections;

namespace RetroJam.CaptainBlood
{

	//[ExecuteInEditMode]
	public class Parallax2D : MonoBehaviour
    {

		[System.Serializable]
		public struct TwoDeeLayer
        {

			[Range(0.0f, 1.0f)]
			public float move_multipler;
			public float zPos;
			public Transform layer;
            public Vector3 layerScale;

		}

        [SerializeField] GameObject spawnLayer;
		public Transform     _targetCam;
		public Vector2       _offset = Vector2.zero;
		public TwoDeeLayer[] _layers;


		void Reset()////////////////////////////////////UPDATE
        {
			_layers = new TwoDeeLayer[transform.childCount];

			for(int i=0; i< transform.childCount; i++)
            {
				_layers[i].layer = transform.GetChild(i);
				_layers[i].move_multipler = (float)(i+1)/((float)transform.childCount+1.0f);
				_layers[i].zPos = (i+1)*1.0f;

			}

		}

		// Use this for initialization
		void Start ()
        {

			if( !_targetCam)
            {
				_targetCam = Camera.main.transform;
			}

		}

        private void Update()
        {
            for (int i = 8; i >= 0; i--)
            {
              
                _layers[i].layerScale = transform.GetChild(i).localScale;

                Vector3 Scale = transform.GetChild(i).localScale;

                Scale = new Vector3(Scale.x + Time.deltaTime, Scale.y + Time.deltaTime);

                transform.GetChild(i).localScale = Scale;

                if (Scale.x == 1.2)
                {
                    Destroy(transform.GetChild(i));
                    Instantiate(spawnLayer, transform.parent);
                    Reset();
                }


            }



            //Reset();
        }

        void LateUpdate()
        {

			if( !_targetCam)
            {
				_targetCam = Camera.main.transform;
				return;
			}

			AdjustLayers(_targetCam.position);



		}

//		public void OnWillRenderObject()
//		{
//			if(!enabled)
//				return;
//
//			Camera cam = Camera.current;
//			if( !cam )
//				return;
//
//			AdjustLayers(cam.transform.position);
//
//		}

		void AdjustLayers(Vector3 viewPoint)
        {

			viewPoint += (Vector3) _offset;

			Vector3 displacement = viewPoint - transform.position;
			Vector3 layerSpot = Vector3.zero;

			for(int i=0; i<_layers.Length; i++)
            {

				layerSpot = displacement * _layers[i].move_multipler;
				layerSpot.z = _layers[i].zPos;

				_layers[i].layer.localPosition = layerSpot;

			}

		}
	}

}