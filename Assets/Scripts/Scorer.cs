using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        
        print("You've bumped into something: " + hits + " times");
    }
}
