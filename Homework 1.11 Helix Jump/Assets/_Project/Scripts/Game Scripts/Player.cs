using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private AudioSource _audioSource;
    public float BounceSpeed = 10f;
    public Game Game;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }
    public void Bounce()
    {
        if (Game.CurrentState != Game.State.Playing) return;
        _audioSource.Play();
        _rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    internal void Won()
    {
        _rigidbody.velocity = Vector3.zero;       
        Game.OnPlayerWon();
    }

    public void Die()
    {
        _rigidbody.velocity = Vector3.zero;
        Game.OnPlayerDied();
    }
}
