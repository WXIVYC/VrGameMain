using UnityEngine;

public class UsarMana : MonoBehaviour
{
    private GameManager gameManager; // Referencia al GameManager
    public GameObject sphereFirePrefab;
    public Transform puntoDeDisparo;
    public int costoDeMana = 10;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Obtener referencia al GameManager
    }

    public void LanzarBolaDeFuego()
    {
        print("PASO 1");
        if (gameManager.GetCurrentMana() >= costoDeMana)
        {
            print("PASO 2");
            gameManager.UseMana(costoDeMana);
            Instantiate(sphereFirePrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);
        }
        else
        {
            print("PASO 3");
            Debug.Log("No hay suficiente mana para lanzar SphereFire");
        }
        print("PASO 4");
    }
}
