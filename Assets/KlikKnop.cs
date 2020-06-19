using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KlikKnop : MonoBehaviour 
{

    public GameObject ShaderTimeline;
    public GameObject BewegendeMuren;
    public GameObject NaStyleswitchLamp;
    public GameObject VrolijkeEindMuziek;
    public GameObject SombereBeginMuziek;
    public GameObject EindQuote;

    [SerializeField]
    private Text ClickText;

    private bool PossibleClick;
    private bool HasClicked = false;
       
    // Start is called before the first frame update
    private void Start()
    {
        ClickText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (PossibleClick && Input.GetKeyDown(KeyCode.E))
        { 
            ActivateShader();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.name.Equals("FirstPersonPlayer")) 
        {
            if (HasClicked == false)
            {
                ClickText.gameObject.SetActive(true);
                PossibleClick = true;
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("FirstPersonPlayer"))
        {
            ClickText.gameObject.SetActive(false);
            PossibleClick = false;
        }
    }

    //Deze functie activeert de Timeline
    private void ActivateShader ()
    {
        //Debug.Log("HET WERKT, Ik ben geactiveerd!");
        ShaderTimeline.SetActive(true);
        BewegendeMuren.SetActive(true);
        NaStyleswitchLamp.SetActive(true);
        VrolijkeEindMuziek.SetActive(true);
        SombereBeginMuziek.SetActive(false);
        EindQuote.SetActive(true);

        HasClicked = true;
        ClickText.gameObject.SetActive(false);
    }
}
