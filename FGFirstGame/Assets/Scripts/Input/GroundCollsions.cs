using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundCollsions : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return color;
    }
}
