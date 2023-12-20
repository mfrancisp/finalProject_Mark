using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylMovement : MonoBehaviour
{

    float moveSpeedOne;
    float moveSpeedTwo;
    // Float variables make t so I can adjust the speed of the cylinders
    bool isitSo;
    // If the cylinders are placed at a different posistion

    // Start is called before the first frame update
    void Start()
    {

        moveSpeedOne = 700f;
        moveSpeedTwo = 700f;
        // I set the base speeds to 700
        isitSo = true;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, moveSpeedOne * Time.deltaTime); // I rotate the cylinders constantly

        if (transform.position.z >= 6f)
        {

            moveSpeedOne = 0f;
            isitSo = false;
            moveSpeedTwo = -7f;

        }

        if (transform.position.z <= -8.45f)
        {
            moveSpeedTwo = 0f;
            isitSo = true;
            moveSpeedOne = 7f;

        }


        if (isitSo == true)
        {

            transform.Rotate(0, 0, moveSpeedOne * Time.deltaTime);

        }

        if (isitSo == false)
        {

            transform.Rotate(0, 0, moveSpeedTwo * Time.deltaTime);

        }

    }
}