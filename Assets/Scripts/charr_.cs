using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class charr_ : MonoBehaviour
{

    public Transform spine;
    public Transform look_object;
    private float yu=0;
    private float xu = 0; 
    
    void Update()
    {
        spine_move(spine,transform,ref xu,ref yu);
    }

    void spine_move(Transform spine,Transform main_transform,ref float x,ref float y)
    { 
        x += Input.GetAxis("Mouse X"); 
        y += Input.GetAxis("Mouse Y"); 
        
        main_transform.LookAt(new Vector3(spine.position.x,transform.position.y,spine.position.z+3));
        y=Mathf.Clamp(y, -30, 50); 
        spine.rotation = Quaternion.Euler(y, x, 0);
    }
} 