using UnityEngine;

public class PlatformPassedTrigger : MonoBehaviour
{
    private Game _game;
    private AudioSource _audioSource;
    private void Awake()
    {
        _game = GameObject.Find("Game").gameObject.GetComponent<Game>();
        _audioSource = GetComponent<AudioSource>();

    }
    private void OnTriggerExit(Collider other)
    {
        _game.DestroyedPlatformCount++;
        _audioSource.Play();
    }
}
