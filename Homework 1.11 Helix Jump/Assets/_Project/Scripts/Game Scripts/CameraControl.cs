using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform _position;
    private float _cameraOffset = 8f;
    public Transform Player;

    private void Awake()
    {
        _position = GetComponent<Transform>();
    }

    private void Update()
    {
        float newPositionY = Mathf.Min(_position.position.y -_cameraOffset, Player.position.y);
        _position.position = new Vector3(_position.position.x, newPositionY + _cameraOffset, _position.position.z);
    }
}
