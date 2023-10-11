using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MissionEditor : MonoBehaviour
{
    public List<Node> nodes;
    public List<Menu> menus;
    public Canvas canvas;
    public RectTransform editorContentRect;
    public ScrollRect scrollRect;
    public Text AddNodeTextBox;
    public float scale = 1;
    public string gameWindowMode;
    public bool scrolling;
    public string selectedNodeTypeToLoad;

    void Start()
    {
        GameObject editorContentGo = GameObject.Find("EditorContent");
        editorContentRect = editorContentGo.GetComponent<RectTransform>();
        scrollRect = editorContentGo.GetComponentInParent<ScrollRect>();

        MissionEditorFunctions.SetWindowMode(this);

        menus = new List<Menu>();

        GameObject menu1GO = new GameObject();
        menu1GO.transform.SetParent(gameObject.transform);
        Menu menu1 = menu1GO.AddComponent<Menu>();
        menu1.menuType = "mainmenu";
        menus.Add(menu1);

        GameObject menu2GO = new GameObject();
        menu2GO.transform.SetParent(gameObject.transform);
        Menu menu2 = menu2GO.AddComponent<Menu>();
        menu2.menuType = "addnodes";
        menus.Add(menu2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnGUI()
    {
        MissionEditorFunctions.ScaleGrid(this);
        MissionEditorFunctions.ToggleScrolling(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("I was clicked");
    }
}
