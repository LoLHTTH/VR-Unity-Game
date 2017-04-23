using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnowBall : MonoBehaviour {

    Vector3 zForce = new Vector3(0f, 0f, 0.5f);
    Vector3 currentPos;

    float z;

    // Use this for initialization
    void Start()
    {

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
                Destroy(gameObject);
            }
        }
    }
}
