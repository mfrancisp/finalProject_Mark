using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidBuddy;
    [SerializeField] float timetoWait = 3.5f;

    // Start is called before the first frame update
    void Start()
    {

        renderer = GetComponent<MeshRenderer>();
        rigidBuddy = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBuddy.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timetoWait)
        {

            //Debug.Log("Three seconds has passed; drop object!");
            renderer.enabled = true;
            rigidBuddy.useGravity = true;

        }
    }
}
