using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarInvetario : MonoBehaviour
{
    public GameObject inventarioUI; // Referencia al GameObject del inventario
    private bool inventarioActivo = false; // Estado inicial del inventario

    private void Start()
    {
        // Desactivar el inventario al inicio (opcional)
        inventarioUI.SetActive(inventarioActivo);
    }

    private void Update()
    {
        // Alternar el inventario al presionar la tecla "I"
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventarioActivo = !inventarioActivo;
            inventarioUI.SetActive(inventarioActivo);
        }
    }
}