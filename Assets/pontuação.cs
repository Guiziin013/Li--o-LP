using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text textScore;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        textScore.text = "Pontos: " + score;
    }
}