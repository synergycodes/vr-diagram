using UnityEngine;

public class Highlight : MonoBehaviour
{
    FindClosestByTag findClosestByTag;
    GameObject prevClosestGameObject;
    GameObject closestGameObject;
    Outline outline;
    
      void Start()
    {
        findClosestByTag = gameObject.GetComponent<FindClosestByTag>();
    }
    
        public void highlightNearestByTag(string tag)
    {
        closestGameObject = findClosestByTag.find(tag);
        if (prevClosestGameObject != null && closestGameObject.GetInstanceID() != prevClosestGameObject.GetInstanceID()) {
            prevClosestGameObject.GetComponent<Outline>().OutlineWidth = 0;
            closestGameObject.GetComponent<Outline>().OutlineWidth = 5;
        }
        prevClosestGameObject = findClosestByTag.find(tag);    
    }
}
