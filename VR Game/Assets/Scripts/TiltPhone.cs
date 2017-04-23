using UnityEngine;
using System.Collections;

public class TiltPhone : MonoBehaviour {
    float speed = 1.5f;
    float z;
    bool alive;
    int score;
    Vector3 moveX = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (z == -19)
        {
            alive = true;
        }
        else
        {
            alive = false;
        }
        if (alive)
        {
            score++;
        }
    }
    void FixedUpdate()
    {
        z = GameObject.Find("Cube").transform.position.z;
        if (alive)
        {
            Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, 0.0f);
            //GetComponent<Rigidbody>().velocity = movement * speed;
            if (gameObject.transform.position.x <= 47 && gameObject.transform.position.x >= -47)
            {
                gameObject.transform.Translate(movement * speed);

                if (Input.GetKey(KeyCode.D))
                {
                    moveX.x = 0.5f;
                    gameObject.transform.Translate(moveX * speed);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    moveX.x = -0.5f;
                    gameObject.transform.Translate(moveX * speed);
                }
            }

            if (gameObject.transform.position.x > 47)
            {
                gameObject.transform.position = new Vector3(47, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            else if (gameObject.transform.position.x < -47)
            {
                gameObject.transform.position = new Vector3(-47, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }

    }
    void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle(); //create a new variable
        guiStyle.fontSize = 35; //change the font size       

        GUI.Label(new Rect(0, 0, 250, 20), "Score: " + (score).ToString(), guiStyle);
        //GUI.Label(new Rect(0, 0, 250, 20), "Score: " + (score).ToString() + "\nR to restart", guiStyle);

        if (!alive)
        {
            GUI.Label(new Rect(Screen.width / 2f - 65, 0, 200, 200), "You lost!", guiStyle);
        }
    }
}
