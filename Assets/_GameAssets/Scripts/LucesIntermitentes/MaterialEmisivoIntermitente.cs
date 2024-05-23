using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialEmisivoIntermitente : MonoBehaviour
{
    Material material;

    public float secondsBetweenTwinkle;
    public float duration;
    public Color twinkleColor;
    [Range(0,100)]
    public float probability;
    private Color color;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        color = material.GetColor("_EmissionColor");
        InvokeRepeating("Tkinkle", secondsBetweenTwinkle, secondsBetweenTwinkle);
    }

    void Tkinkle()
    {
        if (Random.Range(0,100)<=probability)
        {
            material.SetColor("_EmissionColor", twinkleColor);
            Invoke("Restore", duration);
        }
    }
    void Restore()
    {
        material.SetColor("_EmissionColor", color);
    }
}
