using UnityEngine;

public class RecogerMana : MonoBehaviour
{
    public int cantidadDeMana = 20; // Cantidad de mana que se añade al recoger el objeto
    private GameManager gameManager; // Referencia al GameManager

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Obtener referencia al GameManager
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aumentar mana y destruir objeto
            gameManager.GainMana(cantidadDeMana);
            Destroy(gameObject); // O desactiva el objeto si prefieres reutilizarlo
        }
    }
}
