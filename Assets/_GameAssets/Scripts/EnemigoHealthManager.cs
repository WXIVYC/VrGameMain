using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class EnemigoHealthManager : MonoBehaviour
{
    [Header("Objeto que se va a instanciar cuando el enemigo 'muera'")]
    public GameObject prefabObjetoReemplazo;
    public int salud = 100;
    public int expAmount = 100; // Cantidad de experiencia al matar al enemigo
    private Slider sliderSalud;

    void Start()
    {
        sliderSalud = GetComponentInChildren<Slider>();
    }

    public void HacerPupa(int pupa)
    {
        salud -= pupa;
        sliderSalud.value = salud;
        if (salud <= 0)
        {
            // Agregar experiencia al jugador
            ExperienceManager.Instance.AddExperience(expAmount);

            // Instanciar el objeto de reemplazo
            Instantiate(prefabObjetoReemplazo, transform.position, transform.rotation);

            // Destruir el enemigo
            Destroy(gameObject);
        }
    }
}
