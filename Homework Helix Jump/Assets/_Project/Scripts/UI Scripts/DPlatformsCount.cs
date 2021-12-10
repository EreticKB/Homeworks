using UnityEngine;
using UnityEngine.UI;

public class DPlatformsCount : MonoBehaviour
{
    Text Text;
    public int SessionDestroedPlatformCount;
    public int TempDPlatformsLifeRecordFromLevelStart;
    public Game Game;
    
    private void Awake()
    {
        Text = GetComponent<Text>();
    }
    private void Update()
    {
        Text.text = ("Destroed total " + TempDPlatformsLifeRecordFromLevelStart + " Platforms." +
                     " \nIn current session: " + SessionDestroedPlatformCount);
    }
}
