using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    Camera camera;

    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Mouse X");

        Debug.Log(x);

        Quaternion yaw = Quaternion.AngleAxis(x * sensitivity, Vector3.up);

        transform.rotation = yaw * transform.rotation;
    }
}
