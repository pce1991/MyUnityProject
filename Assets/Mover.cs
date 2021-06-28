using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This : MonoBehavior says that the class Mover "inherits" from the MonoBehaviour class
public class Mover : MonoBehaviour
{
    // @TODO: velocity for better controls
    // @TODO: ColliderFlags on ColliderHit

    public float speed;

    int health = 10;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 2, 0);

        // this is the verbose way to say it
        //controller = this.gameObject.GetComponent<CharacterController>();

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0.0f, 0.0f, 0.0f);
        
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        dir.x = horz;
        dir.z = vert;

        // Normalize does mutate the value we pass in.
        Vector3.Normalize(dir);

        //transform.position = transform.position + dir;
        //transform.Translate(dir * speed * Time.deltaTime);

        controller.Move(dir * speed * Time.deltaTime);

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        // Destroy(collider.transform.gameObject);
        Debug.Log("Hit trigger");
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Left trigger");
    }
    void OnTriggerStay(Collider collider)
    {
        Debug.Log("In trigger");
    }

    void OnCollisionEnter(Collision c)
    {
        health--;
        //Destroy(this.gameObject);
        Debug.Log("Collision Enter " + c.transform.gameObject.name);
    }
}
