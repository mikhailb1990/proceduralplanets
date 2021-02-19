using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    [Range(1, 8)]
    public int numLayers = 1;
    public float persistence = 0.5f;
    public float strength = 1f;
    public float baseRoughness = 1f;
    public float roughness = 2f;
    public Vector3 center;
    public float minValue;
}
