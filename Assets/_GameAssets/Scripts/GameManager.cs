using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float salud;
    public int saludMaxima;
    public int puntuacion = 0;
    public int puntuacionMaxima = 0;
    public int maxMana = 100;
    public  int currentMana;

    public Image manaBar; // Referencia a la barra de mana en la interfaz gráfica
    public Image imageVida;
    public TextMeshProUGUI textoPuntuacion;
    public TextMeshProUGUI textoPuntuacionMaxima;

    public List<GameObject> objetosAActivarCuandoGameOver;

    private static string KEY_HIGHSCORE = "HIGHSCORE";

    private void Awake()
    {
        InicializarPuntuacion();
        ActualizarBarraDeSalud();
        InicializarMana();
    }

    private void Update()
    {
        if (salud == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            ReiniciarJuego();
        }
    }

    private void InicializarMana()
    {
        currentMana = maxMana;
        ActualizarBarraDeMana();
    }

    public void UseMana(int amount)
    {
        print("USANDO MANA:" + amount);
        currentMana -= amount;
        if (currentMana < 0) currentMana = 0;
        ActualizarBarraDeMana();
    }

    public void GainMana(int amount)
    {
        currentMana += amount;
        if (currentMana > maxMana)
        {
            currentMana = maxMana;
        }
        ActualizarBarraDeMana();
    }

    private void ActualizarBarraDeMana()
    {
        if (manaBar != null)
        {
            float fillAmount = (float)currentMana / maxMana;
            manaBar.fillAmount = fillAmount;
        } 
    }

    public int GetCurrentMana()
    {
        return currentMana;
    }

    public int GetMaxMana()
    {
        return maxMana;
    }

    private void InicializarPuntuacion()
    {
        puntuacion = 0;
        if (PlayerPrefs.HasKey(KEY_HIGHSCORE))
        {
            puntuacionMaxima = PlayerPrefs.GetInt(KEY_HIGHSCORE);
        }
        else
        {
            puntuacionMaxima = 0;
        }
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = puntuacion.ToString();
        }
        if (textoPuntuacionMaxima != null)
        {
            textoPuntuacionMaxima.text = puntuacionMaxima.ToString();
        }
    }

    private void ActualizarBarraDeSalud()
    {
        if (imageVida != null)
        {
            imageVida.fillAmount = salud / saludMaxima;
        }
    }

    public void Puntuar(int puntuacion)
    {
        this.puntuacion += puntuacion;
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = this.puntuacion.ToString();
        }
    }

    public void DecrementarSalud(int decrementoSalud)
    {
        salud -= decrementoSalud;
        if (salud <= 0)
        {
            salud = 0;
            TerminarJuego();
        }
        ActualizarBarraDeSalud();
    }

    public void IncrementarSalud(int incrementoSalud)
    {
        salud += incrementoSalud;
        if (salud > saludMaxima)
        {
            salud = saludMaxima;
        }
        ActualizarBarraDeSalud();
    }

    public void TerminarJuego()
    {
        foreach (GameObject objeto in objetosAActivarCuandoGameOver)
        {
            objeto.SetActive(true);
        }
        if (puntuacion > puntuacionMaxima)
        {
            PlayerPrefs.SetInt(KEY_HIGHSCORE, puntuacion);
            PlayerPrefs.Save();
        }
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
