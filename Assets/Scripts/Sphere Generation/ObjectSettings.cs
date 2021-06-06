using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectSettings
{
    [Range(0, 6)]
    public int subdivisions = 0;
    public float radius = 1f;
}
