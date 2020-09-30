
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0f, 3f, -9f);
    public float smoothSpeed = 0.125f;

    


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }

   
}
