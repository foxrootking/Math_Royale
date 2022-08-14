using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_data : MonoBehaviour
{
    public Timer team;
    public static float time;
    public static int Lv_m,Lv_d,Lv_s;
    [SerializeField] bool object_needed = false;
    
    
    void Awake()
    {
        if (object_needed)
        {
            team.timeRemaining = time;
        }
    }

}
