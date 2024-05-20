
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Referencia al enemigo blanco (el que se convierte en enemigo al tocarlo)
    public GameObject enemigoBlancoPrefab;

    // Referencia al enemigo negro (el que contagia al enemigo blanco)
    public GameObject enemigoNegroPrefab;

    // Variable para controlar si el enemigo ya se ha convertido
    private bool seHaConvertido = false;

    // Método para manejar la colisión entre el enemigo negro y el enemigo blanco
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == enemigoBlancoPrefab && !seHaConvertido)
        {
            // Desactiva el enemigo blanco
            enemigoBlancoPrefab.SetActive(false);

            // Crea un nuevo enemigo negro en la misma posición
            Instantiate(enemigoNegroPrefab, transform.position, Quaternion.identity);

            // Marca que el enemigo ya se ha convertido
            seHaConvertido = true;
        }
    }
}
