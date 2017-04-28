using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    //private AudioSource player;
    //public AudioClip openSound;
    private MeshCollider foo;
    private Renderer bar;
    bool isOpen = false;
    public GameObject door;
    public GameObject key;


    // Use this for initialization
    void Start()
    {
        //player = GetComponent<AudioSource>();
        foo = GetComponent<MeshCollider>();
        bar = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider dude)
    {
        if (dude.tag == "Player" && !isOpen && key.activeSelf)
        {
            //player.PlayOneShot(openSound);
            isOpen = true;
            foo.enabled = false;
            bar.enabled = false;
            door.SetActive(false);
            key.SetActive(false);
        }
    }
}
