//Source: https://www.binpress.com/creating-octahedron-sphere-unity/

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class OctahedronSphereTester : MonoBehaviour
{
    [Range(0, 6)]
    public int subdivisions = 0;
    private int lastSubdivisions = 0;

    public float seed = 0.0f;
    private float lastSeed = 0.2f;

    public float radius = 1f;
    private float lastRadius = 1f;

    public Material m_TestMaterial;

    public float rotationSpeed = 15f;

    private Mesh mesh;

    public Gradient gradient;
    Texture2D texture;
    const int textureResolution = 50;

    public float strength = 1;
    private float lastStrength = 1;
    public float roughness = 1;
    private float lastRoughness = 1;
    public Vector3 center;
    private Vector3 lastCenter;
    [Range(1,8)]
    public float numLayers = 1;
    private float lastNumLayers = 1;
    public float persistence = 0.5f;
    private float lastPersistence = 0.5f;
    public float baseRoughness = 2;
    private float lastBaseRoughness = 2;
    public float minValue;
    private float lastMinValue;

    private void Awake()
    {
        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(subdivisions, radius, strength, roughness, center, numLayers, persistence, baseRoughness, minValue);
        GetComponent<Renderer>().material = m_TestMaterial;
        texture = new Texture2D(textureResolution, 1);
        m_TestMaterial.SetVector("_elevationMinMax", new Vector4(radius, radius + 1.12f));
    }

    void Update()
    {
        if(lastSubdivisions != subdivisions || lastRadius != radius || lastStrength != strength || lastRadius != roughness || lastCenter != center || lastNumLayers != numLayers || lastPersistence != persistence || lastBaseRoughness != baseRoughness || minValue != lastMinValue)
        {
            lastSubdivisions = subdivisions;
            lastRadius = radius;
            lastStrength = strength;
            lastRoughness = roughness;
            lastCenter = center;
            lastNumLayers = numLayers;
            lastPersistence = persistence;
            lastBaseRoughness = baseRoughness;
            lastMinValue = minValue;

            mesh = OctahedronSphereCreator.Create(subdivisions, radius, strength, roughness, center, numLayers, persistence, baseRoughness, minValue);
            GetComponent<MeshFilter>().mesh = mesh;
            Vector3[] vertices = mesh.vertices;
            //Debug.Log(Vector3.Distance(transform.position, vertices[0]));
            updateColours();
            m_TestMaterial.SetVector("_elevationMinMax", new Vector4(radius, radius + (0.9f * radius / (radius + radius))));
        }
        transform.Rotate(Vector3.up * 0.1f * rotationSpeed);
    }

    public void changeSubdivisions(float newSubdivision)
    {
        subdivisions = (int)newSubdivision;
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
        m_TestMaterial.SetTexture("_texture", texture);
    }
}