using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariatedRotationZ : MonoBehaviour
{
    private Vector3 Axis = new Vector3(0, 0, 1);
    public Transform SatteliteY;
    public Transform SatteliteX;
    
    //�������� �������� ������� �� ����� ��������-��������� �������� �� ������� Y � X � ���������� ����� ����.
    private void Update()
    {
        Quaternion deltaVZ = Quaternion.Euler(Time.deltaTime*Axis*(SatteliteX.position+SatteliteY.position).magnitude*30);
        transform.rotation = deltaVZ * transform.rotation;
    }
}
