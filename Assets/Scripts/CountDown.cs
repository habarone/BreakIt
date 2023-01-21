// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

// public class CountDown : MonoBehaviour
// {
//     public float timeLeft;
//     public bool running = false;

//     public TextMeshProUGUI countdownDisplay;

// public void start(){

//     }
//     void Update()
//     {

//         if (timeLeft > 0)
//         {
//             timeLeft -= Time.deltaTime;
//             countdownDisplay.text = (timeLeft).ToString("0");
//         }
//         else
//         {
//             countdownDisplay.text = (timeLeft).ToString("END!");


//         }
//     }

// private void Start()
// {
//     running = true;
// }
// void Update()

// {
//     if (running)
//     {
//         if (countDownTime > 0)

//         {

//             countDownTime -= Time.deltaTime;

//         }
//         else
//         {
//             countDownTime = 0;
//             running = false;
//         }
//     }
// }

// IEnumerable Start()
// {
//     yield return StartCoroutine(CountdownToStart());
// }


// IEnumerable CountdownToStart()
// {
//     while (countDownTime > 0)
//     {
//         countdownDisplay.text = countDownTime.ToString();

//         yield return new WaitForSeconds(1f);

//         countDownTime--;
//     }

//     countdownDisplay.text = "END!";
//     // end game in game controller
//     yield return new WaitForSeconds(1f);
//     countdownDisplay.gameObject.SetActive(false);
// }

//}
