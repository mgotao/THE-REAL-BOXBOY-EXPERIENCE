/*
Copyright 2016 Frederic Babord

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*/
using System.Collections;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    public int quantity = 0;
    public InvantoryObject objectRefrence;
    private bool justSpawned = false;
    private bool canPickUp = false;

    void Start()
    {
        justSpawned = true;
        StartCoroutine(SpawnSleepTimer());
    }

    void Update()
    {
        if (canPickUp && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Invantory>().AddItemToInvanntory(this);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !justSpawned)
        {
            canPickUp = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canPickUp = false;
            justSpawned = false;
            StopCoroutine(SpawnSleepTimer());
        }
    }

    void OnGUI()
    {
        if (canPickUp) GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 25, 200, 200), "Press E to pick up.");
    }

    IEnumerator SpawnSleepTimer()
    {
        yield return new WaitForSeconds(2);
        justSpawned = false;
    }
}