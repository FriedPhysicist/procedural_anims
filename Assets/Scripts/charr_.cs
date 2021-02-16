using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charr_ : MonoBehaviour
{
    public Transform spine;
    public Transform camera_pos;
    private float x;
    private float y;
    public float sens;

    void FixedUpdate()
    {
        fps_camera_movement.procedural_anims.spine_move(spine,transform,ref x, ref y,sens,camera_pos); 
    } 
}
