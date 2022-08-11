using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class touch_input : MonoBehaviour
{
    public TMP_InputField inpF;
    public string answer;
    public bool enter_pressed = false;
    public void Awake()
    {
        inpF = GetComponent<TMP_InputField>();
    }


    private void Update()
    {
        OnValChanged();
    }


    public void OnValChanged()
    {

        if (inpF.text.EndsWith("\n"))
        {
            inpF.text = inpF.text.Remove(inpF.text.Length - 1);
            answer = inpF.text;
            inpF.text = "";
            enter_pressed = true;
        }
        else
        {
            enter_pressed=false;
        }

    }
}
