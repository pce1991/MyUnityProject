using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{

    public float duration;
    public Vector3 endPosition;
    Vector3 startPosition;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Lerp: linearly interpolates between two points
        // A & B, by a factor t (on the range 0 to 1).

        float timeElapsed = Time.time - startTime;
        float t = timeElapsed / duration;

        // Lerp will clamp the value of t between 0 and 1
        transform.position = Vector3.Lerp(startPosition, endPosition, t);

        // BAD EXAMPLE
        // Problem with this is that we're linearly moving between start and end by a position,
        // but our start point keeps moving, but our percentage is not relative to that moving position.
        // So in the end this isnt actually linear motion
        //transform.position = Vector3.Lerp(transform.position, endPosition, t);

        // Another bad bad bad example
        // Problem here is that we never actually arrive at our endPosition.
        // This is also not linear for the reasons stated above. 
        //transform.position = Vector3.Lerp(transform.position, endPosition, 0.1);

    }

}
