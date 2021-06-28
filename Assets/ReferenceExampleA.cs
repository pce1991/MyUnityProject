using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceExampleA : MonoBehaviour
{

    public GameObject go; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We want to get Foo on B and print it.
        ReferenceExampleB b = go.GetComponent<ReferenceExampleB>();

        Debug.Log(b.foo);
    }
}
