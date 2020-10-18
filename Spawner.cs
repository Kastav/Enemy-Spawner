//Enemy spawning script 
//By Dylan Shearsby
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Datastore - varibles

    //Enemy prefab
    public GameObject Enemy;

    public GameObject Trigger;

    
    void OnTriggerEnter(Collider other)
    {   //Check if the player is in the trigger box via tag
        if (other.gameObject.tag == "Character")
        {
            //Invoke spawn to spawn enemies
            InvokeRepeating("Spawn", 0, 0);


            //Destroying the collider
            Destroy(Trigger);

        }
    }

    void Spawn()
    {

        //Spawning a new enemy

        //Set a loop so more than one enemy spawn 
        //set the range in which is will get a random location. 
        for (int i = 1; i < 21; i++)
        {
            Instantiate(Enemy, new Vector3((Random.Range(-7, 7)), 1, (Random.Range(-7, 7))), Quaternion.identity);
        }


    }
}


