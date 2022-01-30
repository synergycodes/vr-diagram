using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToggleUI : MonoBehaviour
{
    private GameObject UI;
    private bool isVisible;

    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UI");
        isVisible = UI.transform.localScale.x != 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start)) {
            if (isVisible) {
                UI.transform.localScale = new Vector3(0,0,0);
            } else {
                UI.transform.localScale = new Vector3(1,1,1);
            }
            isVisible = !isVisible;
        }
        
    }
}
