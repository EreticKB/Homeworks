using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody Rigidbody;
    public float BounceSpeed = 10f;
    public Game Game;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
    public void Bounce()
    {
        if (Game.CurrentState != Game.State.Playing) return;
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    internal void Won()
    {
        Rigidbody.velocity = Vector3.zero;       
        Game.OnPlayerWon();
    }

    public void Die()
    {
        Rigidbody.velocity = Vector3.zero;
        Game.OnPlayerDied();
    }
}
