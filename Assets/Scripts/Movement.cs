using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rBody, movement;
    public float tumble = 2000;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.angularVelocity = Random.value * tumble;
    }
}

