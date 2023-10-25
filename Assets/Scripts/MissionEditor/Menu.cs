using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Menu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    public string menuType = "Add Node";
    public float xPos = 0;
    public float yPos = 0;

    public RectTransform rectTransform;
    public float sizeX = 100;
    public float sizeZ = 200;
    public Image background;

    private bool dragging;
    public bool scaling;

    private bool MenuDrawn;

    public ScrollRect scrollRect;

    MissionEditor missionEditor;

    // Start is called before the first frame update
    void Start()
    {
        //This gets the reference to the mission editor
        missionEditor = MissionEditorFunctions.GetMissionEditor();

        MenuFunctions.DrawMenuBase(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (dragging == true)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (MenuDrawn == false)
        {
            if (menuType == "mainmenu")
            {
                MenuFunctions.DrawMainMenu(this);
            }
            else if (menuType == "addnodes")
            {
                MenuFunctions.DrawAddNode(this);
            }
            else if (menuType == "savemission")
            {
                MenuFunctions.Draw_SaveMission(this);
            }

            MenuDrawn = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        scaling = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        scaling = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        dragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

    }



}
