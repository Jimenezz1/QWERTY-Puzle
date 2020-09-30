using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    public Transform pathHolder;
    public float speed = 150f;

    public float waitTime = .3f;

    void OnDrawGizmos()
    {

        Vector3 startPosition = pathHolder.GetChild(0).position;
        Vector3 previousPosition = startPosition;

        foreach (Transform wayPoint in pathHolder)
        {

            Gizmos.DrawSphere(wayPoint.position, 1f);
            Gizmos.DrawLine(previousPosition,wayPoint.position);
            previousPosition = wayPoint.position;

        }
    }

    IEnumerator FollowPath(Vector3 [] waypoints)
	{
        transform.position = waypoints[0];

        int targetWayPointIndex = 1;

        Vector3 targetWayPoint = waypoints[targetWayPointIndex];

        while (true)
		{
            transform.position = Vector3.MoveTowards(transform.position, targetWayPoint, speed * Time.deltaTime);

            if (transform.position == targetWayPoint)
			{
                targetWayPointIndex = (targetWayPointIndex + 1) % waypoints.Length;
                targetWayPoint = waypoints[targetWayPointIndex];
                yield return new WaitForSeconds(waitTime);
			}
            yield return null;
		}
    }

    void Start()
	{
        Vector3[] waypoints = new Vector3[pathHolder.childCount];

        for(int iX = 0; iX < waypoints.Length; iX++)
		{
            waypoints[iX] = pathHolder.GetChild(iX).position;

		}

        StartCoroutine(FollowPath(waypoints));
	}

}
