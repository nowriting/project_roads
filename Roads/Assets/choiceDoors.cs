using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceDoors : MonoBehaviour {

    public string scene_australia = "scene_australia";
    // public string town_door1 = "Town_Choice1";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider choiceDoors)
    {
        // Damn thing shows as Untagged. Even when it's tagged. Temp solution.
        // Debug.Log("Trigger name: " + choiceDoors.tag);

        // if (choiceDoors.tag == "test")
        // {
            SceneManager.LoadScene(scene_australia);
        // }
    }
}
