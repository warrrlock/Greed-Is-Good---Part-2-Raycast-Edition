using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTrigger : MonoBehaviour
{
    public GameObject title_cue;

    public AudioSource Sounds;
    public AudioClip Title_hit;

    private void Start()
    {
        title_cue.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            title_cue.SetActive(true);
            Sounds.PlayOneShot(Title_hit);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            title_cue.SetActive(false);
        }
    }


}
