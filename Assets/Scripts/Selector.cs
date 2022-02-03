using System.Collections;
using UnityEngine;

public class Selector : MonoBehaviour
{

    FindClosestByTag findClosestByTag;
    GameObject prev;
    public GameObject selected;
    void Start()
    {
        findClosestByTag =  gameObject.GetComponent<FindClosestByTag>();
    }

    void Update() {
        if (OVRInput.GetDown(OVRInput.Button.Two) ) {
            selectClosest("Node");
        }
    }

    public void selectClosest(string tag) {

        if (prev){
            prev.gameObject.GetComponent<Outline>().OutlineWidth = 0;
        }

        selected = findClosestByTag.find(tag);

        if (selected) {
            selected.gameObject.GetComponent<Outline>().OutlineWidth = 3;
        }

        prev = selected;
    }
}
