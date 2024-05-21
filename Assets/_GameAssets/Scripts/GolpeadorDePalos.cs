using UnityEngine;

public class GolpeadorDePalos : MonoBehaviour
{
    public int dano = 10; // Daño que inflige el palo

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Aplica el daño al enemigo
            if (collision.gameObject.GetComponent<EnemigoHealthManager>() != null)
            {
                collision.gameObject.GetComponent<EnemigoHealthManager>().HacerPupa(dano);
            }
            else
            {
                Debug.LogWarning("El enemigo no tiene el componente EnemigoHealthManager");
            }
        }
    }
}
