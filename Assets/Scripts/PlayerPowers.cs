using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{
    [SerializeField] private float interactionDistance = 10.0f; // The distance within which the player can interact with objects

    // Update is called once per frame
    private void Update()
    {
        // Check if the 'E' key was pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("RAY K");
            // Cast a ray in front of the player
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, interactionDistance);

            // Draw the ray in the Scene view
            Debug.DrawRay(transform.position, transform.right * interactionDistance, Color.red, 10.0f);

            // If the ray hit an object
            if (hit.collider != null)
            {
                // If the object has the tag "Resizable"
                if (hit.collider.gameObject.CompareTag("Resizable"))
                {
                    // Shrink the game object by a factor of 2
                    hit.collider.gameObject.transform.localScale *= 2;
                    Debug.Log("HIT SHRINK");
                }
            }
        }

        // Check if the 'S' key was pressed
        if (Input.GetKeyDown(KeyCode.F))
        {

            Debug.Log("RAY K2");

            // Cast a ray in front of the player
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.forward, interactionDistance);

            // If the ray hit an object
            if (hit.collider != null)
            {
                // If the object has the tag "Resizable"
                if (hit.collider.gameObject.CompareTag("Resizable"))
                {
                    // Shrink the game object by a factor of 2
                    hit.collider.gameObject.transform.localScale /= 2;
                    Debug.Log("HIT LARGE");

                }
            }
        }
    }
}