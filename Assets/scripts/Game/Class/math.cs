using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math
{

    int random1, random2,index,divide_Ans;
    public string answer;
    public string question;
    List<string> random = new List<string>();
    bool added_mul = false,added_math = false,added_div = false;
    
    
    public void Qu(int Multiply,int Divide,int simplemath)
    {

        Multiply = Mathf.Clamp(Multiply, 0, 4);
        Divide = Mathf.Clamp(Divide, 0, 4);
        simplemath = Mathf.Clamp(simplemath, 0, 4);

        if (Multiply > 0 && added_mul == false)
        {
            random.Add("multiply");
            added_mul = true;
        }
        if (Divide > 0 && added_div == false)
        {
            random.Add("divide");
            added_div = true;
        }
        if (simplemath > 0 && added_math == false)
        {
            random.Add("simplemath");
            added_math = true;
        }

        index = random.Count;
        
        int ranf = Random.Range(0, index);
        string ki = random[ranf];
        Debug.Log(ki);
        switch (ki)
        {
            case "multiply":
                switch (Multiply)
                {
                    case 1:
                        random1 = Random.Range(0, 10);
                        random2 = Random.Range(0, 10);
                        answer = (random1 * random2).ToString();
                        question = random1 + " x " + random2;
                        break;
                    case 2:
                        random1 = Random.Range(-10, 10);
                        random2 = Random.Range(-10, 10);
                        answer = (random1 * random2).ToString();
                        question = random1 + " x " + random2;
                        break;
                    case 3:
                        random1 = Random.Range(-20, 20);
                        random2 = Random.Range(-20, 20);
                        answer = (random1 * random2).ToString();
                        question = random1 + " x " + random2;
                        break;
                    case 4:
                        random1 = Random.Range(-25, 25);
                        random2 = Random.Range(-25, 25);
                        answer = (random1 * random2).ToString();
                        question = random1 + " x " + random2;
                        break;
                    default:
                        break;
                }
                break;


            case "divide":
                switch (Divide)
                {
                    case 1:
                        random1 = Random.Range(0, 10);
                        random2 = Random.Range(0, 10);
                        divide_Ans = random2 * random1;
                        answer = (divide_Ans / random2).ToString();
                        Debug.Log(answer);
                        question = divide_Ans + " % " + random2;
                        break;
                    case 2:
                        random1 = Random.Range(-10, 10);
                        random2 = Random.Range(-10, 10);
                        divide_Ans = random2 * random1;
                        answer = (divide_Ans / random2).ToString();
                        Debug.Log(answer);
                        question = divide_Ans + " % " + random2;
                        break;
                    case 3:
                        random1 = Random.Range(-15, 15);
                        random2 = Random.Range(-15, 15);
                        divide_Ans = random2 * random1;
                        answer = (divide_Ans / random2).ToString();
                        Debug.Log(answer);
                        question = divide_Ans + " % " + random2;
                        break;
                    case 4:
                        random1 = Random.Range(-25, 25);
                        random2 = Random.Range(-25, 25);
                        divide_Ans = random2 * random1;
                        answer = (divide_Ans / random2).ToString();
                        Debug.Log(answer);
                        question = divide_Ans + " % " + random2;
                        break;
                    default:
                        break;
                }
                break;


            case "simplemath":
                switch (simplemath)
                {
                    case 1:
                        random1 = Random.Range(0, 10);
                        random2 = Random.Range(-10, 10);
                        answer = (random1 + random2).ToString();
                        question = random1 + " + " + random2;
                        break;
                    case 2:
                        random1 = Random.Range(0, 20);
                        random2 = Random.Range(-20, 20);
                        answer = (random1 + random2).ToString();
                        question = random1 + " + " + random2;
                        break;
                    case 3:
                        random1 = Random.Range(-10, 30);
                        random2 = Random.Range(-30, 30);
                        answer = (random1 + random2).ToString();
                        question = random1 + " + " + random2;
                        break;
                    case 4:
                        random1 = Random.Range(-50, 50);
                        random2 = Random.Range(-50, 50);
                        answer = (random1 + random2).ToString();
                        question = random1 + " + " + random2;
                        break;
                    default:
                        break;
                }
                break;
        }


    }

}
