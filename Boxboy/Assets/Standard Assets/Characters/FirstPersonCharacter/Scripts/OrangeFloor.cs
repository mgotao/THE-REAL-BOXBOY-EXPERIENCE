using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class OrangeFloor : MonoBehaviour {
    public GameObject player;
    float checkJump, checkMass;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        checkMass = player.GetComponent<Rigidbody>().mass;
        checkJump = player.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider dood)
    {
        if (dood.tag == "Player")
        {
            checkMass -= 2;
            player.GetComponent<Rigidbody>().mass = checkMass;
            checkJump *= 2;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce = checkJump;
            player.GetComponent<RigidbodyFirstPersonController>().m_Jump = true;
            
        }
    }

    void OnTriggerExit()
    {
        if (checkMass < 10)
        {
            checkMass += 2;
            player.GetComponent<Rigidbody>().mass = checkMass;
        }
        if (checkJump > 80)
        {
            checkJump /= 2;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce = checkJump;
        }
    }
}
