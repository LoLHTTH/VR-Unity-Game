
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public UnityEngine.Object cubeObject;
    public Vector3 cubePosition;

    float timer = 0;
    float spawnTime = 100;
    float z;
    int path = 1;
    bool changeSpawnTime = true;

    public UnityEngine.Object snowBallObject;
    public Vector3 snowBallPos;
    float snowBallTimer = 0;
    int snowCount = 0;

    // Use this for initialization
    void Start()
    {
        //STRAIGHT LINE
        for (int i = 0; i < 30; i++)
        {
            cubePosition = new Vector3(0, 0.5f, 22 + i);
            Instantiate(cubeObject, cubePosition, Quaternion.identity);
            cubePosition = new Vector3(-12, 0.5f, 22 + i);
            Instantiate(cubeObject, cubePosition, Quaternion.identity);
        }

        // WALL OF OBSTACLES
        for (int i = 0; i < 47; i++)
        {
            if (i > 0)
            {
                cubePosition = new Vector3(i, 0.5f, 22);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
                cubePosition = new Vector3(-i - 12, 0.5f, 22);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            timer++;
            if (timer >= spawnTime) // TIMER TO MAKE NEW PATH
            {
                timer = 0;
                if (path == 1)
                {
                    path++;
                    DiagonalPath();
                }
               else if (path == 2)
                {
                    path++;
                    StraightLine();
                }
                else if (path == 3)
                {
                    path++;
                    DiagonalPath();
                }
                else if (path == 4)
                {
                    path++;
                    DiagonalPath();
                }
                else
                {
                    snowBallTimer++;
                    if (changeSpawnTime)
                    {
                        spawnTime = 10;
                        changeSpawnTime = false;
                    }
                    if (spawnTime > 3)
                    {
                        spawnTime -= 0.05f;
                    }
                    cubePosition = new Vector3(Random.Range(-47, 47), 0.5f, 22f);
                    Instantiate(cubeObject, cubePosition, Quaternion.identity);

                    if (snowBallTimer >= 15 && snowCount < 30)
                    {
                        snowCount++;
                        snowBallPos = new Vector3(Random.Range(-47, 47), Random.Range(10, 20), 22f);
                        Instantiate(snowBallObject, snowBallPos, Quaternion.identity);
                    }
                }
            }
        }
    }

    void DiagonalPath()
    {
        //DIAGONAL LINE
        for (int i = 0; i < 30; i++)
        {
            if (i < 15)
            {
                cubePosition = new Vector3(i, 0.5f, 22 + i);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
                cubePosition = new Vector3(i - 12, 0.5f, 22 + i);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
            }
            else
            {
                cubePosition = new Vector3(-i + 12 + 16, 0.5f, 22 + i);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
                cubePosition = new Vector3(-i + 16, 0.5f, 22 + i);
                Instantiate(cubeObject, cubePosition, Quaternion.identity);
            }
        }
    }
    void StraightLine()
    {
        //STRAIGHT LINE
        for (int i = 0; i < 30; i++)
        {
            cubePosition = new Vector3(0, 0.5f, 22 + i);
            Instantiate(cubeObject, cubePosition, Quaternion.identity);
            cubePosition = new Vector3(-12, 0.5f, 22 + i);
            Instantiate(cubeObject, cubePosition, Quaternion.identity);
        }
    }
}


