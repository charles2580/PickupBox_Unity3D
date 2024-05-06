using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    public GameObject notice;
    public GameObject notice1;
    public GameObject notice2;
    public GameObject exitbutton;

    public AudioSource Uiaudio;
    public AudioClip buttonAudio;
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }

    public void InformationButton()
    {
        notice.SetActive(true);
        exitbutton.SetActive(false);
        notice1.SetActive(true);
        notice2.SetActive(false);
    }

    public void ExitButton()
    { 
        Application.Quit();
    }

    public void NextButton()
    {
        notice1.SetActive(false);
        notice2.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            notice.SetActive(false);
            exitbutton.SetActive(true);

        }
    }

    public void buttonSound()
    {
        Uiaudio.Play();
    }
}
