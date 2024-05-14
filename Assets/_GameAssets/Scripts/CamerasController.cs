using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public List<GameObject> camaras;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            desactivarCamaras();
            camaras[0].SetActive(true);
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2)){
            desactivarCamaras();
            camaras[1].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)){
            desactivarCamaras();
            camaras[2].SetActive(true);
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha4)){
            desactivarCamaras();
            camaras[3].SetActive(true);
        }    
    }
    void desactivarCamaras(){
        foreach(GameObject camara in camaras){
            camara.SetActive(false);
        }
    }
}
