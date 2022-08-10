using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class math_system : MonoBehaviour
{
    math Questions;
    Score_Class Score_class;
    [SerializeField] touch_input Inputs;
    [SerializeField] the_q qu;
    [SerializeField] Score_system Score_points;
    [SerializeField] Timer time;
    [SerializeField] GameObject Object;
    [SerializeField] Retry_Return score;
    void Start()
    {
        Questions = new math();
        Score_class = new Score_Class();
        Questions.Qu();
    }


    void Update()
    {
        Play();
    }




    private void Play()
    {
        qu.Answer = Questions.question;
        
        if (Inputs.enter_pressed)
        {


            if (Questions.answer == Inputs.answer)
            {
                Score_class.Score_change(20);
                Score_points.score = Score_class.Score_reveal();
                Retry_Return.Score = Score_points.score;
                Questions.Qu();
            }
            else
            {
                Score_class.Score_change(-20);
                Score_points.score = Score_class.Score_reveal();
                Retry_Return.Score = Score_points.score;
                Questions.Qu();
            }


        }


    }

}
