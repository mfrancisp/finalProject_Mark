using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.tag = "Hit";

        }

        if (other.gameObject.tag == "Player")
        {

            RestartLevel();

        }

    }

    void RestartLevel() // Restarts the level the player is currently on.
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
