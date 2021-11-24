using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariatedRotationZ : MonoBehaviour
{
    private Vector3 Axis = new Vector3(0, 0, 1);
    public Transform SatteliteY;
    public Transform SatteliteX;
    
    //скорость вращения зависит от суммы векторов-положений объектов на орбитах Y и X и расстояния между ними.
    private void Update()
    {
        Quaternion deltaVZ = Quaternion.Euler(Time.deltaTime*Axis*(SatteliteX.position+SatteliteY.position).magnitude*30);
        transform.rotation = deltaVZ * transform.rotation;
    }
}
