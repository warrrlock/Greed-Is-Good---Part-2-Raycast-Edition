using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
    public static bool PlayerCollect;
    public AudioSource Sounds;
    public AudioClip CoinCollect;

    void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerCollect = true;
            ScoreScript.playerScore += 1;
            Sounds.PlayOneShot(CoinCollect);
            gameObject.SetActive(false);
        }

    }
}
