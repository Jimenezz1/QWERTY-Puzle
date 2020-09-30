using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratresses : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSen = 100f;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSen, 0, 0);
        player.transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * mouseSen, 0);
    }
}
