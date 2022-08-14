using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Custom_input : MonoBehaviour
{

    TMP_InputField Tmp;
    float input;

    void Awake()
    {
        Tmp = GetComponent<TMP_InputField>();
    }


    public float Run_input()
    {
        input = float.Parse(Tmp.text);
        Debug.Log(input);
        return input;
    }
}
