using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagFollower : MonoBehaviour
{
    // We could set this to a reference to a manager component 
    public GameObject managerObj;

    public GameObject player;
    public float speed;

    CharacterController controller;

    // Note that this point is local to the player's position
    Vector3 pointAroundPlayer;
    float distanceThrehold;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        distanceThrehold = 8.0f;

        // NOTE: this isnt the most robust way to pick a point. 
        Vector3 offset = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        // Maybe more interesting to have an array of authored points which we pick, because it's possible now
        // that two guys go to the same point, or worse that we generate an offset of (0, 0)

        Vector3.Normalize(offset);
        pointAroundPlayer = offset * distanceThrehold;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = player.transform.position - transform.position;
        Vector3 dir = diff.normalized; // This normalized value does not mutate the original vector.

        if (diff.magnitude > distanceThrehold)
        {
            Vector3 target = player.transform.position + pointAroundPlayer;
            dir = (target - transform.position).normalized;
        }

        controller.Move(dir * speed * Time.deltaTime);

        //Debug.Log(diff.magnitude);

        if (diff.magnitude < 1.1f)
        {
            Manager manager = managerObj.GetComponent<Manager>();
            manager.gameOver = true;
        }
    }
}
