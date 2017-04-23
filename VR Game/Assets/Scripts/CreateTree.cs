using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTree : MonoBehaviour {
    public UnityEngine.Object newObject;
    public Vector3 cubePosition;

    int cloneCount = 0;
    float timer = 0;
    float spawnTime = 100;
    float z;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            cubePosition = new Vector3(Random.Range(-47, 47), 0.5f, 22f);
            Instantiate(newObject, cubePosition, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            if (cloneCount < 30)
            {
                if (timer < spawnTime)
                {
                    timer++;
                }
                else
                {
                    timer = 0;
                    cubePosition = new Vector3(Random.Range(-47, 47), 0.5f, 22f);
                    Instantiate(newObject, cubePosition, Quaternion.identity);
                    cloneCount++;
                }
                if (spawnTime > 75)
                {
                    spawnTime -= 0.5f;
                }
            }
        }
    }
}
