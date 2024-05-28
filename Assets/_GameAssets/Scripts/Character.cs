using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField]
    int currentHealth, maxHealth,
        currentExperience, maxExperience,
        currentLevel;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnEnable()
    {
        ExperienceManager.Instance.OnExperienceChange += HandleExperienceChange;
    }

    private void OnDisable()
    {
        ExperienceManager.Instance.OnExperienceChange -= HandleExperienceChange;
    }

    private void HandleExperienceChange(int newExperience)
    {
        currentExperience += newExperience;
        if (currentExperience >= maxExperience)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        maxHealth += 10;
        currentHealth = maxHealth;
        currentLevel++;
        currentExperience = 0;
        maxExperience += 100;

        // Actualizar el texto del nivel en el GameManager
        if (gameManager != null)
        {
            gameManager.ActualizarNivel(currentLevel);
        }
    }
}
