using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDetroyAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        // when we move to new scene it wont destroy the game object
    }

}
