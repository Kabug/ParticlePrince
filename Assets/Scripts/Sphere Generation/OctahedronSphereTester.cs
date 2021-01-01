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

    private void Awake()
    {
        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(subdivisions, radius, seed);
        GetComponent<Renderer>().material = m_TestMaterial;
    }

    void Update()
    {
        if(lastSeed != seed || lastSubdivisions != subdivisions || lastRadius != radius)
        {
            lastSeed = seed;
            lastSubdivisions = subdivisions;
            lastRadius = radius;
            mesh = OctahedronSphereCreator.Create(subdivisions, radius, seed);
            GetComponent<MeshFilter>().mesh = mesh;
        }
        //transfrom.rotate (0, rotationSpeed * Time.deltaTime, 0);
    }

    public void changeSubdivisions(float newSubdivision)
    {
        subdivisions = (int)newSubdivision;
    }
}