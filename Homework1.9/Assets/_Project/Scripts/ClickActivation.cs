using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickActivation : MonoBehaviour
{
    public GameObject Panel;
    public Text[] Texts;
    
    public void OnTap(int button)
    {
        GameObject record = Panel.transform.GetChild(4).gameObject;
        GameObject adsButton = Panel.transform.GetChild(3).gameObject;
        if (button == 0)
        {
            Panel.GetComponent<Image>().color = new Color32(26, 34, 94, 150);
            Texts[0].text = "Stage Complete:"+Texts[3].text;
            Texts[1].text = "Tap to next Level";
            Texts[2].text = "YOU WIN!";
            adsButton.SetActive(false);
            record.SetActive(false);
        }
        else if (button == 1)
        {
            Panel.GetComponent<Image>().color = new Color32(94, 26, 34, 150);
            Texts[0].text = (float.Parse(Texts[4].text) * 100f / 50f).ToString("F0")+ "% of level complete.";
            Texts[1].text = "Tap to try again";
            Texts[2].text = "YOU LOST!";
            adsButton.SetActive(true);
            //когда будет сохранение рекорда - привязать к его взятию.
            if (true) record.SetActive(true);
            //else record.SetActive(false);
            
        }


        Panel.SetActive(true);
        //Debug.Log("Нажали.");
    }
    
}
