using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
    Light light;

    public float duration;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsed = Time.time - startTime;
        float t = elapsed / duration;

        light.intensity = Mathf.Lerp(0, 10, t);
    }
}
