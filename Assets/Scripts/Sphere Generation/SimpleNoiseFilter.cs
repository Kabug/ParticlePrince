using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleNoiseFilter
{
    NoiseSettings settings;
    Noise noise = new Noise();

    public SimpleNoiseFilter(NoiseSettings settings)
    {
        this.settings = settings;
    }

    public float Evaluate(Vector3 point)
    {
        float noiseValue = 0;
        float frequency = settings.baseRoughness;
        float amplitude = 1;

        for (int l = 0; l < settings.numLayers; l++)
        {
            float v = noise.Evaluate(point * frequency + settings.center);
            noiseValue += (v + 1) * 0.5f * amplitude;
            frequency *= settings.roughness;
            amplitude *= settings.persistence;
        }
        noiseValue = Mathf.Max(0, noiseValue - settings.minValue);
        noiseValue *= settings.strength;

        return noiseValue;
    }
}
