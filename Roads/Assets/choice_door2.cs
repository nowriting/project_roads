using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice_door2 : MonoBehaviour {

    public string scene_town = "scene_town";

    public void OnTriggerEnter(Collider choiceDoor_temp1)
    {
        SceneManager.LoadScene(scene_town);
    }
}
