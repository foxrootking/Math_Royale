using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_finished : MonoBehaviour
{
    public Timer timer;
    public GameObject theObject;
    public bool Object_needed;


    private void Update()
    {
        if (timer.Time_finished && Object_needed)
        {
            gameObject.SetActive(false);
            theObject.SetActive(true);
        }
        else if (timer.Time_finished && Object_needed == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
