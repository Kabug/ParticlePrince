using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAttractor : MonoBehaviour
{

    const float gravity = 5;
    public Rigidbody rb;

    void FixedUpdate()
    {
        RaindropAttractor[] attractors = FindObjectsOfType<RaindropAttractor>();
        foreach (RaindropAttractor attractor in attractors)
        {
            Attract(attractor);
        }
    }

    void Attract(RaindropAttractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = gravity * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
