using UnityEngine;

public class Player : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    private Rigidbody _rigidbody;
    private AudioSource _audioSource;
    public float BounceSpeed = 10f;
    public Game Game;
    private ParticleSystem _particleSystem;
    private MeshRenderer _meshrenderer;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        _particleSystem = GetComponent<ParticleSystem>();
        _meshrenderer = GetComponent<MeshRenderer>();
        SetMaterialProperty(_meshrenderer.material, "PropertyOpacity", 1);
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
        if (Game.CurrentState != Game.State.Playing) return;
        ParticleSystem.Play();
        Debug.Log("Win");
        Game.OnPlayerWon();
    }

    public void Die()
    {
        _rigidbody.velocity = Vector3.zero;
        if (Game.CurrentState != Game.State.Playing) return;
        _meshrenderer.shadowCastingMode = 0;
        SetMaterialProperty(_meshrenderer.material, "PropertyOpacity", 0);
        _particleSystem.Play();
        ParticleSystem.Stop();
        Game.OnPlayerDied();
    }

    private void SetMaterialProperty(Material material, string propertyName, float propertyValue)
    {
        if (_meshrenderer.material.HasProperty(propertyName)) _meshrenderer.material.SetFloat(propertyName, propertyValue);
        else Debug.Log("Don't have this shader property");        
    }
}
