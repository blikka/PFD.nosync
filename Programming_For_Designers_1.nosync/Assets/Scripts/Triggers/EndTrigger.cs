using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using FMODUnity;
using FMOD.Studio;

public class EndTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public ParticleSystem particleSystem;
    private bool hasPlayed = false;
    public GameObject music;
    //public EventReference WinMusic;
    //private EventInstance winMusicInstance;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            Destroy(music);

            playableDirector.Play();

            particleSystem.Play();

            hasPlayed = true;

            //winMusicInstance = RuntimeManager.CreateInstance(WinMusic);
            //winMusicInstance.start();

            Debug.Log("Playable Director is playing");
        }
    }
    /*void StopWinMusic()
    {
        winMusicInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }*/
}
