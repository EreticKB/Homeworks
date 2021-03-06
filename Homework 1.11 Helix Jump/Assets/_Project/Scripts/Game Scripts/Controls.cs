    using UnityEngine;

public class Controls : MonoBehaviour
{
    private Transform Level;
    private Vector3 _mousePreviousPosition;
    public float MouseSpeed = 1f;

    private void Start()
    {
        Level = GetComponent<Transform>();
        Level.Rotate(Vector3.zero);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _mousePreviousPosition;
            Level.Rotate(0, -delta.x * MouseSpeed, 0);
        }
        _mousePreviousPosition = Input.mousePosition;        
    }
}
