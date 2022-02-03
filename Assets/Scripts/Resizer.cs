using System;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    Selector selector;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        selector = gameObject.GetComponent<Selector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger)) {
            if (selector.current.gameObject) {
            float distance  = calculateDistance();
            selector.current.gameObject.GetComponent<Transform>().localScale =  new Vector3(distance,distance,distance);
        }
        }
    }

    private float calculateDistance() {
        Vector3 diff = selector.current.gameObject.transform.position - hand.transform.position;
        return Math.Min(diff.sqrMagnitude * 3, 1.15f) ;
    }
}
