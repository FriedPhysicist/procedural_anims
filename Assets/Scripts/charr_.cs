using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charr_ : MonoBehaviour
{
    public Transform spine;
    public Transform camera_pos;
    Rigidbody rb;
    
    private float x;
    private float y;
    public float sens;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    { 
        rb.MovePosition(rb.position+transform.forward*Input.GetAxis("Vertical")+transform.right*Input.GetAxis("Horizontal"));
        
        fps_camera_movement.procedural_anims.spine_move(spine,transform,ref x, ref y,sens); 
    } 
}
