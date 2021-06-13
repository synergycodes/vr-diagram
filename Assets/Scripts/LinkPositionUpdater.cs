using UnityEngine;

public class LinkPositionUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject portFrom;
    public GameObject portTo;

    public string test;
    private LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 startPoint = portTo.transform.position;
            Vector3 endPoint = portFrom.transform.position;
            Vector3[] points = {startPoint,endPoint};
            lineRenderer.SetPositions(points);

        
        
    }
}
