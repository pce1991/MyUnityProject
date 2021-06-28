using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = Quaternion.AngleAxis(Time.time * 10, Vector3.up);

        Vector3 newX = q * Vector3.right;
        Vector3 newY = q * Vector3.up;
        Vector3 newZ = q * Vector3.forward;


        Debug.DrawRay(transform.position, newX, Color.red);
        Debug.DrawRay(transform.position, newY, Color.green);
        Debug.DrawRay(transform.position, newZ, Color.blue);


    }
}
