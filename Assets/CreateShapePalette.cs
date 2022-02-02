using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateShapePalette : MonoBehaviour
{
    public GameObject shapePrefab;
    public Sprite[] sprites;
    public Mesh[] meshes;
    private GameObject shapePalette;
    private ModifyNodeShape modifyNodeShape;
    // Start is called before the first frame update
    void Start()
    {
        shapePalette = GameObject.Find("Shape Palette");
        modifyNodeShape = gameObject.GetComponent<ModifyNodeShape>();
        for (int i = 0 ; i < meshes.Length ; i++) {
            GameObject shape = Instantiate(shapePrefab, shapePalette.transform);
            shape.GetComponent<Image>().sprite = sprites[i];
            shape.transform.localPosition = new Vector3(i*120, 0, 0);
            Mesh mesh = meshes[i];
            shape.GetComponent<Button>().onClick.AddListener(() => modifyNodeShape.modify(mesh) );
    }

    }

}
