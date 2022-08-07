using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyGrid : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] GameObject button;
    [SerializeField] GameObject ActiveObject;
    [SerializeField] int spawnOffsetX;
    [SerializeField] int spawnOffsetY;

    public GameObject GenController;

    string[] chars_index = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "0", "="};
    int n = 0;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++) //Loops over width
        {
            for (int y = 0; y < height; y++) //Loops over height
            {
                var spawnedTile = Instantiate(button,new Vector3(x * 290 + spawnOffsetX,y * 230 + spawnOffsetY), Quaternion.identity);
                spawnedTile.transform.SetParent(GenController.transform);

                (spawnedTile.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>()).text = $"{chars_index[n]}";
                (spawnedTile.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>()).fontSize = 200;
                n++;
            }
        }
    }
}
