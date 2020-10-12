using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWall : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource winSound;

    private void Start()
    {
        winSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
    
            winSound.Play();
        }
    }
}
