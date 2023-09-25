using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escribir_objetos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objetos = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objetos)
        {
            Debug.Log("Object Name: " + obj.name);
        }
    }
}
