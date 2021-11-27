using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityControl : MonoBehaviour
{
    public GameObject[] UIObject;
    public AddingPlatformsCount addplatformcount;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gameObject in UIObject)
        {
            gameObject.SetActive(false);
        }
        addplatformcount.counter = 0;
    }
}
