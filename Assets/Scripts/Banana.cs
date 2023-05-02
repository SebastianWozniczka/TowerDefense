using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Banana : MonoBehaviour
{
    private Vector3 mousePos;

    private float x, y, dv = 50;
    private bool start;

    void Start()
    {
        x=transform.position.x;
        y=transform.position.y;
    }


    void Update()
    { 
            x += 0.005f;
            float s = Mathf.Sin(x) / dv;
            y += s;

            transform.position = new Vector2(x, y);
            transform.Rotate(0, 0, Mathf.Sin(1));   
        }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
