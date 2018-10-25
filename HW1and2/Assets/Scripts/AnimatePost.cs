using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class AnimatePost : MonoBehaviour
{
    PostProcessVolume volume;
    ColorGrading colorGrade;

    public float duration = 2.0f;

    float startValue;
    public float endValue;
    float t = 0;

    // Use this for initialization
    void Start()
    {
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGrade);
        startValue = colorGrade.saturation.value;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / (duration);
        colorGrade.saturation.value = Mathf.Lerp(startValue, endValue, t);
        Debug.Log(colorGrade.saturation.value);
    }
}
