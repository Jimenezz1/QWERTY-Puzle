using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform respawnPoint;

    void onTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Enemy")
        {

            player.transform.position = respawnPoint.transform.position;


        }
    }


}

/*
if(other.gameObject.tag == "Enemy")
		{

            // SceneManager.LoadScene(scene.name);
            // player.transform.position = respawnPoint.transform.position;


        }
*/