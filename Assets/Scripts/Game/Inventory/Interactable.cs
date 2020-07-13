using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Radious of Interaction with object
    public float radius = 3f;
    Transform player;

    // Draw a circle (radius of a object)


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interact();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void Interact ()
    {
        // This method is meant to be overwritten
        Debug.Log("Interacted");
    }

}
