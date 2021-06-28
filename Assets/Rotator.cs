using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public bool reverseMultiply;

    public float qAngle;
    public float q2Angle;
    public float q3Angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // This gives us the identity quaternion, which means it does not change the rotation at all.
        // Think of this as the "default" rotation, the way (0, 0, 0) is the default position.
        // Any quaternion multiplied by the identity quaternion will be unchanged (hence the term identity).
        Quaternion q = Quaternion.AngleAxis(0, Vector3.right);
        // Vector3.right is the global right direction

        q = Quaternion.AngleAxis(qAngle, Vector3.right);

        Quaternion q2 = Quaternion.AngleAxis(q2Angle, Vector3.up);

        Quaternion q3 = Quaternion.AngleAxis(q3Angle, Vector3.forward);

        if (reverseMultiply)
        {
            // q2 is applied first, then q
            q = q2 * q;
            //q = q3 * q2 * q;
            // q3 * (q2 * q) OR (q3 * q2) * q??
        }
        else
        {
            //q = q * q2 * q3;
            q = q * q2;
        }

        Debug.Log(q);

        // Few properties of transforms
        // The way these vectors are calculated is by taking transform.rotation * Vector3.direction
        Debug.Log("forward " + transform.forward);
        Debug.Log("right " + transform.right);
        Debug.Log("up " + transform.up);


        //eulerA(10, 5, 0)
        //eulerB(15, 10, 0)
        //eulerBQ * eulerAQ = rotate around B, and then A
        //eulerC = eulerA + eulerB = (25, 15, 0)
        // These are not the same rotations!

        // Lerp and Slerp
        // Show off a FPS camera

        transform.rotation = q;
    }
}
