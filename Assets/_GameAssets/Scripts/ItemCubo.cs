using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemCubo : MonoBehaviour
{
    // Referencia al prefab del enemigo
    public GameObject enemigoPrefab;

    // Método para manejar la colisión con el enemigo
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            Destroy(transform.parent.gameObject);

            // Crea un nuevo enemigo usando el prefab en la misma posición
            Instantiate(enemigoPrefab, transform.position, transform.rotation);
        }
    }

    
}
