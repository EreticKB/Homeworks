using UnityEngine;

public class Slider : MonoBehaviour
{
    public Transform Camera;
    public Transform Finish;

    private UnityEngine.UI.Slider _slider;
    private float _cameraOffsetY = 10;

    private void Awake()
    {
        _slider = GetComponent<UnityEngine.UI.Slider>();
    }
    private void Update()
    {
      _slider.value = Mathf.InverseLerp(_cameraOffsetY, Finish.position.y+_cameraOffsetY, Camera.position.y);
    }
 
}
