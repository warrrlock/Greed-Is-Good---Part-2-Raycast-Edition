using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public static SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 15f;
    public float speed = 1f;
    public float knockforce = 5;

    private float hurtCount;

    public static bool playerHit = false;
    public static bool playerSit = false;
    public float gravityInAir;

    public GroundCheck groundCheckScript; //non blue letter = naming that public.

    public AudioSource Sounds;
    public AudioClip Hurt;
    public AudioClip Hurt_1;
    public AudioClip Hurt_Impact;
    public AudioClip Jump;

    void Update()
    {
        if (GroundCheck.isGrounded == true && playerHit == false && playerSit == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
                Sounds.PlayOneShot(Jump);

            }
            thisRigidbody2D.gravityScale = 1;
        }

        if (GroundCheck.isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }

        if (Input.GetKey(KeyCode.D) && playerHit == false && playerSit == false)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);


            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.A) && playerHit == false && playerSit == false)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);

            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (playerHit == true)
        {
            hurtCount += 1;

            Sounds.PlayOneShot(Hurt);
            Sounds.PlayOneShot(Hurt_Impact);

            if (gameObject.GetComponent<SpriteRenderer>().flipX == false)
            {
                thisRigidbody2D.AddForce(Vector2.up * knockforce, ForceMode2D.Impulse);
                thisRigidbody2D.AddForce(Vector2.right * -knockforce, ForceMode2D.Impulse);
            }
            if (gameObject.GetComponent<SpriteRenderer>().flipX == true)
            {
                thisRigidbody2D.AddForce(Vector2.up * knockforce, ForceMode2D.Impulse);
                thisRigidbody2D.AddForce(Vector2.right * knockforce, ForceMode2D.Impulse);
            }

            Debug.Log("hurt");
        }

        if (hurtCount >= 3) {
            playerHit = false;
            hurtCount = 0;
            Debug.Log("not hurt");
            Debug.Log(" " + hurtCount);
        }

        if (playerSit == true) {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    /*void FixedUpdate()
     {
         if (Input.GetKey(KeyCode.D))
         {

             thisRigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);

             if (thisSprite.flipX == true)
             {
                 thisSprite.flipX = false;
             }
         }

         if (Input.GetKey(KeyCode.A))
         {

             thisRigidbody2D.AddForce(Vector2.left * force * Time.fixedDeltaTime, ForceMode2D.Impulse);

             if (thisSprite.flipX == false)
             {
                 thisSprite.flipX = true;
             }
         }
     }*/
}