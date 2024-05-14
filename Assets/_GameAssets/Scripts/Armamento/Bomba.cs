using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    [Header("Radio de acción de la explosión en metros")]
    public float radio;
    public float fuerzaHorizontal;
    public float fuerzaVertical;
    
    [Header("Segundos de espera antes de la explosión")]
    public int temporizador;

    void Start()
    {
        Invoke("Explotar", temporizador);
    }

    void Explotar(){
        //Obtiene los colliders afectados por la explosión
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radio);
        //Recorre los colliders y a aquellos que tienen RigidBody les aplica una explosión de fuerza
        foreach(var collider in hitColliders){
            if (collider.GetComponent<Rigidbody>()!=null){
                collider.GetComponent<Rigidbody>().AddExplosionForce(
                    fuerzaHorizontal, 
                    transform.position, 
                    radio, 
                    fuerzaVertical);
            }
        }
    }
}
