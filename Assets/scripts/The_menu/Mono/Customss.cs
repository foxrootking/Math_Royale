using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Customss : MonoBehaviour
{
    
    
    public static int timer,Lv_simplemath = 0,Lv_divide = 0,Lv_multiply = 0;
    public Custom_input input;


    public void Time()
    {
        Custom_data.time = input.Run_input();
    }

    public void Lv_simple()
    {
        Lv_simplemath +=1;
        Lv_simplemath = Mathf.Clamp(Lv_simplemath,0,4);
        texts_simple.field.text = Lv_simplemath.ToString();
        print(Lv_simplemath);
    }
    public void _Lv_simple()
    {
        Lv_simplemath -= 1;
        Lv_simplemath = Mathf.Clamp(Lv_simplemath,0 ,4);
        texts_simple.field.text = Lv_simplemath.ToString();
    }
    public void Lv_div()
    {
        Lv_divide += 1;
        Lv_divide = Mathf.Clamp(Lv_divide, 0, 4);
        texts_divide.field.text = Lv_divide.ToString();

    }
    public void _Lv_div()
    {
        Lv_divide -= 1;
        Lv_divide = Mathf.Clamp(Lv_divide, 0, 4);
        texts_divide.field.text = Lv_divide.ToString();
    }
    public void Lv_mul()
    {
        Lv_multiply += 1;
        Lv_multiply = Mathf.Clamp(Lv_multiply, 0, 4);
        texts.field.text = Lv_multiply.ToString();
    }
    public void _Lv_mul()
    {
        Lv_multiply -= 1;
        Lv_multiply = Mathf.Clamp(Lv_multiply, 0, 4);
        texts.field.text = Lv_multiply.ToString();

    }

    public void play()
    {
        Custom_data.Lv_d = 1;
        Custom_data.Lv_m = 1;
        Custom_data.Lv_s = 2;
        Custom_data.time = 60;
    }

    public void confirm()
    {
        Time();
        Custom_data.Lv_d = Lv_divide;
        Custom_data.Lv_s = Lv_simplemath;
        Custom_data.Lv_m = Lv_multiply;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
