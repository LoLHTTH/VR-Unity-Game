using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Vector3 zForce = new Vector3(0f, 0f, 0.3f);
    Vector3 currentPos;

    float z;

    // Use this for initialization
    void Start () {
        //        cubePosition = new Vector3(Random.Range(-47, 47), 0.5f, 22f);
        //        Instantiate(newObject, cubePosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update () {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            currentPos = gameObject.transform.position;
            if (currentPos.z > -18.5)
            {
                gameObject.transform.position += -zForce;
                // gameObject.GetComponent<Rigidbody>().AddForce(-zForce);
            }
            else if (currentPos.z <= -18.5)
            {
                Destroy(gameObject);
            }
        }
    }
}
