using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariatedRotationY : MonoBehaviour
{
    private Vector3 Axis = new Vector3(0, 1, 0);
    public Transform SatteliteX;
    public Transform SatteliteZ;

    //скорость вращени€ зависит скал€рного произведени€ между векторами-положени€ми объектов на орбитах X и Z.
    private void Update()
    {
        Quaternion deltaVY = Quaternion.Euler(Time.deltaTime*Axis*System.Math.Abs(Vector3.Dot(SatteliteX.position.normalized, SatteliteZ.position.normalized))*90);
        transform.rotation = deltaVY * transform.rotation;
    }
       
}
