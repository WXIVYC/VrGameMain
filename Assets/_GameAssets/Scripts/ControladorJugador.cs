using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public UsarMana usarMana; // Referencia al script UsarMana

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Asegúrate de tener configurado el botón Fire1 en Input settings
        {
            usarMana.LanzarBolaDeFuego();
        }
    }
}
