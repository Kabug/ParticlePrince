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

    public NoiseSettings noiseSettings;
    private SimpleNoiseFilter noiseFilter;

    private string lastNoiseSettings;

    private void Awake()
    {
        noiseFilter = new SimpleNoiseFilter(noiseSettings);
        lastNoiseSettings = JsonUtility.ToJson(noiseSettings);
        lastObjectSettings = JsonUtility.ToJson(objectSettings);

        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(objectSettings, noiseSettings, noiseFilter);
        GetComponent<Renderer>().material = m_TerrainMaterial;
        texture = new Texture2D(textureResolution, 1);
        updateColours();
        m_TerrainMaterial.SetVector("_elevationMinMax", new Vector4(objectSettings.radius, objectSettings.radius + 1.12f));
    }

    void Update()
    {
        if (lastObjectSettings != JsonUtility.ToJson(objectSettings) || lastNoiseSettings != JsonUtility.ToJson(noiseSettings))
        {
            lastNoiseSettings = JsonUtility.ToJson(noiseSettings);
            lastObjectSettings = JsonUtility.ToJson(objectSettings);

            mesh = OctahedronSphereCreator.Create(objectSettings, noiseSettings, noiseFilter);
            GetComponent<MeshFilter>().mesh = mesh;
            Vector3[] vertices = mesh.vertices;
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