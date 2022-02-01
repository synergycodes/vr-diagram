using UnityEngine;

public class ModifyNodeColor : MonoBehaviour
{
    private Selector selector;
    void Start() {
        selector = gameObject.GetComponent<Selector>();
    }
   public void modify(Color selectedColor) {
            GameObject selectedNode = selector.current.gameObject;
            selectedNode.GetComponent<Renderer>().material = Instantiate(Resources.Load("Material") as Material );
            if (selectedNode) {
            selectedNode.GetComponent<Renderer>().material.color = selectedColor;
            }
    }
        
}
