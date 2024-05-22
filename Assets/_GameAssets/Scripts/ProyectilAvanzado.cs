using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilAvanzado : MonoBehaviour
{
    public GameObject efectoImpactoConAudio;
    public int pupa; // Daño que causa el proyectil
    public bool autodestruccion;
    public string tagEnemigo;

    void OnCollisionEnter(Collision collision)
    {
        // Crear el efecto de impacto si está asignado
        if (efectoImpactoConAudio)
        {
            Instantiate(efectoImpactoConAudio, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogWarning("El arma no tiene asociado un prefab de explosión (o similar)");
        }

        // Verificar si el objeto colisionado es un enemigo
        if (collision.gameObject.CompareTag(tagEnemigo))
        {
            EnemigoHealthManager enemigoHealth = collision.gameObject.GetComponent<EnemigoHealthManager>();
            if (enemigoHealth != null)
            {
                enemigoHealth.HacerPupa(pupa);
            }
            else
            {
                Debug.LogWarning("El enemigo no tiene el componente EnemigoHealthManager");
            }
        }

        // Destruir el proyectil si la autodestrucción está habilitada
        if (autodestruccion)
        {
            Destroy(gameObject);
        }
    }
}
