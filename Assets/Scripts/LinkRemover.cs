using UnityEngine;

public class LinkRemover : MonoBehaviour
{

    FindClosestByTag findClosestByTag;
    // Start is called before the first frame update
    void Start()
    {
        findClosestByTag = gameObject.GetComponent<FindClosestByTag>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B)) {
            Destroy(findClosestByTag.find("Link"));
        }
    }
}
