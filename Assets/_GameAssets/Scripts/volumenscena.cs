using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumenscena : MonoBehaviour
{
    private AudioSource audioSource;
    private float volumenInicial = 0.5f; // Volumen inicial (puedes ajustarlo)
    private float incrementoVolumen = 0.1f; // Incremento/decremento de volumen

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = volumenInicial;
    }

    private void Update()
    {
        // Activa o desactiva el sonido al presionar 'V'
        if (Input.GetKeyDown(KeyCode.V))
        {
            ToggleVolumen();
        }

        // Aumenta o disminuye el volumen al presionar los botones '+' o '-'
        if (Input.GetKeyDown(KeyCode.Equals) || Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            AumentarVolumen(incrementoVolumen);
        }
        else if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            DisminuirVolumen(incrementoVolumen);
        }
    }

    private void ToggleVolumen()
    {
        AudioListener.pause = !AudioListener.pause; // Alterna entre activado y desactivado
    }

    private void AumentarVolumen(float incremento)
    {
        audioSource.volume = Mathf.Clamp01(audioSource.volume + incremento);
    }

    private void DisminuirVolumen(float decremento)
    {
        audioSource.volume = Mathf.Clamp01(audioSource.volume - decremento);
    }
}