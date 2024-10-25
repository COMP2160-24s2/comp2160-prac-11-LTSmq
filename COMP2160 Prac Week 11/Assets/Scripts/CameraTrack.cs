using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    [SerializeField] private GameObject target;
    

    void Update()
    {
        if(target)
        {
            transform.LookAt(target.transform.position, Vector3.up);
        }
    }
}
