using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    float moveSpeedOne;
    float moveSpeedTwo;

    // Start is called before the first frame update
    void Start()
    {

        moveSpeedOne = 7f;
        moveSpeedTwo = 7f;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, moveSpeedOne * Time.deltaTime);

    }
}
