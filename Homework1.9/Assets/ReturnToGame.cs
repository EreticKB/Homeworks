using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToGame : MonoBehaviour
{
   public Text[] Texts;
   public void OnTap()
    {        
        if (Texts[0].text.Equals("50"))
        {
            Texts[1].text = Texts[2].text;
            Texts[2].text = (int.Parse(Texts[2].text) + 1).ToString();
        }
        Texts[0].text = "0";
    }
}
