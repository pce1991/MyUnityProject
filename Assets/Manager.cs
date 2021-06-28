using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool gameOver;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (player)
            {
                player.SetActive(false);
            }

            Debug.Log("GAME OVER");
        }
    }
}
