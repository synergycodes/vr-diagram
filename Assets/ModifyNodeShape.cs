using UnityEngine;

public class ModifyNodeShape : MonoBehaviour
{

    private Selector selector;
    void Start() {
        selector = gameObject.GetComponent<Selector>();
    }
   public void modify(Mesh mesh) {
            GameObject selectedNode = selector.selected;

            if (selectedNode) {
            selectedNode.GetComponent<MeshFilter>().mesh = mesh;
            }
    }
        
}
