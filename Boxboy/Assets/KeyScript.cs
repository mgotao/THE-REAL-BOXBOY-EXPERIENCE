using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    //private AudioSource player;
    //public AudioClip pickupSound;
    private Renderer ech;
    bool isPickedUp = false;
    public GameObject theKey;


	// Use this for initialization
	void Start () {
        //player = GetComponent<AudioSource>();
        ech = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider man) {
        if(man.tag == "Player" && !isPickedUp)
        {
            //player.PlayOneShot(pickupSound);
            isPickedUp = true;
            ech.enabled = false;
            theKey.SetActive(true);
            StartCoroutine(Delay(3.0f));
        }
    }

    IEnumerator Delay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }
}
