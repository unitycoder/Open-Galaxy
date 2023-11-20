using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInfo : MonoBehaviour, ISelectHandler, IPointerEnterHandler
{ 
    public Text buttonName; //The button name
    public Text description; //The description of what the button does (if button has one)
    public float buttonShift; //How far to move before placing the next button so that it doesn't overlap with this one
    public bool noSound = false;

    private MainMenu mainMenu;

    void Start()
    {
        mainMenu = GameObject.FindObjectOfType<MainMenu>();
    }

    // When highlighted with mouse.
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (mainMenu != null & noSound == false)
        {
            if (mainMenu.buttonAudioSource != null & mainMenu.buttonHighlight != null)
            {
                mainMenu.buttonAudioSource.PlayOneShot(mainMenu.buttonHighlight);                
            }
        }       
    }

    // When selected.
    public void OnSelect(BaseEventData eventData)
    {
        if (mainMenu != null & noSound == false)
        {
            if (mainMenu.buttonAudioSource != null & mainMenu.buttonHighlight != null)
            {
                mainMenu.buttonAudioSource.PlayOneShot(mainMenu.buttonHighlight);       
            }
        }
    }

}
