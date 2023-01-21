using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SongManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource hit;
    public GameObject breakTxt;
    public float songBpm;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float dspSongTime;
    public PinataHit pinata;
    // int nextIndex = 0;

    void Start()
    {
        //musicSource = GetComponent<AudioSource>();
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
        // musicSource.Play();
        Debug.Log(dspSongTime);
        // pinataObj = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = songPosition / secPerBeat;
        // Debug.Log(songPosition);

        if (!pinata.failed)
        {
            if ((int)Math.Round(songPositionInBeats) == 1)
            {
                breakTxt.gameObject.SetActive(true);
            }
            if ((int)Math.Round(songPositionInBeats) == 2)
            {
                breakTxt.gameObject.SetActive(false);
            }
            if ((int)Math.Round(songPositionInBeats) == 4)
            {
                breakTxt.gameObject.SetActive(true);
            }
            if ((int)Math.Round(songPositionInBeats) == 5)
            {
                breakTxt.gameObject.SetActive(false);
            }
            if ((int)Math.Round(songPositionInBeats) == 7)
            {
                breakTxt.gameObject.SetActive(true);
            }
            if ((int)Math.Round(songPositionInBeats) == 8)
            {
                breakTxt.gameObject.SetActive(false);
            }
            if ((int)Math.Round(songPositionInBeats) == 10)
            {
                breakTxt.gameObject.SetActive(true);
            }
            if ((int)Math.Round(songPositionInBeats) == 11)
            {
                breakTxt.gameObject.SetActive(false);
            }

            if (breakTxt.activeSelf && Input.GetKeyDown(KeyCode.Space))
            {
                hit.Play();
                pinata.successfulHits++;
                pinata.player.Play("smack");
                pinata.pinata.Play("PinataSwing");
                Debug.Log(pinata.successfulHits);
            }
            if ((!breakTxt.activeSelf) && Input.GetKeyDown(KeyCode.Space))
            {
                pinata.failedHits++;
                Debug.Log(pinata.failedHits);
            }
        }

        if (pinata.failed)
        {
            musicSource.Stop();
        }
    }
}
