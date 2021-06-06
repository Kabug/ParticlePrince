using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourGenerator : MonoBehaviour
{
    OctahedronSphereTester settings;

    public void updateElevation()
    {
        settings.m_TerrainMaterial.SetVector("elevationMinMax", new Vector4(1, 1.12f));
    }
}
