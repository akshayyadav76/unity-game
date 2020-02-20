using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [SerializeField]
Vector3 v3;

[SerializeField]
KeyCode keyPositive;

[SerializeField]
KeyCode keNagativ;

    // Update is called once per frame
    void FixedUpdate()
    { 
        if(Input.GetKey(keyPositive))
    GetComponent<Rigidbody>().velocity +=  v3;

     if(Input.GetKey(keNagativ))
    GetComponent<Rigidbody>().velocity -=  v3;
        
    }
}
