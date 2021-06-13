using UnityEngine;

public class HandlePositionChange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject portFrom;
    public GameObject portTo;
    private LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
