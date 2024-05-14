using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDanyoProgresivo : MonoBehaviour
{
    [Header("Daño infringido en cada lapso de tiempo")]
    public int danyo;
    [Header("Tiempo transcurrido entre cada incremento/decremento daño")]
    public float frecuencia;

    private Transform transformMainCamera;
    public void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("MainCamera")) 
        {
            transformMainCamera=c.gameObject.transform;
            InvokeRepeating("HacerDanyo",0,frecuencia);
        }  
    }
    public void OnTriggerExit(Collider c){
        if (c.gameObject.CompareTag("MainCamera")) 
        {
            CancelInvoke("HacerDanyo");
        }
    }
    private void HacerDanyo(){
        transformMainCamera.gameObject.GetComponent<PlayerHealthManager>()?.RecibirPupa(danyo);
    }
}
