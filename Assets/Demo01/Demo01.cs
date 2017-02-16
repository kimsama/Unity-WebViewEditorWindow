using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo01 : MonoBehaviour
{
    public float speed = 50f;
    	
	void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
