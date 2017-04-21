using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnowBall : MonoBehaviour {

    Vector3 zForce = new Vector3(0f, 0f, 0.3f);
    Vector3 currentPos;
    Vector3 startPos = new Vector3(0f, 10, 22f);
    float speed = 0.005f;

    float z;

    // Use this for initialization
    void Start()
    {
        startPos = new Vector3(Random.Range(-47, 47), Random.Range(10, 20), 22f);
    }
    // Update is called once per frame
    void Update()
    {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            currentPos = gameObject.transform.position;
            if (currentPos.z > -20)
            {
                gameObject.transform.position += -zForce;
            }
            else if (currentPos.z <= -20)
            {
                startPos = new Vector3(Random.Range(-47, 47), Random.Range(10, 20), 22f);
                gameObject.transform.position = startPos;
                zForce.z += speed;
            }
        }
    }
}
