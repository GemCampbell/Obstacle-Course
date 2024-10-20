using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }



    void PrintInstructions()
    {
        print("Welcome to the game!");
        print("Move the player with the arrow keys");
        print("Don't bump into the walls!");
    }


    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }

}
