using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    Highlight highlight;
    // Start is called before the first frame update
    void Start()
    {
        highlight = gameObject.GetComponent<Highlight>();
    }

    // Update is called once per frame
    void Update()
    {
        highlight.highlightNearestByTag("spawner");
        highlight.highlightNearestByTag("Link");
    }
}
