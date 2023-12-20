using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public GameObject guyGameObject;
    public GameObject instantiateObjectHere;
    private GameObject newInstance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(newInstance);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            CreatePrefab();
        }

    }

    public void CreatePrefab()
    {
        float instX = instantiateObjectHere.transform.position.x;
        float instY = instantiateObjectHere.transform.position.y;
        newInstance = Instantiate(guyGameObject, new Vector3(instX, instY, 0), Quaternion.identity);
    }

    public void DestroyPrefab()
    {
        Destroy(newInstance);
    }

}
