using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLine : MonoBehaviour
{
    LineRenderer line;
    Vector3[] positions = new Vector3[2];
    public Transform weight; 

    private void Start()
    {
        line = GetComponent<LineRenderer>();

    }
    private void Update()
    {
        positions[0] = transform.position;
        positions[1] = new Vector2(weight.position.x, weight.position.y + 0.65f);
        line.SetPositions(positions);
    }
}
