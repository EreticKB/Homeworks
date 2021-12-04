using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVolume : MonoBehaviour
{
    [Min(0)]
    public float Volume;
    void Update()
    {
        AudioListener.volume = Volume;
    }
}
