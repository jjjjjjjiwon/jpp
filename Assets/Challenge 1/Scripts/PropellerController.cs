using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    
    public float rotationSpeed = 1000.0f;

    void Update()
    {
         transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
