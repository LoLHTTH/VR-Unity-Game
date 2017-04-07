using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadScene1 : MonoBehaviour {
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // RELOADS THE SCENE
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        } 
    }
}
