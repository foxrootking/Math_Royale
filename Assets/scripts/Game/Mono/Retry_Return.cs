using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Retry_Return : MonoBehaviour
{
    public static int Score;
    TMP_Text text;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        text.text = "Your score is " + Score + "\n Wanna try again?";
    }
}
