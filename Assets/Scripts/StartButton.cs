using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject SpaceScreen, BreakScreen;
    public GameObject three, two, one, go;

    public AudioSource click, tone1, tone2;

    public void Start()
    {
        SpaceScreen.gameObject.SetActive(false);
        BreakScreen.gameObject.SetActive(false);
    }
    public void LoadScene(string SceneName)
    {
        click.Play();
        StartCoroutine(timer(SceneName));
    }

    public void NextScreen()
    {
        click.Play();
        SpaceScreen.gameObject.SetActive(true);
    }

    public void NextScreen2()
    {
        click.Play();
        BreakScreen.gameObject.SetActive(true);
    }

    IEnumerator timer(string SceneName)
    {
        tone1.Play();
        three.gameObject.SetActive(true);
        yield return new WaitForSeconds(.7f);
        tone1.Play();
        two.gameObject.SetActive(true);
        yield return new WaitForSeconds(.7f);
        tone1.Play();
        one.gameObject.SetActive(true);
        yield return new WaitForSeconds(.7f);
        tone2.Play();
        go.gameObject.SetActive(true);
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene(SceneName);
    }
}
