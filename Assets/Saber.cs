using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;

    private ScoreManager scoreManager; // Reference to the ScoreManager script

    void Start()
    {
        // Initialize previousPos to the current position of the saber
        previousPos = transform.position;

        // Find the ScoreManager script in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            // Calculate the angle between the direction of movement and the normal vector of the object's surface
            float angle = Vector3.Angle(transform.position -previousPos, hit.transform.up);
            if (angle > 130)
            {
                // Destroy the object if the angle is greater than 130 degrees
                Destroy(hit.transform.gameObject);

                // Increment the score
                scoreManager.OnSliceCube();
            }
        }

        // Update previousPos to the current position of the saber
        previousPos = transform.position;
    }
}

