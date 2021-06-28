using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Get a reference to the GameObject so I can access its members.
    public GameObject cube;
    Mover mover;
    // This is a reference to a component

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponent is a method on a GameObject that we can use to get a reference to
        // a component of a particular type. 
        mover = cube.GetComponent<Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        // find the position of the cube
        // set my position to the cube position + an offset

        // Debug.Log prints strings into the Log panel in Unity
        Debug.Log(cube.transform.position);

        transform.position = cube.transform.position + offset;

        // Let's say we want to get the speed of the cube
        // so that we can follow in it's direction by that speed.
        Debug.Log("mover speed is " + mover.speed);
    }
}
