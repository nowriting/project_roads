using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceDoor_temp1 : MonoBehaviour {

    // Temp because when I figure out how to get the tags to cooperate on doors this will be obsolete;

    public string scene_trek = "scene_trek";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider choiceDoor_temp1)
    {
        SceneManager.LoadScene(scene_trek);
    }
}
