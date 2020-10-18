using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroneActivate : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip Chair_win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("In Chair");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Play Win Sound");
                PlayerMove.playerSit = true;
                ThroneFuncs.ChairChange = true;
                Sounds.PlayOneShot(Chair_win);
            }
        }
    }

}
