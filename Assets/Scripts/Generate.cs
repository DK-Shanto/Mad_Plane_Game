﻿using UnityEngine;

public class Generate : MonoBehaviour {

    public GameObject rocks;
    int score = 0;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("createObstacles", 1f, 1.5f);
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());

    }

    void createObstacles()
    {
        Instantiate(rocks);
        score++;
    }
}
