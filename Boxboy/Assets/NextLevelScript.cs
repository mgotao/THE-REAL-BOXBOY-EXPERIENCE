using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour {

    public int level;
    public string next;

    // Use this for initialization
    void Start () {
        level += 1;
        next = "LV " + level;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player") SceneManager.LoadScene(next);
    }
}
