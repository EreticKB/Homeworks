using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingPlatformsCount : MonoBehaviour
{
    public UnityEngine.UI.Text[] Text;
    private int counter;
    
    

    public void AddCounter()
    {
        if (Text[0].text.Equals("0")) counter = 0;
        counter++;
        Text[0].text = counter.ToString();
        if (counter >= 50) GetComponent<ClickActivation>().OnTap(0);
    }
}
