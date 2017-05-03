using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour {

    public Transform player;
    public Transform cam;
    bool isCarried = false, inRange = false, inContact = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);
        if (distance <= 3.5f)
        {
            inRange = true;
        }
        else inRange = false;

        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = cam;
            isCarried = true;
        }
        if (isCarried)
        {
            if (inContact)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                isCarried = false;
                inContact = false;
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                isCarried = false;
            }
        }
	}

    void OnTriggerEnter()
    {
        if (isCarried) inContact = true;
    }
}
