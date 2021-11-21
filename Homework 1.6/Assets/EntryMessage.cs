using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryMessage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cylinder broke through the door.");
    }
}
