using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class RayCastPaint : MonoBehaviour
{
    public GameObject brush;
    public GameObject stamp;

    public float maxRaycastDist; 

    private void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition); //gets ray wherever your mouse is.

        RaycastHit2D mouseHit = Physics2D.Raycast(camRay.origin, camRay.direction, maxRaycastDist); 

        if (mouseHit.collider != null) {
            brush.SetActive(true);

            brush.transform.position = mouseHit.point; //picking a point on the screen where the ray will hit.


        }

        if (Input.GetMouseButton(0)) {

            GameObject thisStamp = Instantiate(stamp, mouseHit.point, Quaternion.identity);
            thisStamp.transform.SetParent(mouseHit.transform, true);
        }

    }
}
