using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class texts : MonoBehaviour
{
    public static TMP_Text field;
    
    private void Awake()
    {
        field = GetComponent<TMP_Text>();
    }
}
