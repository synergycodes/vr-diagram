using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePalette : MonoBehaviour
{

    public GameObject nodeSpawnerPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < Palette.colors.Length ; i++) {

                GameObject paletteNode = Instantiate(nodeSpawnerPrefab, new Vector3(0, 1 + i/3f, -1 ), Quaternion.identity);
                Color myColor = new Color();
                ColorUtility.TryParseHtmlString (Palette.colors[i], out myColor);
                paletteNode.GetComponent<Renderer>().material.color = myColor;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
