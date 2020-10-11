using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
    public float DetectionDistance = 2f;
    public float enemMS = 4f;
    public LayerMask mask;
    public float EnemRayOffset = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Ray2D enemRay = new Ray2D(transform.position + transform.up * EnemRayOffset, transform.right);

        Debug.DrawRay(enemRay.origin, enemRay.direction * DetectionDistance, Color.white);

        RaycastHit2D wallHit = Physics2D.Raycast(enemRay.origin, enemRay.direction, DetectionDistance, mask);

        if (wallHit.collider != null && wallHit.collider.gameObject.CompareTag("wall"))
        {
            int randomNum = Random.Range(0, 100);
            if (randomNum < 50)
            {
                transform.Rotate(new Vector3(0, 180, 0));
            }

            if (randomNum > 50)
            {
                transform.Rotate(new Vector3(0, -180, 0));
            }
        }

        if (wallHit.collider != null && wallHit.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("player contact");
            PlayerMove.playerHit = true;
            int randomNum = Random.Range(0, 100);
            if (randomNum < 50)
            {
               // transform.Rotate(new Vector3(0, 180, 0));
            }

            if (randomNum > 50)
            {
               // transform.Rotate(new Vector3(0, -180, 0));
            }
        }
        else
        {
            transform.Translate(Time.deltaTime * enemMS, 0, 0);
        }
    }
}
