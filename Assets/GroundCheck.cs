using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGrounded;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall") || other.gameObject.CompareTag("enemy"))
        {
            isGrounded = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall") || other.gameObject.CompareTag("enemy"))
        {
            isGrounded = false;
        }
    }
}