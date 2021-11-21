using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Rigidbody[] bodylist = new Rigidbody[5];
    System.Random random = new System.Random();
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Explosion will BEGUN!");
        foreach (Rigidbody body in bodylist)
        {
            body.AddRelativeForce(new Vector3(0, 0, -random.Next(50, 200)), ForceMode.Impulse);
        }
    }
}
    