//Source: https://www.binpress.com/creating-octahedron-sphere-unity/

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class OctahedronSphereTester : MonoBehaviour
{
    [Range(0, 6)]
    public int subdivisions = 0;
    private int lastSubdivisions = 0;

    public float frequency = 0.0f;
    private float lastfrequency = 0.2f;

    public float radius = 1f;
    private float lastRadius = 1f;

    public Material m_TestMaterial;

    [Range(-30, 30)]
    public float rotationSpeed = 1f;

    private Mesh mesh;

    public Gradient gradient;

    private void Awake()
    {
        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(subdivisions, radius, frequency, gradient);
        //GetComponent<Renderer>().material = m_TestMaterial;
    }

    void Update()
    {
        if(lastfrequency != frequency || lastSubdivisions != subdivisions || lastRadius != radius)
        {
            lastfrequency = frequency;
            lastSubdivisions = subdivisions;
            lastRadius = radius;
            mesh = OctahedronSphereCreator.Create(subdivisions, radius, frequency, gradient);
            GetComponent<MeshFilter>().mesh = mesh;
        }
        transform.Rotate(Vector3.up * 0.1f * rotationSpeed);
    }

    public void changeSubdivisions(float newSubdivision)
    {
        subdivisions = (int)newSubdivision;
    }
}