using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math
{

    int random1, random2;
    public int answer;
    public string question;
    public void Qu()
    {
        random1 = Random.Range(-50, 50);
        random2 = Random.Range(-50, 50);
        answer = random1 + random2;
        question = random1+""+random2;
        Debug.Log(question);
    }

}
