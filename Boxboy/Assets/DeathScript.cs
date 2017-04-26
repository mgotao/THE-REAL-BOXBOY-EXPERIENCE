using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScript : MonoBehaviour {

    public Scene level;

    // Use this for initialization
    void Start () {
        level = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player") SceneManager.LoadScene(level.name);
    }
}
