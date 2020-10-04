using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public static bool ButtonTurnOn = false;

    public void OnTriggerStay2D(Collider2D other)
    {
        ButtonTurnOn = true;
        Debug.Log("on the butt");
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        ButtonTurnOn = false;
        Debug.Log("off the butt");
    }

}
