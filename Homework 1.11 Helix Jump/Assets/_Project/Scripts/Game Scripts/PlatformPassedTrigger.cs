using UnityEngine;

public class PlatformPassedTrigger : MonoBehaviour
{
    private Game _game;
    private DPlatformsCount _count;
    private Collider _player;
    [HideInInspector] public GameObject DestroyedPlatformLink;
    private void Awake()
    {
        _game = GameObject.Find("Game").gameObject.GetComponent<Game>();
        _player = GameObject.Find("Player").gameObject.GetComponent<Collider>();
        _count = GameObject.Find("/Canvas/DestroyedPlatforms").gameObject.GetComponent<DPlatformsCount>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other != _player) return;
        _count.TempDPlatformsLifeRecordFromLevelStart++;
        if (_count.SessionDestroedPlatformCount++ > _game.DestroyedPlatformRecordSession) _game.DestroyedPlatformRecordSession = _count.SessionDestroedPlatformCount;
        DestroyedPlatformLink.SetActive(true);
        gameObject.SetActive(false);
    }
}
