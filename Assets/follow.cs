using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] Transform target;

    Vector3 targetPos;

    float ratio;
    float antiRatio;

    private void Start()
    {
        ratio = 0.1f;
        antiRatio = 1 - ratio;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPos = target.position + Vector3.forward * -10;

        transform.position = targetPos * ratio + transform.position * antiRatio;
    }
}
