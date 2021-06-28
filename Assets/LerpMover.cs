using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMover : MonoBehaviour
{
    CharacterController controller;
    public float maxSpeed;
    
    float moveStartTime;

    float prevY;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(0, 0, y);

        if (dir.magnitude >= 0.0f)
        {
            if (prevY == 0.0)
            {
                moveStartTime = Time.time;
            }
        }

        float timeSinceMoveStart = Time.time - moveStartTime;
        float t = timeSinceMoveStart / 0.25f;

        float speed = Mathf.Lerp(0.0f, maxSpeed, t);

        Debug.Log(speed);

        controller.Move(dir * speed * Time.deltaTime);

        prevY = y;
    }
}
