using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[RequireComponent(typeof(AudioSource))]
[System.Obsolete]
public class ImageTargetPlayAudio : MonoBehaviour,
                                            ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    //public AudioSource audioSource;

    AudioSource audioData;

    [System.Obsolete]
    void Start()
    {
        
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        //audioSource = GameObject.Find("Audio").GetComponent<AudioSource>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found

            //audioSource.Play();
            audioData.UnPause();

        }
        else
        {
            // Stop audio when target is lost
            //audioSource.Stop();
            audioData.Pause();
        }
    }
}