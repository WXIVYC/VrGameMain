using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI; // O using TMPro; si estás usando TextMeshPro

public class LevelDisplay : MonoBehaviour
{
    public Text levelText; // O TextMeshProUGUI si usas TextMeshPro

    private void OnEnable()
    {
        ExperienceManager.Instance.OnExperienceChange += UpdateLevelText;
    }

    private void OnDisable()
    {
        ExperienceManager.Instance.OnExperienceChange -= UpdateLevelText;
    }

    public void UpdateLevelText(int level)
    {
        levelText.text = "Level: " + level.ToString();
    }
}
