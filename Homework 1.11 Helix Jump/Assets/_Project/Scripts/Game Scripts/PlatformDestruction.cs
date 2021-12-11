using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestruction : MonoBehaviour
{
    private float time;
    private AudioSource _audioSource;
    bool _isPlay;
    private void Awake()
    {
        time = 0;
        _audioSource = GetComponent<AudioSource>();
        _isPlay = true;
    }

    private void Update()
    {
        if (!enabled) return;        
        if (time < .6f) time += Time.deltaTime;            
        else gameObject.SetActive(false); 
        if (_isPlay)
        {
            _audioSource.Play();
            _isPlay = false;      
        }

    }   

}
