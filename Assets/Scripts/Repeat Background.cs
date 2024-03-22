using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Taks position of background devides it by two.
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // when background reaches a certain distance it will reset 
    void Update()
    {
        if (transform.position.x < startPos.x -repeatWidth) 
        {
            transform.position = startPos;
        }
    }
}
