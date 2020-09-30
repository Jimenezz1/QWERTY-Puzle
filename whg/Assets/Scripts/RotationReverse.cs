using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationReverse : MonoBehaviour
{
    private float speed = 1.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
        transform.RotateAround(Vector3.one , Vector3.down, 20 * Time.deltaTime * speed);
    }
}
