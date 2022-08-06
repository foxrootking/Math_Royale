using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_system : MonoBehaviour
{
    TMP_Text text;
    public int score = 0;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }


    void Update()
    {
        text.text = score.ToString();
    }
}
