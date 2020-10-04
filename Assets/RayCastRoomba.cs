using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RayCastRoomba : MonoBehaviour
{

    public float roombaDetectionDist = 2f;
    public float roombaSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //defining (init) ray.
        //vector3.up = the world's up position
        //transform.up is y relative to object.
        Ray2D roombaRay = new Ray2D(transform.position, transform.up);

        //step 2: define max dist:

        //step 3: draw debug

        Debug.DrawRay(roombaRay.origin, roombaRay.direction * roombaDetectionDist, Color.white);

        //step 4: shoot the ray!
        if (Physics2D.Raycast(roombaRay.origin, roombaRay.direction, roombaDetectionDist)) //if cast hits something
        {

            int randomNum = Random.Range(0, 100); //choose random num

                if (randomNum < 50) //if less 50
                {
                    transform.Rotate(new Vector3(0, 0, 90)); //turn 90
                }

                if (randomNum > 50) //if moore than 50
                {
                    transform.Rotate(new Vector3(0, 0, -90)); //turn 90
                }
        }
        else 
        { //keepmoving
            transform.Translate(0, Time.deltaTime * roombaSpeed, 0);
        }

    }


}
