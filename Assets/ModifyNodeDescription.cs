using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifyNodeDescription : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject descriptionGameObject;
    private Button button;
    private InputField input;
    private Selector selector;
    void Start()
    {
        button = descriptionGameObject.transform.Find("Button").GetComponent<Button>();
        input = descriptionGameObject.transform.Find("InputField").GetComponent<InputField>();
        selector = gameObject.GetComponent<Selector>();
        input.text = "test";
        button.onClick.AddListener(() => updateNodeDescription());
    }

    // Update is called once per frame
    void updateNodeDescription()
    {
        GameObject selectedNode = selector.selected;
         selectedNode.transform.Find("Description").GetComponent<TextMesh>().text = input.text;
    }
}
