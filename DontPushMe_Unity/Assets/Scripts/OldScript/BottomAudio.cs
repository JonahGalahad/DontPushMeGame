using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class BottomAudio : MonoBehaviour
{
    [SerializeField]
    public FMODUnity.EventReference Audio;

    public void PlaySoundEvent ()
    {
        RuntimeManager.PlayOneShot(Audio);
    }

}
