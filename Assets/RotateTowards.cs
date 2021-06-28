using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Notice this doesnt give you back a value it just changes your transform. 
        //transform.LookAt(target.transform);

        // atan2
        //Vector3 diff = target.transform.position - transform.position;
        //Vector3 dir = diff.normalized;

        //float angle = Mathf.Atan2(dir.x, dir.z);

        //transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.up);


        // dot product / Vector3.Angle method
        Vector3 diff = target.transform.position - transform.position;
        Vector3 dir = diff.normalized;

        float angle = Vector3.Angle(dir, Vector3.forward);

        Debug.DrawRay(transform.position, dir, Color.blue);
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        Debug.Log(angle);

        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);

        //angle = Vector3.Angle(transform.forward, dir);

        //transform.rotation = transform.rotation * Quaternion.AngleAxis(angle, Vector3.up);

        // This is using the dot product to determine which side of the plane our "to" vector is on.
        angle = Vector3.SignedAngle(transform.forward, dir, Vector3.up);

        transform.rotation = transform.rotation * Quaternion.AngleAxis(angle, Vector3.up);


        // Quaternion.LookAt
    }
}
