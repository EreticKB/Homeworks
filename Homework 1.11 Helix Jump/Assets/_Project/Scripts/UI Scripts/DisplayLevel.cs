using UnityEngine;
using UnityEngine.UI;

public class DisplayLevel : MonoBehaviour
{
    public Game Game;
    private void Start()
    {
        GetComponent<Text>().text = "Level " + (Game.LevelIndex + 1).ToString();
    }
}
