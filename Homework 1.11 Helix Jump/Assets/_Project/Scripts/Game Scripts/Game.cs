using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Controls Controls;
    private readonly string _indexLevelName = "LevelIndex";
    private readonly string _indexDestroyedPlatformsCount = "DestroyedPlatforms";
    private int temporaryDPlatformsCount;

    public GameObject StopLevelPanel;
    private Text _tapToContinue;
    private Text _resultText;

    [HideInInspector]
    public int DestroyedPlatformCount
    {
        get => PlayerPrefs.GetInt(_indexDestroyedPlatformsCount, 0);
        set
        {
            PlayerPrefs.SetInt(_indexDestroyedPlatformsCount, value);
            PlayerPrefs.Save();
        }
    }
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(_indexLevelName, 0);
        set
        {
            PlayerPrefs.SetInt(_indexLevelName, value);
            PlayerPrefs.Save();
        }
    }

    private void Awake()
    {
        _tapToContinue = StopLevelPanel.transform.Find("TapField/TapToContinue").GetComponent<Text>();
        _resultText = StopLevelPanel.transform.Find("ResultField/ResultText").GetComponent<Text>();
        temporaryDPlatformsCount = DestroyedPlatformCount;
    }
   
    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        DestroyedPlatformCount = temporaryDPlatformsCount;
        CurrentState = State.Loss;
        SessionEnd("Game Over!", "Tap to try Again.", false);
    }

    public void OnPlayerWon()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        LevelIndex++;
        SessionEnd("You Win!", "Tap to next Level.", true);
     
    }

    private void SessionEnd(string message, string message2, bool isWon)
    {
        Controls.enabled = false;
        temporaryDPlatformsCount = DestroyedPlatformCount;
        _resultText.text = message;
        _tapToContinue.text = message2;
        StopLevelPanel.GetComponent<GameEndPanel>().IsWon = isWon;
        StopLevelPanel.SetActive(true);
    }

    private void OnDestroy()
    {
        DestroyedPlatformCount = temporaryDPlatformsCount;
    }
}
