using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mission1 : MonoBehaviour
{
    public Image Mission1_Image;
    public Text Mission1_Text;
    public GameObject missiontext;
    public bool is_start = false;
    // Start is called before the first frame update
    void Start()
    {
        Mission1_Image.enabled = false;
        Mission1_Text.enabled = false;
        is_start = false;
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            missiontext.SetActive(true);
            Mission1_Image.enabled = true;
            Mission1_Text.enabled = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        Mission1_Image.enabled = false;
        Mission1_Text.enabled = false;
        is_start = true;
    }
}
