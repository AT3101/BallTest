using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed=20f;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=Vector3.right * 5f;
    }

    void Update()
    {
                //マウスでの操作で動かす
       if(Input.GetMouseButtonDown(0)) 
       {
        /*rb.AddForce(
            Vector3.up*20f,
            ForceMode.Impulse);*/
                      //Impulse,Acceleration
        rb.velocity=Vector3.up*speed;
       }
       else if(Input.GetMouseButtonDown(1))
       {
        rb.velocity=Vector3.up*speed;
       }
    }
}

/*
            Vector3.up*200f,
            ForceMode.Acceleration);
*/