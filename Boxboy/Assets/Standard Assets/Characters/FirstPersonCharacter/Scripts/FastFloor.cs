using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FastFloor : MonoBehaviour {
    public GameObject player;
    float checkSpeed, checkMass;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        checkMass = player.GetComponent<Rigidbody>().mass;
        checkSpeed = player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider dood)
    {
        if (dood.tag == "Player")
        {
            if (checkMass >= 10)
            {
                checkMass -= 2;
                player.GetComponent<Rigidbody>().mass = checkMass;
            }
            if (checkSpeed <= 6)
            {
                checkSpeed += 8;
                player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = checkSpeed;
            }
        }
    }

    void OnTriggerExit()
    {
        if (checkMass <= 8)
        {
            checkMass += 2;
            player.GetComponent<Rigidbody>().mass = checkMass;
        }
        if (checkSpeed >= 14)
        {
            checkSpeed -= 8;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = checkSpeed;
        }
    }
}
