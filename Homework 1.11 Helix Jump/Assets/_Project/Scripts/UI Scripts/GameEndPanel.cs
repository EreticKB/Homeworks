using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameEndPanel : MonoBehaviour
{
    public bool IsWon;
    public UnityEngine.UI.Slider Slider;
    public GameObject _percentComplete;

    private void OnEnable()
    {
        if (IsWon)
        {
            GetComponent<Image>().color = new Color32(24, 96, 34, 150);
        }
        else
        {
            GetComponent<Image>().color = new Color32(96, 24, 34, 150);
            _percentComplete.SetActive(!IsWon);
            int percent = (int)(Slider.value * 100f);
            _percentComplete.GetComponent<Text>().text = percent.ToString() + "% of level Complete.";
        }
        
    }
    public void OnTap()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
    }
}
