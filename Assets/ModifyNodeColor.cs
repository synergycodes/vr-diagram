using UnityEngine;

public class ModifyNodeColor : MonoBehaviour
{
    private Selector selector;
    void Start() {
        selector = gameObject.GetComponent<Selector>();
    }
   public void modify(Color selectedColor) {
            GameObject selectedNode = selector.current.gameObject;

            if (selectedNode) {
            selectedNode.GetComponent<Renderer>().material.color = selectedColor;
            }
    }
        
}
