using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFeedback : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You bumped into a thing this many times: " + hits);
        }
    }

}
