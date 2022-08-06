using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Class
{
    int score;

    public void Score_reseter()
    {
        score = 0;
    }

    public void Score_change(int number)
    {
        score = Mathf.Clamp(score + number, 0, 10000000);
    }

    public int Score_reveal()
    {
        return score;
    }

}
