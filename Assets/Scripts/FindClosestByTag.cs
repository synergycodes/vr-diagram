using UnityEngine;


public class ClosestObject {
        public float distance = float.MaxValue;
        public GameObject gameObject;

        public void setData(float d, GameObject gO) {
            distance = d;
            gameObject = gO;
        }

    }
public class FindClosestByTag : MonoBehaviour
{

    public GameObject objectToCalculatedistanceFrom;

    // Start is called before the first frame update
    public GameObject find(string tag)
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(tag);
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = objectToCalculatedistanceFrom.transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

}
