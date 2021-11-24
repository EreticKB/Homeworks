using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    float timer;
    TextMesh textObject;
    public GameObject Obj1;
    public GameObject Obj2;

    private void Start()
    {
        textObject = GetComponent<TextMesh>();
        textObject.text = "Wait";
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 1 || Obj1 == null || Obj2 == null) return;
        timer = 0;
        Vector3 distance = Obj1.transform.position - Obj2.transform.position;
        textObject.text = "Distance between " + Obj1.name + " and " + Obj2.name + System.Environment.NewLine + 
            "is (" + distance.x + ", " + distance.y + ", " + distance.z + ")" + System.Environment.NewLine +
            "       with magnitude = " + distance.magnitude;
    }
}
