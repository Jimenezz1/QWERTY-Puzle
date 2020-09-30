using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime * speed);
    }
}
