using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    public enum FilterType { Simple, Rigid };
    public FilterType filterType;

    public float strength = 0.1f;
    public float roughness = 1.9f;
    public Vector3 center;
    [Range(1, 8)]
    public float numLayers = 5;
    public float persistence = 0.5f;
    public float baseRoughness = 0.6f;
    public float minValue = 1;
}
