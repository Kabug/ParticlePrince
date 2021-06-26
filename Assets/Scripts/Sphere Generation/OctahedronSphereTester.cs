//Source: https://www.binpress.com/creating-octahedron-sphere-unity/

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class OctahedronSphereTester : MonoBehaviour
{
    public ObjectSettings objectSettings;
    private string lastObjectSettings;

    public Material m_TerrainMaterial;

    public float rotationSpeed = 5f;

    private Mesh mesh;

    public Gradient gradient;
    Texture2D texture;
    const int textureResolution = 50;

    private INoiseFilter[] noiseFilters;

    private void Awake()
    {
        noiseFilters = new SimpleNoiseFilter[objectSettings.noiseLayers.Length];
        for (int i = 0; i < noiseFilters.Length; i++)
        {
            noiseFilters[i] = new SimpleNoiseFilter(objectSettings.noiseLayers[i].noiseSettings);
        }

        lastObjectSettings = JsonUtility.ToJson(objectSettings);

        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(objectSettings, noiseFilters); ;
        GetComponent<Renderer>().material = m_TerrainMaterial;
        texture = new Texture2D(textureResolution, 1);
        updateColours();
        m_TerrainMaterial.SetVector("_elevationMinMax", new Vector4(objectSettings.radius, objectSettings.radius + (0.9f * objectSettings.radius / (objectSettings.radius + objectSettings.radius))));

        noiseFilters = new INoiseFilter[objectSettings.noiseLayers.Length];
        for (int i = 0; i < noiseFilters.Length; i++)
        {
            noiseFilters[i] = NoiseFilterFactory.CreateNoiseFilter(objectSettings.noiseLayers[i].noiseSettings);
        }
        lastObjectSettings = JsonUtility.ToJson(objectSettings);

        mesh = OctahedronSphereCreator.Create(objectSettings, noiseFilters);
        GetComponent<MeshFilter>().mesh = mesh;
        updateColours();
        m_TerrainMaterial.SetVector("_elevationMinMax", new Vector4(objectSettings.radius, objectSettings.radius + (0.9f * objectSettings.radius / (objectSettings.radius + objectSettings.radius))));
    }

    void Update()
    {
        if (lastObjectSettings != JsonUtility.ToJson(objectSettings))
        {
            noiseFilters = new INoiseFilter[objectSettings.noiseLayers.Length];
            for (int i = 0; i < noiseFilters.Length; i++)
            {
                noiseFilters[i] = NoiseFilterFactory.CreateNoiseFilter(objectSettings.noiseLayers[i].noiseSettings);
            }
            lastObjectSettings = JsonUtility.ToJson(objectSettings);

            mesh = OctahedronSphereCreator.Create(objectSettings, noiseFilters);
            GetComponent<MeshFilter>().mesh = mesh;
            updateColours();
            m_TerrainMaterial.SetVector("_elevationMinMax", new Vector4(objectSettings.radius, objectSettings.radius + (0.9f * objectSettings.radius / (objectSettings.radius + objectSettings.radius))));
        }
        transform.Rotate(Vector3.up * 0.1f * rotationSpeed);
    }

    public void changeSubdivisions(float newSubdivision)
    {
        objectSettings.subdivisions = (int)newSubdivision;
    }

    public void updateColours()
    {
        Color[] colours = new Color[textureResolution];
        for(int i = 0; i<textureResolution; i++)
        {
            colours[i] = gradient.Evaluate(i / (textureResolution - 1f));
        }

        texture.SetPixels(colours);
        texture.Apply();
        m_TerrainMaterial.SetTexture("_texture", texture);
    }
}