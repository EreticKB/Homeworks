using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariatedRotationX : MonoBehaviour
{
    private Vector3 Axis = new Vector3(1, 0, 0);
    public Transform SatteliteY;
    public Transform SatteliteZ;

    //�������� �������� ������� �� ������ �������-���������� ���������� ������������ ����� ���������-����������� �������� �� ������� Y � Z.

    private void Update()
    {
        Quaternion deltaVX = Quaternion.Euler(Time.deltaTime * Axis * System.Math.Abs(Vector3.Cross(SatteliteY.position.normalized, SatteliteZ.position.normalized).magnitude) * 90);
        transform.rotation = deltaVX * transform.rotation;
    }
        
}
