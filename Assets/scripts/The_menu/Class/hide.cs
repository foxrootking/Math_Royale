using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{

    void Awake()
    {
        GameObject.Find("Page_Play").SetActive(false);
        GameObject.Find("Page_settings").SetActive(false);
    }

}
