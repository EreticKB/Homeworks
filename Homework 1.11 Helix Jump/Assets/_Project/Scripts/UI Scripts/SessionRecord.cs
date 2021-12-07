using UnityEngine;
using UnityEngine.UI;

public class SessionRecord : MonoBehaviour
{
    private Text _text;
    public Game Game;
    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        _text.text = "One Session Record: " + Game.DestroyedPlatformRecordLife.ToString();
    }
}
