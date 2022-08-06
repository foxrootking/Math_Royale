using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class the_q : MonoBehaviour
{
    TMP_Text text;
    public string Answer;
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        text.text = Answer;
    }
}
