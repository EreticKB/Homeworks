using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float stops;
    public float speed;
    float _rotationY;

    private void Update()
    {
        stops += Time.deltaTime;
        if (_rotationY > 360) _rotationY = 0;
        if (stops < 1) return;
        _rotationY += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, _rotationY, 0);
        if (stops > 6) stops = 0;
    }
}
