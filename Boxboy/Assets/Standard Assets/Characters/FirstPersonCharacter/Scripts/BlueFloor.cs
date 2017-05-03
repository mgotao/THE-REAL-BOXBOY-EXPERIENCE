using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BlueFloor : MonoBehaviour {
    public GameObject player;
    float checkSpeed;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        checkSpeed = player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider dood)
    {
        if (dood.tag == "Player")
        {
            checkSpeed += 10;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = checkSpeed;
        }
    }

    void OnTriggerExit()
    {
        if (checkSpeed > 8)
        {
            checkSpeed -= 10;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = checkSpeed;
        }
    }
}
