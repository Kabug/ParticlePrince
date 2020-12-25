//Source: https://www.binpress.com/creating-octahedron-sphere-unity/

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class OctahedronSphereTester : MonoBehaviour
{
    [Range(0, 6)]
    public int subdivisions = 0;
    private int lastSubdivisions = 0;

    public float radius = 1f;

    public Material m_TestMaterial;

    private void Awake()
    {
        GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(subdivisions, radius);
        GetComponent<Renderer>().material = m_TestMaterial;
    }

    void Update()
    {
        if(lastSubdivisions != subdivisions)
        {
            lastSubdivisions = subdivisions;
            GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(subdivisions, radius);
        }
    }

    public void changeSubdivisions(float newSubdivision)
    {
        subdivisions = (int)newSubdivision;
    }
}