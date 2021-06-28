using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycast : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider c = cube.GetComponent<Collider>();

        Ray ray = new Ray();
        ray.origin = new Vector3(5, 0, 0);
        ray.direction = new Vector3(-1, 0, 0);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        // Raycasts against a specific collider.
        RaycastHit info;
        if (c.Raycast(ray, out info, 100))
        {
            if (info.transform.gameObject == cube)
            {
                sphere.SetActive(!sphere.activeSelf);
            }
        }

        // Gives you the first thing the ray hit.
        if (Physics.Raycast(ray, out info))
        {
            Debug.Log("Physics raycast hit " + info.transform.gameObject.name); ;
        }

        // Gives you all the things the ray hit. 
        RaycastHit[] allHits = Physics.RaycastAll(ray);
        if (allHits.Length > 0)
        {
            Debug.Log("Physics raycast hit " + allHits.Length + " things");

            for (int i = 0; i < allHits.Length; i++)
            {
                Debug.Log(allHits[i].transform.gameObject.name);
            }
        }
    }
}
