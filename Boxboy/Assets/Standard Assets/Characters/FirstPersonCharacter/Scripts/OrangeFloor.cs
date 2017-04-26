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
            player.GetComponent<FirstPersonController>().m_Jump = true;
          //  player.GetComponent<FirstPersonController>().m_MoveDir.y
          //      = player.GetComponent<FirstPersonController>().m_JumpSpeed;
            player.GetComponent<FirstPersonController>().m_JumpSpeed *= 2;
        }
    }

    void OnTriggerExit()
    {
        player.GetComponent<FirstPersonController>().m_JumpSpeed /= 2;
    }
}
