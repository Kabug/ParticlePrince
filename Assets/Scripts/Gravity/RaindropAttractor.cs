using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropAttractor : MonoBehaviour
{

    const float gravity = 5;
    public Rigidbody rb;
    private float timeAlive = 0;

    void FixedUpdate()
    {
        PlanetAttractor attractor = FindObjectOfType<PlanetAttractor>();
        Vector3 planetPosition = attractor.gameObject.transform.position;
        float planetScale = attractor.gameObject.transform.localScale.x;
        if (checkIfInOcean(planetPosition, planetScale))
        {
            Destroy(this.gameObject);
        }
        if (this.GetComponent<Rigidbody>().velocity.magnitude < 0.01f && timeAlive > 1)
        {
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

    bool checkIfInOcean(Vector3 planetPosition, float planetScale)
    {
        Vector3 distance = this.gameObject.transform.position - planetPosition;
        float val = Mathf.Pow(distance.x, 2) + Mathf.Pow(distance.y, 2) + Mathf.Pow(distance.z, 2);
        if(val <= planetScale* planetScale + this.GetComponent<SphereCollider>().radius)
        {
            return true;
        }
        return false;
    }
}
