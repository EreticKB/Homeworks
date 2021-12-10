using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private readonly string _indexLevelName = "LevelIndex";
    private readonly string _indexDestroyedPlatformsRecordLife = "DestroyedPlatformsRecordLife";
    private readonly string _indexDestroyedPlatformsRecordSession = "DestroyedPlatformsRecordSession";
    private readonly string _indexDestroyedPlatformsInterSessionSave = "DestroyedPlatformsBetweenSessions";
    private readonly string _indexSceneReloadCountSave = "SceneReloadCountSave";

    public Controls Controls;
    public GameObject StopLevelPanel;
    public DPlatformsCount SessionCount;
    private Text _tapToContinue;
    private Text _resultText;
    private AudioSource _audioSource;

    private int SceneReloadCountSave
    {
        get => PlayerPrefs.GetInt(_indexSceneReloadCountSave, 0);
        set
        {
            PlayerPrefs.SetInt(_indexSceneReloadCountSave, value);
            PlayerPrefs.Save();
        }
    }
    public int DestroyedPlatformsInterSessionSave
    {
        get => PlayerPrefs.GetInt(_indexDestroyedPlatformsInterSessionSave, 0);
        set
        {
            PlayerPrefs.SetInt(_indexDestroyedPlatformsInterSessionSave, value);
            PlayerPrefs.Save();
        }
    }
    public int DestroyedPlatformRecordSession
    {
        get => PlayerPrefs.GetInt(_indexDestroyedPlatformsRecordSession, 0);
        set
        {
            PlayerPrefs.SetInt(_indexDestroyedPlatformsRecordSession, value);
            PlayerPrefs.Save();
        }
    }
    public int DestroyedPlatformRecordLife
    {
        get => PlayerPrefs.GetInt(_indexDestroyedPlatformsRecordLife, 0);
        private set
        {
            PlayerPrefs.SetInt(_indexDestroyedPlatformsRecordLife, value);
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

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    private void Awake()
    {
        _tapToContinue = StopLevelPanel.transform.Find("TapField/TapToContinue").GetComponent<Text>();
        _resultText = StopLevelPanel.transform.Find("ResultField/ResultText").GetComponent<Text>();
        _audioSource = GetComponent<AudioSource>();
        SessionCount.TempDPlatformsLifeRecordFromLevelStart = DestroyedPlatformsInterSessionSave;
        SessionCount.SessionDestroedPlatformCount = SceneReloadCountSave;
        SceneReloadCountSave = 0;
    }
   
    
    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        SessionCount.SessionDestroedPlatformCount = 0;
        SessionCount.TempDPlatformsLifeRecordFromLevelStart = 0;
        DestroyedPlatformsInterSessionSave = 0;
        CurrentState = State.Loss;
        SessionEnd("Game Over!", "Tap to try Again.", false);
    }

    public void OnPlayerWon()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        LevelIndex++;
        if (SessionCount.TempDPlatformsLifeRecordFromLevelStart > DestroyedPlatformRecordLife) DestroyedPlatformRecordLife = SessionCount.TempDPlatformsLifeRecordFromLevelStart;
        DestroyedPlatformsInterSessionSave = SessionCount.TempDPlatformsLifeRecordFromLevelStart;
        SceneReloadCountSave = SessionCount.SessionDestroedPlatformCount;
        SessionEnd("You Win!", "Tap to next Level.", true);
     
    }

    private void SessionEnd(string message, string message2, bool isWon)
    {
        Controls.enabled = false;
        _audioSource.Stop();
        _resultText.text = message;
        _tapToContinue.text = message2;
        StopLevelPanel.GetComponent<GameEndPanel>().IsWon = isWon;
        StopLevelPanel.SetActive(true);
    }
}
