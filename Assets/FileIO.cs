using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileIO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string path = "Assets/TextFiles/test.txt";

        if (Input.GetButton("Fire1"))
        {
            StreamWriter writer = new StreamWriter(path);

            writer.WriteLine(1123);

            writer.Close();
        }

        if (Input.GetButton("Fire2"))
        {
            StreamReader reader = new StreamReader(path);

            Debug.Log(reader.ReadLine());

            reader.Close();
        }
    }
}
