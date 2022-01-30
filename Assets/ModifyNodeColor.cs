using UnityEngine;
using UnityEngine.UI;

public class ModifyNodeColor : MonoBehaviour
{
    private Selector selector;
    void Start() {
        selector = gameObject.GetComponent<Selector>();
    }
   public void modify(GameObject colorObject, Color selectedColor) {
            GameObject selectedNode = selector.current.gameObject;

            if (selectedNode) {
            selectedNode.GetComponent<Renderer>().material.color = selectedColor;
            }
    }
        
}
