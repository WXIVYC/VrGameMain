using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoAleatorio : MonoBehaviour
{
    [SerializeField] private float velocidad = 1.0f; // Velocidad de movimiento
    [SerializeField] private float minY = -21f; // Límite inferior en el eje Y
    [SerializeField] private float maxY = -19f; // Límite superior en el eje Y

    private Vector3 objetivo; // Posición objetivo aleatoria

    private void Start()
    {
        // Establecer una posición inicial aleatoria
        objetivo = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
    }

    private void Update()
    {
        // Mover gradualmente hacia la posición objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);

        // Si se alcanza la posición objetivo, generar una nueva posición aleatoria
        if (transform.position == objetivo)
        {
            objetivo = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
        }
    }
}
