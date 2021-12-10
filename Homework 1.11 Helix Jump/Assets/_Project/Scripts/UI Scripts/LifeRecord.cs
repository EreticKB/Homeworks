using UnityEngine;
using UnityEngine.UI;

public class LifeRecord : MonoBehaviour
{
    private Text _text;
    public Game Game;
    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        _text.text = "One Life Record: " + Game.DestroyedPlatformRecordSession.ToString();
    }
}
