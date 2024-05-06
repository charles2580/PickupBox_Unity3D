using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turtorial : MonoBehaviour
{
    public Image tutorialImage;
    public Text tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        tutorialImage.enabled = false;
        tutorialText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            tutorialImage.enabled = true;
            tutorialText.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        tutorialImage.enabled = false;
        tutorialText.enabled = false;
    }
}
