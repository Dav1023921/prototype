using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove_Script : MonoBehaviour
{
    public GameObject textObject;

    void Start()
    {
        textObject.SetActive(false);

    }

    void OnMouseDown() 
    {

        textObject.SetActive(true); 

    }

}