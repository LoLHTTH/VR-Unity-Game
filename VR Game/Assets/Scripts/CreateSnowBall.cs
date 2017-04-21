using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSnowBall : MonoBehaviour {

    public UnityEngine.Object newObject;
    public Vector3 snowBallPos;

    float timer = 0;
    float spawnTime = 100;
    float z;

    // Use this for initialization
    void Start () {
		for (int i =0;i< 3; i++)
        {
            snowBallPos = new Vector3(Random.Range(-47, 47), Random.Range(10, 20), 22f);
            Instantiate(newObject, snowBallPos, Quaternion.identity);
        }
	}

    // Update is called once per frame
    void Update()
    {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            if (timer < spawnTime)
            {
                timer++;
            }
            else
            {
                timer = 0;
                snowBallPos = new Vector3(Random.Range(-47, 47), Random.Range(10, 20), 22f);
                Instantiate(newObject, snowBallPos, Quaternion.identity);
            }
        }
    }
}
