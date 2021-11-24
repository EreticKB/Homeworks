using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 RotationVector;
    void Update()
    {
        transform.Rotate(RotationVector*Time.deltaTime);
    }
}
