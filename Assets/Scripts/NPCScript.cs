using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float speed = 5f;
    public float circleRadius = 5f;
    public float changeDirectionTimeMin = 1f;
    public float changeDirectionTimeMax = 3f;
    public float pauseTimeMin = 1f;
    public float pauseTimeMax = 3f;

    private float currentAngle;
    private bool isMoving = true;
    private float directionTimer;
    private float pauseTimer;

    private Vector3 center; // Center point of the circle
    // private float angle = 0f; // Current angle on the circle

    private void Start()
    {
        // Calculate the center point of the circle based on the object's initial position
        // center = transform.position;
        // center = new Vector3(0.0f,0.0f,0.0f);

        directionTimer = Random.Range(changeDirectionTimeMin, changeDirectionTimeMax);
        currentAngle = Random.Range(0f, 360f);
        MoveInCircle();

    }

private void Update()
    {
        if (isMoving)
        {
            // Move the object in a circular path
            MoveInCircle();

            // Decrease the direction timer
            directionTimer -= Time.deltaTime;

            if (directionTimer <= 0f)
            {
                // Change the direction randomly and reset the direction timer
                currentAngle = Random.Range(0f, 360f);
                directionTimer = Random.Range(changeDirectionTimeMin, changeDirectionTimeMax);

                // Pause the movement for a random amount of time
                isMoving = false;
                pauseTimer = Random.Range(pauseTimeMin, pauseTimeMax);
            }
        }
        else
        {
            // Pause the movement
            pauseTimer -= Time.deltaTime;

            if (pauseTimer <= 0f)
            {
                // Resume moving after the pause time is over
                isMoving = true;
            }
        }
    }

    private void MoveInCircle()
    {
        // Calculate the new position based on the current angle and circle radius
        float x = Mathf.Cos(currentAngle * Mathf.Deg2Rad) * circleRadius;
        float z = Mathf.Sin(currentAngle * Mathf.Deg2Rad) * circleRadius;

        // Set the new position
        transform.position = new Vector3(x, 0f, z);

        // Increment the angle to make the object move in the circle
        currentAngle += speed * Time.deltaTime;
    }
}


    // private void Update()
    // {
    //     // Increment the angle based on the time and speed
    //     currentAngle += speed * Time.deltaTime;

    //     // Calculate the new position on the circle based on the angle and radius
    //     float x = center.x + radius * Mathf.Cos(angle);
    //     float z = center.z + radius * Mathf.Sin(angle);

    //     // Set the object's new position
    //     transform.position = new Vector3(x, transform.position.y, z);
    // }
// }
