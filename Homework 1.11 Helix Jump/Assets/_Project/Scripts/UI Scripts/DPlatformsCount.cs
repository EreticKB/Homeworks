using UnityEngine;
using UnityEngine.UI;

public class DPlatformsCount : MonoBehaviour
{
    public Game Game;
    int _dCount;
    Text Text;
    private void Awake()
    {
        _dCount = Game.GetComponent<Game>().DestroyedPlatformCount;
        Text = GetComponent<Text>();
    }
    private void Update()
    {
        Text.text = "Destroed " + _dCount + " Platforms.";
    }
}
