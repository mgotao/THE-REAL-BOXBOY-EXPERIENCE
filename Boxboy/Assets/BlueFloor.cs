using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BlueFloor : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider dood)
    {
        if (dood.tag == "Player")
        {
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed += 30;
        }
    }

    void OnTriggerExit()
    {
        player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed -= 30;
    }
}
