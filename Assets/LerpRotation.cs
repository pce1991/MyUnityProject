using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
    public float duration;
    float startTime;

    Quaternion startRotation; 

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        startRotation = transform.rotation; 
    }

    // Update is called once per frame
    void Update()
    {
        float elapsed = Time.time - startTime;
        float t = elapsed / duration;

        Quaternion endRotation = Quaternion.AngleAxis(90, Vector3.right);

        //transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);

        transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);

    }
}
