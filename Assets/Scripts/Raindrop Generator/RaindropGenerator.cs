using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropGenerator : MonoBehaviour
{
    //Rigidbody planet = FindObjectOfType<PlanetAttractor>().rb;
    public float planetSize;
    public GameObject planet;
    public Vector3 buffer = new Vector3(25,25,25);
    public float maxIterations = 100;
    public GameObject raindrop;
    private float iterations = 0;
    private bool wait = true;
    private List<Vector3> positions = new List<Vector3>();
    public float maxAtATime = 100;

    void Start()
    {
        planet = FindObjectOfType<PlanetAttractor>().gameObject;
        planetSize = planet.transform.localScale.x;
        MeshFilter mf = planet.GetComponent<MeshFilter>();
        for (iterations = 0; iterations < maxIterations; iterations++) {
            Vector3 position = Random.onUnitSphere * planetSize + buffer;
            positions.Add(position);
        }
    }

    void FixedUpdate()
    {
        float raindropCount = FindObjectsOfType<RaindropAttractor>().Length;
        int positionsCount = positions.Count;
        if (raindropCount < maxAtATime && positionsCount != 0)
        {
            int index = Random.Range(0, positionsCount - 1);
            Instantiate(raindrop, positions[index], new Quaternion(0, 0, 0, 0));
            positions.Remove(positions[index]);
        }
    }
}
