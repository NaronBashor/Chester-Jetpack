using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPilar : MonoBehaviour
{
        [SerializeField] private GameObject[] waypoints;

        [SerializeField] private int currentWaypoint = 0;
        [SerializeField] private float speed = 2;

        private void Update()
        {
                WaypointFollower();
        }

        public void WaypointFollower()
        {
                if (Vector2.Distance(waypoints[currentWaypoint].transform.position, transform.position) < .01f)
                {
                        currentWaypoint++;
                        if (currentWaypoint >= waypoints.Length)
                        {
                                currentWaypoint = 0;
                        }
                }
                transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, Time.deltaTime * speed);
        }
}
