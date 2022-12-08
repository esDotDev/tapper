using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    
    public Transform target;

    void Update()
    {
        var pos = transform.position;
        pos.y = target.transform.position.y;
        transform.position = pos;
        
    }
}
