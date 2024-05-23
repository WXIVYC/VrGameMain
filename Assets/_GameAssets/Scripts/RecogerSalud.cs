using UnityEngine;

public class RecogerSalud : MonoBehaviour
{
    public int cantidadDeSalud = 20; // Cantidad de salud que se añade al recoger el objeto
    private GameManager gameManager; // Referencia al GameManager

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Obtener referencia al GameManager
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aumentar salud y destruir objeto
            gameManager.IncrementarSalud(cantidadDeSalud);
            Destroy(gameObject); // O desactiva el objeto si prefieres reutilizarlo
        }
    }
}
