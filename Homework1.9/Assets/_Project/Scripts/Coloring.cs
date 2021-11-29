using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coloring : MonoBehaviour
{
    public Text text;
    void Update()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(300f * float.Parse(text.text) / 50f, 5f);
        GetComponent<RectTransform>().localPosition = new Vector3(300f * float.Parse(text.text) / (50f * 2f)-150f   , 0f, 0f);
    }
}
