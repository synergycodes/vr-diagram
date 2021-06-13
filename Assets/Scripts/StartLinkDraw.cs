using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLinkDraw : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject handCollider;
    public GameObject linkPrefab;

    private LineRenderer currentLineRenderer;
    private LinkPositionUpdater linkPositionUpdater;
    private FindClosestByTag findClosestByTag;


    private GameObject portTo;
    private GameObject portFrom;


    void Start() {
        findClosestByTag = gameObject.GetComponent<FindClosestByTag>();
    }
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) {

            GameObject link = Instantiate(linkPrefab);
            linkPositionUpdater = link.GetComponent<LinkPositionUpdater>();
            portFrom =findClosestByTag.find("portFrom");
            linkPositionUpdater.portFrom = portFrom;
            linkPositionUpdater.portTo = handCollider;

        }

        if (OVRInput.GetUp(OVRInput.Button.One)) {
            portTo =findClosestByTag.find("portTo");
            Debug.Log(portTo);
            linkPositionUpdater.portTo = portTo;
        }
        
    }

}
