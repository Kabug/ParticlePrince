//Source: https://www.binpress.com/creating-octahedron-sphere-unity/

using UnityEngine;
//using System.Linq;

public static class OctahedronSphereCreator
{

    private static Vector3[] directions = {
            Vector3.left,
            Vector3.back,
            Vector3.right,
            Vector3.forward
    };

    private static void CreateTangents(Vector3[] vertices, Vector4[] tangents)
    {
        for(int i = 0; i < vertices.Length; i++)
        {
            Vector3 v = vertices[i];
            v.y = 0f;
            v = v.normalized;
            Vector3 tangent;
            tangent.x = -v.z;
            tangent.y = 0f;
            tangent.z = v.x;

            tangents[i] = tangent;
        }

        tangents[vertices.Length - 4] = tangents[0] = new Vector3(-1f, 0, -1f).normalized;
        tangents[vertices.Length - 3] = tangents[1] = new Vector3(1f, 0f, -1f).normalized;
        tangents[vertices.Length - 2] = tangents[2] = new Vector3(1f, 0f, 1f).normalized;
        tangents[vertices.Length - 1] = tangents[3] = new Vector3(-1f, 0f, 1f).normalized;
        for (int i = 0; i < 4; i++)
        {
            tangents[vertices.Length - 1 - i].w = tangents[i].w = -1f;
        }
    }

    //Top Hemisphere
    private static int CreateUpperStrip(int steps, int vTop, int vBottom, int t, int[] triangles)
    {
        triangles[t++] = vBottom;
        triangles[t++] = vTop - 1;
        triangles[t++] = ++vBottom;
        for (int i = 1; i <= steps; i++)
        {
            triangles[t++] = vBottom;
            triangles[t++] = vTop - 1;
            triangles[t++] = vTop;

            triangles[t++] = vBottom++;
            triangles[t++] = vTop++;
            triangles[t++] = vBottom;
        }
        return t;
    }

    //Bottom Hemisphere
    private static int CreateLowerStrip(int steps, int vTop, int vBottom, int t, int[] triangles)
    {
        for (int i = 1; i < steps; i++)
        {
            triangles[t++] = vBottom;
            triangles[t++] = vTop - 1;
            triangles[t++] = vTop;

            triangles[t++] = vBottom++;
            triangles[t++] = vTop++;
            triangles[t++] = vBottom;
        }
        triangles[t++] = vBottom;
        triangles[t++] = vTop - 1;
        triangles[t++] = vTop;
        return t;
    }

    private static int CreateVertexLine(Vector3 from, Vector3 to, int steps, int v, Vector3[] vertices)
    {
        for (int i = 1; i <= steps; i++)
        {
            vertices[v++] = Vector3.Lerp(from, to, (float)i / steps);
        }
        return v;
    }

    private static void CreateOctahedron(Vector3[] vertices, int[] triangles, int resolution)
    {
        int v = 0, vBottom = 0, t = 0;

        for (int i = 0; i < 4; i++)
        {
            vertices[v++] = Vector3.down;
        }

        //Bottom Hemisphere
        for (int i = 1; i <= resolution; i++)
        {
            float progress = (float)i / resolution;
            Vector3 from, to;
            vertices[v++] = to = Vector3.Lerp(Vector3.down, Vector3.forward, progress);
            for (int d = 0; d < 4; d++)
            {
                from = to;
                to = Vector3.Lerp(Vector3.down, directions[d], progress);
                //Very top/cap
                t = CreateLowerStrip(i, v, vBottom, t, triangles);
                //Sides
                v = CreateVertexLine(from, to, i, v, vertices);
                vBottom += i > 1 ? (i - 1) : 1;
            }
            vBottom = v - 1 - i * 4;
        }

        //Top Hemisphere
        for (int i = resolution - 1; i >= 1; i--)
        {
            float progress = (float)i / resolution;
            Vector3 from, to;
            vertices[v++] = to = Vector3.Lerp(Vector3.up, Vector3.forward, progress);
            //float test = Mathf.PerlinNoise(to.x, to.z) * 2f;
            //to.y = to.y + test;
            //Debug.Log(to);
            for (int d = 0; d < 4; d++)
            {
                from = to;
                to = Vector3.Lerp(Vector3.up, directions[d], progress);
                //Very top/cap
                t = CreateUpperStrip(i, v, vBottom, t, triangles);
                //Sides
                v = CreateVertexLine(from, to, i, v, vertices);
                vBottom += i + 1;
            }
            vBottom = v - 1 - i * 4;
        }

        for (int i = 0; i < 4; i++)
        {
            triangles[t++] = vBottom;
            triangles[t++] = v;
            triangles[t++] = ++vBottom;
            vertices[v++] = Vector3.up;
        }
    }

    private static void CreateUV(Vector3[] vertices, Vector2[] uv)
    {
        float previousX = 1f;
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 v = vertices[i];
            if (v.x == previousX)
            {
                uv[i - 1].x = 1f;
            }
            previousX = v.x;
            Vector2 textureCoordinates;
            textureCoordinates.x = Mathf.Atan2(v.x, v.z) / (-2f * Mathf.PI);
            if (textureCoordinates.x < 0f)
            {
                textureCoordinates.x += 1f;
            }
            textureCoordinates.y = Mathf.Asin(v.y) / Mathf.PI + 0.5f;
            uv[i] = textureCoordinates;
        }
        uv[vertices.Length - 4].x = uv[0].x = 0.125f;
        uv[vertices.Length - 3].x = uv[1].x = 0.375f;
        uv[vertices.Length - 2].x = uv[2].x = 0.625f;
        uv[vertices.Length - 1].x = uv[3].x = 0.875f;
    }

    //Creates a Mesh given Subdivisons and Radius and noise settings for Octahedron
    public static Mesh Create (ObjectSettings objectSettings, NoiseSettings noiseSettings, SimpleNoiseFilter noiseFilter)
    {
        if (objectSettings.subdivisions < 0)
        {
            objectSettings.subdivisions = 0;
            Debug.LogWarning("Octahedron Sphere subdivisions increased to minimum, which is 0.");
        }
        //Can't go above 7 subdivisions because unity only uses 16 bit integers.
        //This maxes out at 32,767.
        //7 subdivisions will have 65,799 vertices which is way too high so we have to account.
        else if (objectSettings.subdivisions > 6)
        {
            objectSettings.subdivisions = 6;
            Debug.LogWarning("Octahedron Sphere subdivisions decreased to maximum, which is 6.");
        }

        //Vector3[] vertices =
        //{
        //    Vector3.down, Vector3.down, Vector3.down, Vector3.down,
        //    Vector3.forward,
        //    Vector3.left,
        //    Vector3.back,
        //    Vector3.right,
        //    Vector3.up, Vector3.up, Vector3.up, Vector3.up
        //};

        //int [] triangles =
        //{
        //    //Bottom Half
        //    0, 4, 5,
        //    1, 5, 6,
        //    2, 6, 7,
        //    3, 7, 4,

        //    //Top Half
        //    8, 5, 4,
        //    9, 6, 5,
        //    10, 7, 6,
        //    11, 4, 7
        //};
        //Bit shifting! Did this in the assembly lab.
        int resolution = 1 << objectSettings.subdivisions;
        Vector3[] vertices = new Vector3[(resolution + 1) * (resolution + 1) * 4 - (resolution * 2 - 1) * 3];
        int[] triangles = new int[(1 << (objectSettings.subdivisions * 2 + 3)) * 3];
        CreateOctahedron(vertices, triangles, resolution);

        //Normalize vectors
        //Keeps direction but maximum length is 1
        //Explanation: https://bit.ly/34agHAz
        Vector3[] normals = new Vector3[vertices.Length];
        for (int i=0; i <vertices.Length; i++)
        {
            normals[i] = vertices[i] = vertices[i].normalized;
        }

        Vector2[] uv = new Vector2[vertices.Length];
        CreateUV(vertices, uv);

        Vector4[] tangents = new Vector4[vertices.Length];

        CreateTangents(vertices, tangents);

        //Adjust sizes if radius is larger than 1
        /*
        if (radius != 1f)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] *= radius;
            }
        }
        
        //vertices = vertices.OrderBy(v => v.x).ToArray<Vector3>();
        for (int i = 0; i < vertices.Length; i++)
        {
            //Debug.Log(vertices[i]);
            //float perlinZ = Mathf.PerlinNoise(vertices[i].x, vertices[i].y) * seed;
            //float perlinX = Mathf.PerlinNoise(vertices[i].y, vertices[i].z) * seed;
            //float perlinY = Mathf.PerlinNoise(vertices[i].z, vertices[i].x) * seed; ;
            //vertices[i].z += perlinZ;
            //vertices[i].x += perlinX;
            //vertices[i].y += perlinY;


            float randomNum = Random.Range(1, 1.05f);
            randomNum = 1;
            //float randomNum2 = Random.Range(-1, 1f);
            float noise = Perlin.Noise(vertices[i].x * seed * randomNum, vertices[i].y * seed * randomNum, vertices[i].z * seed * randomNum);

            //add random number in range to make it more detailed
            //normalise values by dividing noise by max height



            //if (noise > 0.12f){
            //    noise = 0.12f;
            //}
            //if(noise < -0.12f){
            //    noise = -0.12f;
            //}
            
            if (radius >= 1)
            {
                noise = noise * radius / (radius + radius);
            }
            else
            {
                noise = noise * radius / (1 + radius);
            }
            //if(noise * (noise + randomNum) > radius)
            //{
            //    noise = noise * (noise + randomNum);
            //}
            



            if (Mathf.Abs(vertices[i].x) >= Mathf.Abs(vertices[i].y) && Mathf.Abs(vertices[i].x) >= Mathf.Abs(vertices[i].z))
            {
                //if(Mathf.Abs(noise) > 0.1){
                    if(noise > 0 && vertices[i].x > 0 || noise < 0 && vertices[i].x < 0){
                        vertices[i].x += noise;
                    }
                //}
            }
            if (Mathf.Abs(vertices[i].y) >= Mathf.Abs(vertices[i].x) && Mathf.Abs(vertices[i].y) >= Mathf.Abs(vertices[i].z))
            {
                //if(Mathf.Abs(noise) > 0.1){
                    if(noise > 0 && vertices[i].y > 0 || noise < 0 && vertices[i].y < 0){
                        vertices[i].y += noise;
                    }
                //}
            }
            if (Mathf.Abs(vertices[i].z) >= Mathf.Abs(vertices[i].x) && Mathf.Abs(vertices[i].z) >= Mathf.Abs(vertices[i].y))
            {
                //if(Mathf.Abs(noise) > 0.1){
                    if(noise > 0 && vertices[i].z > 0 || noise < 0 && vertices[i].z < 0){
                        vertices[i].z += noise;
                    }

                //}
            }

            //Debug.Log(vertices[i] + " " + noise);
            //Need to find the highest values then apply the noise to it
            //vertices[i].y += noise;
            //Debug.Log(test2);
        }
        //Debug.Log("=========");
        */

        //Simple version
        /*
        Noise noise = new Noise();
        for (int i = 0; i < vertices.Length; i++)
        {
            //float elevation = ((noise.Evaluate(vertices[i] * roughness + center) + 1) * 0.5f) * strength;
            float noiseValue = 0;
            float frequency = baseRoughness;
            float amplitude = 1;

            for (int l = 0; l < numLayers; l++)
            {
                float v = noise.Evaluate(vertices[i] * frequency + center);
                noiseValue += (v + 1) * 0.5f * amplitude;
                frequency *= roughness;
                amplitude *= persistence;
            }
            noiseValue = Mathf.Max(0, noiseValue - minValue);
            noiseValue *= strength;

            vertices[i] = vertices[i] * radius * (noiseValue + 1); 
        }
        */

        //Noise noise = new Noise();
        //for (int i = 0; i < vertices.Length; i++)
        //{
        //    //float elevation = ((noise.Evaluate(vertices[i] * roughness + center) + 1) * 0.5f) * strength;
        //    float noiseValue = 0;
        //    float frequency = baseRoughness;
        //    float amplitude = 1;
        //    float weight = 1;

        //    for (int l = 0; l < numLayers; l++)
        //    {
        //        float v = 1 - Mathf.Abs(noise.Evaluate(vertices[i] * frequency + center));
        //        v *= v;
        //        v *= weight;
        //        weight = v;
        //        noiseValue += v * amplitude;
        //        frequency *= roughness;
        //        amplitude *= persistence;
        //    }
        //    noiseValue = Mathf.Max(0, noiseValue - minValue);
        //    noiseValue *= strength;

        //    vertices[i] = vertices[i] * radius * (noiseValue + 1);
        //}

        for (int i = 0; i < vertices.Length; i++)
        {
            float noiseValue = noiseFilter.Evaluate(vertices[i]);
            vertices[i] = vertices[i] * objectSettings.radius * (noiseValue + 1);
        }


        Mesh mesh = new Mesh();
        mesh.name = "Octahedron Sphere";
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uv;
        mesh.triangles = triangles;
        return mesh;
    }
}