﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int playerScore = 0;
    public static int playerHealth = 0;
     Text score;
     Text health;
    void Start()
    {
        score = GetComponent<Text>();
        health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Tokens: " + playerScore;
        //health.text = "Health:" + playerHealth;
    }
}
