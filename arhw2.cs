using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class arhw2 : MonoBehaviour
{
    public GameObject text;
    public VirtualButtonBehaviour Vb;
    public GameObject text2;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        text.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        text.SetActive(true);
        text2.SetActive(false);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        text.SetActive(false);
        text2.SetActive(true);
    }
}
