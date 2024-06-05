using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockStics : MonoBehaviour
{
    public float rotationSpeed = 10f;
    
    void Update()
    {
        transform.rotation = new Quaternion(0, rotationSpeed * Time.deltaTime, 0, 0);
    }
}
