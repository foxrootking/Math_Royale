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
    int[] focal_sector = {9,10,11};
    int focal_sector_indexer = 0;
    int n = 0;
    int sub_val = 0;

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

                if (n == 4)
                {
                    focal_sector_indexer++;
                }
                
                if (n == 8)
                {
                    focal_sector_indexer++;
                }

                focal_sector_indexer = Mathf.Clamp(focal_sector_indexer,0,2);

                (spawnedTile.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>()).text = $"{chars_index[focal_sector[focal_sector_indexer] + sub_val]}";

                sub_val -= 3;

                if (sub_val < -9)
                {
                    sub_val = 0;
                }
                
                (spawnedTile.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>()).fontSize = 200;
                n++;
            }
        }
    }
}
