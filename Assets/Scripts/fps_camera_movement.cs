using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;


public class fps_camera_movement : MonoBehaviour
{ 
    public class procedural_anims
    {
        public static void spine_move(Transform spine,Transform main_transform,ref float x,ref float y,float sens)
        { 
            x += Input.GetAxis("Mouse X"); 
            y += Input.GetAxis("Mouse Y");
            Vector3 look_root= new Vector3(spine.position.x,main_transform.position.y,spine.position.z+8f);
        
            main_transform.LookAt(new Vector3(spine.TransformVector(look_root).x,main_transform.position.y,spine.TransformVector(look_root).z)); 
            y=Mathf.Clamp(y, -30, 50); 
            spine.rotation = Quaternion.Euler(-y, x, 0);
        }
    }
} 