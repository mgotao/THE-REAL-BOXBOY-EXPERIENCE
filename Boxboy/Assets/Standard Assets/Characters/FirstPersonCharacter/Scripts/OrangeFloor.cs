using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class OrangeFloor : MonoBehaviour {
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
            player.GetComponent<Rigidbody>().mass -= 2;
            player.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce *= 2;
            player.GetComponent<RigidbodyFirstPersonController>().m_Jump = true;
            
        }
    }

    void OnTriggerExit()
    {
        player.GetComponent<Rigidbody>().mass += 2;
        player.GetComponent<RigidbodyFirstPersonController>().movementSettings.JumpForce /= 2;
    }
}
