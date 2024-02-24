using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float moveSpeed = 5f;
    public string axis = "Vertical";
    void Start()
    {
        
    }

    void Update()
    {
        float ver = Input.GetAxis(axis);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0,ver)*moveSpeed;
    }
}
