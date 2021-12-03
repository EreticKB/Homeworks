using UnityEngine;

public class PlatformCountTrigger : MonoBehaviour
{
    private Game Game;
    private void Awake()
    {
        Game = GameObject.Find("Game").gameObject.GetComponent<Game>();
    }
    private void OnTriggerExit(Collider other)
    {
        Game.DestroyedPlatformCount++;
    }
}
