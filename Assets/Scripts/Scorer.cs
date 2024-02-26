using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
        hits++;
        Debug.Log("Bumped into things: " + hits);
        }
    }
}
