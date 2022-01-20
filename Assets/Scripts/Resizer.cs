using System;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    FindClosestByTag findClosestByTag;
    private GameObject catchedGameObject;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        findClosestByTag = gameObject.GetComponent<FindClosestByTag>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger)) {
            catchedGameObject = findClosestByTag.find("Node");
            // float distance = Convert.ToSingle(Math.Pow(calculateDistance(), 1));
            float distance  = calculateDistance();
            catchedGameObject.GetComponent<Transform>().localScale =  new Vector3(distance,distance,distance);
        }
    }

    private float calculateDistance() {
        Vector3 diff = catchedGameObject.transform.position - hand.transform.position;
        return diff.sqrMagnitude;
    }
}
