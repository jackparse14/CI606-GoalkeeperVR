using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSrc;
    [SerializeField]
    private AudioClip click;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    public void PlayClick() {
        audioSrc.PlayOneShot(click);
    }
}
