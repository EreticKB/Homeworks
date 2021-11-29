using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityControl : MonoBehaviour
{
    public GameObject[] UIObject;
   
    void Start()
    {
        foreach (GameObject gameObject in UIObject)
        {
            gameObject.SetActive(false);
        }
        
    }
}
