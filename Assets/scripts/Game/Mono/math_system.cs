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
    public static int lv_m, lv_d,lv_s;
    
    void Start()
    {
        //texts.field.text = Lv_divide.ToString();
        Questions = new math();
        Score_class = new Score_Class();
        lv_d = Custom_data.Lv_d;
        lv_s = Custom_data.Lv_s;
        lv_m = Custom_data.Lv_m;
        Questions.Qu(lv_m,lv_d,lv_s);
        
    }


    void Update()
    {
        Play();
        Debug.Log(lv_s);
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
                Questions.Qu(lv_m,lv_d,lv_s);
            }
            else
            {
                Score_class.Score_change(-20);
                Score_points.score = Score_class.Score_reveal();
                Retry_Return.Score = Score_points.score;
                Questions.Qu(lv_m,lv_d,lv_s);
            }


        }


    }

}
