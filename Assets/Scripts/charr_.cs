using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charr_ : MonoBehaviour
{
    public Transform spine;
    private float x;
    private float y;
    public float sens;
    
    void Start()
    { 
    }

    
    void LateUpdate()
    { 
        fps_camera_movement.procedural_anims.spine_move(spine,transform,ref x, ref y,sens);
        //Debug.Log(x+" "+y);
    }
}
