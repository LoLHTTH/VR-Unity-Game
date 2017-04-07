using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Vector3 zForce = new Vector3(0f, 0f, 0.3f);
    Vector3 currentPos;
    Vector3 startPos = new Vector3(0f, 0.5f, 22f);

    float z;

    // Use this for initialization
    void Start () {
        startPos = new Vector3(Random.Range(-15, 15), 0.5f, 22f);
    }

	// Update is called once per frame
	void Update () {
        z = GameObject.Find("Cube").transform.position.z;

        if (z == -19)
        {
            currentPos = gameObject.transform.position;
            if (currentPos.z > -19)
            {
                gameObject.transform.position += -zForce;
                // gameObject.GetComponent<Rigidbody>().AddForce(-zForce);
            }
            else if (currentPos.z <= -19)
            {
                startPos = new Vector3(Random.Range(-15, 15), 0.5f, 22f);
                gameObject.transform.position = startPos;
                zForce.z += 0.001f;
            }
        }
    }
}
