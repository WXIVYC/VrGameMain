using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaManager : MonoBehaviour
{
    public GameObject linterna;
   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)){
            linterna.SetActive(!linterna.activeSelf);
        }     
    }
}
