using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeField : MonoBehaviour
{
    [Range(1, 20)]
    public int sideLength = 10;
    public float cubeScale = .5f;
    public Transform cubePrefab;
    public bool animate = false;

    private Transform[,] cubes;

    private void Start()
    {
        cubes = new Transform[sideLength, sideLength];
        float offset = (float)sideLength / 2f - .5f;

        // Instantiate array of cubes
        for (int x = 0; x < sideLength; x++)
        {
            for (int z = 0; z < sideLength; z++)
            {
                Transform cube = Instantiate(cubePrefab);
                cube.transform.parent = transform;
                cube.localPosition = new Vector3(x - offset, 0, z - offset);
                cube.localScale = Vector3.one * cubeScale;

                // Make a checkerboard layer change to demo the layer segmentation
                if ((x + z) % 2 == 0)
                {
                    cube.gameObject.layer = 3;
                }

                cubes[x, z] = cube;

            }
        }
    }

    private void Update()
    {
        float t = 0;

        if (animate)
        {
            t = Time.time;
        }

        // Iterate through cubes and position them on the y axis
        for (int x = 0; x < cubes.GetLength(0); x++)
        {
            for (int z = 0; z < cubes.GetLength(1); z++)
            {
                float y = (Mathf.Sin(x + t) + Mathf.Sin(z + t)) / 2f;
                cubes[x, z].localPosition = new Vector3(cubes[x, z].localPosition.x, y, cubes[x, z].localPosition.z);

            }
        }
    }
}
