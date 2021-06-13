using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePalette : MonoBehaviour
{

    public GameObject nodeSpawnerPrefab; 
     private string[] colors = {"#FF0000", "#00FF00", "#0000FF", "#FFFF00", "#FF00FF", "#00FFFF"};

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < colors.Length ; i++) {

                GameObject paletteNode = Instantiate(nodeSpawnerPrefab, new Vector3(-3, 1 + i/3f, -1 ), Quaternion.identity);
                Color myColor = new Color();
                ColorUtility.TryParseHtmlString (colors[i], out myColor);

                paletteNode.GetComponent<Renderer>().material.color = myColor;

            
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
