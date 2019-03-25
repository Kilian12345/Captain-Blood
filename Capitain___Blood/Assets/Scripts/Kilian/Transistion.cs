using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[ExecuteInEditMode]
public class Transistion : MonoBehaviour
{
    PostProcessVolume volume;
    LensDistortion lensLayer = null;
    public Material TransitionMaterial;

    float time;
    bool done;


    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<PostProcessVolume>();

        volume.profile.TryGetSettings(out lensLayer);

        TransitionMaterial.shader = Shader.Find("Custom/BattleTransitions");
    }

    // Update is called once per frame
    void Update()
    {
        lensDistord();
       
    }


    void lensDistord()
    {
        lensLayer.intensity.value = Mathf.Lerp(0, -100, time);
        float shininess = Mathf.Lerp(0, 1, time *0.35f);
        TransitionMaterial.SetFloat("_Cutoff", shininess);

        if (Input.GetKey(KeyCode.Space))
        {

            time += Time.deltaTime / 0.5f;
            done = false;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            done = true;
        }

        if (done)
        {
            time = Mathf.Lerp(time, 0, Time.deltaTime / 1.2f);
        }

        if (time < 0.05f && done == true)
        {
            time = 0;
        }




    }



    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        if (TransitionMaterial != null)
            Graphics.Blit(src, dst, TransitionMaterial);
    }
}
