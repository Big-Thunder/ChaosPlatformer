using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravellingSpikeHazard : MonoBehaviour, IHazard
{
    [SerializeField] private Rigidbody2D rb;
    
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private Transform currentWayPoint;
    
    [SerializeField] private float currentSpeed;
    [SerializeField] private float travelSpeed;
    [SerializeField] private float rotationSpeed;
    
    [SerializeField] private int wayPointIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentWayPoint = wayPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        TravelWaypoints();
    }

    void TravelWaypoints()
    {
        if (wayPoints.Length > 0 && currentWayPoint != null)
        {
            if (Vector3.Distance(transform.position, currentWayPoint.position) < 0.5f)
            {
                wayPointIndex = (wayPointIndex + 1) % wayPoints.Length;
                currentWayPoint = wayPoints[wayPointIndex];
            }

            GoToWaypoint(currentWayPoint);
        }
    }
    
    void GoToWaypoint(Transform wayPoint)
    {
        Vector2 direction = (wayPoint.position - transform.position).normalized;
        rb.velocity = direction * currentSpeed;
    }

    public void ActivateHazard()
    {
        currentSpeed = travelSpeed;
        rb.angularVelocity = rotationSpeed;
    }

    public void DeactivateHazard()
    {
        currentSpeed = 0f;
        rb.angularVelocity = 0f;
    }
}
