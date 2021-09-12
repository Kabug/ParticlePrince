using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropAttractor : MonoBehaviour
{

    const float gravity = 5f;
    public Rigidbody rb;
    private float timeAlive = 0f;
    private float sedimentCap = 0.5f;
    public float sedimentRemoveChance = 50f;
    //private float sedimentDropRate = 50f;
    private float sedimentDissolution = 0.99f;
    private float sediment = 0f;
    private Vector3 newSediment;

    public float minImpulse = 2;
    public float malleability = 0.05f;
    public float radius = 0.1f;
    public GameObject planet;

    private Mesh m;
    private MeshCollider mc;
    private Vector3[] verts;
    OctahedronSphereTester planetScript;


    private void Start()
    {
        planet = FindObjectOfType<PlanetAttractor>().gameObject;
        m = planet.GetComponent<MeshFilter>().mesh;
        mc = planet.GetComponent<MeshCollider>();
        planetScript = planet.GetComponent<OctahedronSphereTester>();
    }

    void FixedUpdate()
    {
        PlanetAttractor attractor = FindObjectOfType<PlanetAttractor>();
        Vector3 planetPosition = attractor.gameObject.transform.position;
        float planetScale = attractor.gameObject.transform.localScale.x;
        if (CheckIfInOcean(planetPosition, planetScale) || this.GetComponent<Rigidbody>().velocity.magnitude < 0.01f && timeAlive > 1)
        {
            m = planet.GetComponent<MeshFilter>().mesh;
            mc = planet.GetComponent<MeshCollider>();

            Vector3 raindropPositon = transform.position;
            verts = m.vertices;
            int vertIndex = 0;
            float shortestDistance = float.MaxValue;

            for (int i = 0; i < verts.Length; i++)
            {
                float distance = Mathf.Sqrt(Mathf.Pow(verts[i].x - raindropPositon.x, 2) +
                    Mathf.Pow(verts[i].y - raindropPositon.y, 2) + Mathf.Pow(verts[i].z - raindropPositon.z, 2));

                if (shortestDistance > distance)
                {
                    shortestDistance = distance;
                    vertIndex = i;
                }

            }

            //Debug.Log(verts[vertIndex]);
            Vector3 newVert = verts[vertIndex] + newSediment;
            //Debug.Log(newVert);
            //Debug.Log(sediment);
            //Debug.Log("--------------");
            //Debug.Break();

            verts[vertIndex] = newVert;

            m.vertices = verts;
            mc.sharedMesh = m;

            m.RecalculateBounds();
            planetScript.updateMesh(m);
            Destroy(this.gameObject);
        }
        else
        {
            timeAlive += 0.2f;
        }
        Attract(attractor);
    }

    void Attract(PlanetAttractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = gravity * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }

    bool CheckIfInOcean(Vector3 planetPosition, float planetScale)
    {
        Vector3 distance = this.gameObject.transform.position - planetPosition;
        float val = Mathf.Pow(distance.x, 2) + Mathf.Pow(distance.y, 2) + Mathf.Pow(distance.z, 2);
        if (val <= planetScale * planetScale + this.GetComponent<SphereCollider>().radius)
        {
            return true;
        }
        return false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (sediment < sedimentCap)
        {
            float chance = Random.Range(0, 100);
            if (sedimentRemoveChance < chance)
            {
                PlanetAttractor attractor = FindObjectOfType<PlanetAttractor>();
                Vector3 planetPosition = attractor.gameObject.transform.position;
                float planetScale = attractor.gameObject.transform.localScale.x;
                if (!CheckIfInOcean(planetPosition, planetScale) && !(this.GetComponent<Rigidbody>().velocity.magnitude < 0.01f && timeAlive > 1))
                {
                    m = planet.GetComponent<MeshFilter>().mesh;
                    mc = planet.GetComponent<MeshCollider>();

                    Vector3 raindropPositon = transform.position;
                    verts = m.vertices;
                    int vertIndex = 0;
                    float shortestDistance = float.MaxValue;

                    for (int i = 0; i < verts.Length; i++)
                    {
                        float distance = Mathf.Sqrt(Mathf.Pow(verts[i].x - raindropPositon.x, 2) +
                            Mathf.Pow(verts[i].y - raindropPositon.y, 2) + Mathf.Pow(verts[i].z - raindropPositon.z, 2));

                        if (shortestDistance > distance)
                        {
                            shortestDistance = distance;
                            vertIndex = i;
                        }

                    }

                    Vector3 newVert = verts[vertIndex] * sedimentDissolution;
                    newSediment = verts[vertIndex] - newVert;
                    sediment += Mathf.Sqrt(Mathf.Pow(verts[vertIndex].x - newVert.x, 2) +
                            Mathf.Pow(verts[vertIndex].y - newVert.y, 2) + Mathf.Pow(verts[vertIndex].z - newVert.z, 2));
                    //Debug.Log(sediment);
                    //Debug.Log("--------------");

                    verts[vertIndex] = newVert;

                    m.vertices = verts;
                    mc.sharedMesh = m;

                    m.RecalculateBounds();
                    planetScript.updateMesh(m);
                }
            }
        }
    }
}
