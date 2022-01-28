using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FindClosestByTag;

public class Highlighter : MonoBehaviour
{

    FindClosestByTag findClosestByTag;
    ClosestObject closest = new ClosestObject();
    ClosestObject current = new ClosestObject();
    void Start()
    {
        findClosestByTag =  gameObject.GetComponent<FindClosestByTag>();
    }

    void Update() {
        if (Input.GetButtonDown("1")) {
            highlightClosest(new List<string>(){"spawner", "Link", "Node"});
        }
    }

    public void highlightClosest(List<string> tags) {
        if (closest.gameObject){
            closest = findClosestByTag.recalculateClosest(closest);
        }


        foreach(string el in tags)
        {
            current = findClosestByTag.find(el);
            if ((current.distance < closest.distance)) {
                if (closest.gameObject) {
                   closest.gameObject.GetComponent<Outline>().OutlineWidth = 0;
                }
                closest = current;
            }
        }
        if (closest.gameObject) {
            closest.gameObject.GetComponent<Outline>().OutlineWidth = 3;
        }
    }
}
