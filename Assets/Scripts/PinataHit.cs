using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinataHit : MonoBehaviour
{
    public Animator pinata;
    public Animator player;

    public int successfulHits;
    public int failedHits;
    public float timeLeft;
    public bool running = true;
    public bool failed = false;

    public TextMeshProUGUI countdownDisplay;

    public GameObject breakTxt;
    public GameObject againButton;
    public GameObject winScreen, loseScreen;

    public ParticleSystem candy;

    public AudioSource fail;
    public AudioSource win;

    public SongManager songManager;

    public void Start()
    {
        pinata = gameObject.GetComponent<Animator>();
        successfulHits = 0;
        // endState.enabled = false;
        againButton.gameObject.SetActive(false);
        countdownDisplay.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {

            if (successfulHits == 4)
            {
                pinata.Play("PinataBreak");
                win.Play();
                running = false;
                candy.Play();

                songManager.breakTxt.gameObject.SetActive(false);

                winScreen.gameObject.SetActive(true);
                countdownDisplay.enabled = false;
                againButton.gameObject.SetActive(true);
            }

            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                countdownDisplay.text = (timeLeft).ToString("0");
            }
            else
            {
                running = false;
                timeLeft = 0;
                countdownDisplay.text = "END!";
                fail.Play();
                failed = true;

                loseScreen.gameObject.SetActive(true);
                // endState.enabled = true;
                countdownDisplay.enabled = false;
                againButton.gameObject.SetActive(true);
            }
            if (failedHits >= 3)
            {
                fail.Play();
                running = false;
                timeLeft = 0;
                failed = true;

                loseScreen.gameObject.SetActive(true);
                countdownDisplay.enabled = false;
                againButton.gameObject.SetActive(true);

            }
        }
    }
}
