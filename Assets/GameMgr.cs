using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameMgr : MonoBehaviour
{
    public GameObject scoreText;
    public static float playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            ScoreScript.playerScore = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ScoreScript.playerScore = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ScoreScript.playerScore = 5;
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            ScoreScript.playerScore = 9;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ScoreScript.playerScore = 11;
        }
    }
}
