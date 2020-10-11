using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public static bool nearDoor = false;
    public float DoorDetectDist = 2f;
    public LayerMask doorMask;
    public float RayOffset = 0.5f;

    public AudioSource Sounds;
    public AudioClip DoorOpening;

    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && ButtonScript.ButtonTurnOn == true && nearDoor == true)
        {      
            Sounds.PlayOneShot(DoorOpening);
             Vector3 newPosition = new Vector3(transform.position.x, -10f, transform.position.z);
             transform.position = newPosition;
             Debug.Log("Open door");          
        }

        //DoorDetect
        Ray2D DoorDetectRay = new Ray2D(transform.position + transform.up * RayOffset, transform.right); //create ray

        Debug.DrawRay(DoorDetectRay.origin, DoorDetectRay.direction * DoorDetectDist, Color.white); //showing ray line debug

        RaycastHit2D doorHit = Physics2D.Raycast(DoorDetectRay.origin, DoorDetectRay.direction, DoorDetectDist, doorMask); //naming whatever the ray hits.

        if (doorHit.collider != null && doorHit.collider.gameObject.CompareTag("Player")) //if its hitting something and that something is tagged "door"
        {
            Debug.Log("Door in range");
            nearDoor = true;
        }
        else {
            nearDoor = false;
            Debug.Log("No Door");
        }
      

    }
}
