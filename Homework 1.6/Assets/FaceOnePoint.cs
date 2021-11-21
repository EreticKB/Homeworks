using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceOnePoint : MonoBehaviour
{
    public Transform Target;
    private void Awake()
    {
        transform.LookAt(Target);
    }
}
