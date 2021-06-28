using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float rate; 

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // This is pretty much what the Rotate function looks like internally
    void Rotate(float x, float y, float z)
    {
        Quaternion x_ = Quaternion.AngleAxis(x, transform.right);
        Quaternion y_ = Quaternion.AngleAxis(y, transform.up);
        Quaternion z_ = Quaternion.AngleAxis(z, transform.forward);

        transform.rotation = transform.rotation * x_ * y_ * z_;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = Quaternion.AngleAxis(rate * Time.deltaTime, Vector3.up);
        Quaternion q2 = Quaternion.AngleAxis(rate * Time.deltaTime, Vector3.right);


        transform.rotation = transform.rotation * q * q2;

        // using angnle axis version of Rotate
        //tranform.Rotate(Vector3.up, rate * Time.deltaTime);
        //tranform.Rotate(Vector3.right, rate * Time.deltaTime);
    }
}
