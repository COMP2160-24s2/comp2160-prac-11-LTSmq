using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float lerpFactor = 1f;

    void Start()
    {
        if(target)
        {
            gameObject.transform.position = target.transform.position;
        }
    }

    void Update()
    {
        Vector3 myPos = gameObject.transform.position;
        Vector3 targetPos = target.transform.position;
        gameObject.transform.position = Vector3.Lerp(myPos,targetPos,lerpFactor);
    }
}
