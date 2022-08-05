using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math_system : MonoBehaviour
{
    math Questions;
    touch_input Inputs;
    the_q qu;
    // Start is called before the first frame update
    void Awake()
    {
        Questions = new math();
        gameObject.AddComponent<touch_input>();
        gameObject.AddComponent<touch_input>();
        Inputs = GetComponent<touch_input>();
        qu = GetComponent<the_q>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Inputs.enter_pressed)
        {
            Questions.Qu();
            qu.text.text = Questions.question;
        }
    }
}
