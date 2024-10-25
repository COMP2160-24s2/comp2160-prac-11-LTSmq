using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float lerpFactor = 1f;
    
    Vector3 lastposition;
    Vector3 delta;
    
    void Start()
    {
        if(target)
        {
            gameObject.transform.position = target.transform.position;
        }
        UpdateLastTransform();
    }


    void UpdateLastTransform()
    {
        delta = transform.position - lastposition; 
        lastposition = transform.position;
    }

    void Update()
    {
        Vector3 myPos = gameObject.transform.position;
        Vector3 targetPos = target.transform.position;
        gameObject.transform.position = Vector3.Lerp(myPos,targetPos,lerpFactor);
    }

    void LateUpdate()
    {
        UpdateLastTransform();
    }

    public bool InMotion(float thresholdSquared =0.0000004f)
    {
        return ((delta).sqrMagnitude>=thresholdSquared);
    }
}
