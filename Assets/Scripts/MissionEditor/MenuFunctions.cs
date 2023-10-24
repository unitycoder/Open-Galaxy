using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MenuFunctions
{
    //This generates the main menu node
    public static void DrawMainMenu(Menu menu)
    {
        DrawText(menu, "Mission Editor", 8, 5, -5, 12.5f, 90);

        DrawLineBreak(menu, "#808080", 0, -20, 1, 100);

        DrawImageButton(menu, 10, -25, 25, 25, "exit", "ExitMissionEditor");

        DrawImageButton(menu, 60, -25, 25, 25, "import", "none");

        DrawImageButton(menu, 10, -50, 25, 25, "plus", "none");

        DrawImageButton(menu, 60, -50, 25, 25, "save", "none");

        DrawImageButton(menu, 10, -75, 25, 25, "star", "none");

        DrawImageButton(menu, 60, -75, 25, 25, "trashcan", "none");
    }

    public static void DrawAddNode(Menu menu)
    {
        DrawText(menu, "Add Event Node", 8, 5, -5, 12.5f, 90);

        DrawLineBreak(menu, "#808080", 0, -20, 1, 100);

        List<string> buttonList = new List<string>();

        buttonList.Add("custom_node");
        buttonList.Add("loadscene");
        buttonList.Add("preload_loadasteroids");
        buttonList.Add("preload_loadplanet");
        buttonList.Add("preload_loadtiles");
        buttonList.Add("preload_loadmultipleshipsonground");
        buttonList.Add("preload_loadship");
        buttonList.Add("preload_loadshipsbyname");
        buttonList.Add("preload_loadshipsbytypeandallegiance");
        buttonList.Add("preload_setskybox");
        buttonList.Add("changemusicvolume");
        buttonList.Add("clearaioverride");
        buttonList.Add("displaylargemessagethenexit");
        buttonList.Add("dialoguebox");
        buttonList.Add("displaylargemessage");
        buttonList.Add("displaylocation");
        buttonList.Add("displaymissionbriefing");
        buttonList.Add("iftypeofshipisactive");
        buttonList.Add("loadship");
        buttonList.Add("loadshipatdistanceandanglefromplayer");
        buttonList.Add("loadmultipleshipsonground");
        buttonList.Add("loadshipsbyname");
        buttonList.Add("loadshipsbytypeandallegiance");
        buttonList.Add("lockmainshipweapons");
        buttonList.Add("message");
        buttonList.Add("movetowaypoint");
        buttonList.Add("playmusictype");
        buttonList.Add("setaioverride");
        buttonList.Add("setdontattacklargeships");
        buttonList.Add("setshipallegiance");
        buttonList.Add("setshiptarget");
        buttonList.Add("setshiptargettoclosestenemy");
        buttonList.Add("setshiptoinvincible");
        buttonList.Add("setweaponslock");
        buttonList.Add("shipshullislessthan");
        buttonList.Add("shipislessthandistancetowaypoint");

        List<string> functionList = new List<string>();

        foreach (string button in buttonList)
        {
            functionList.Add("SelectNodeTypeToLoad");
        }

        string[] buttons = buttonList.ToArray();
        string[] functions = functionList.ToArray();

        DrawScrollableButtons(menu, 5, -25, 70, 90, 10, 7, buttons, functions);

        DrawTextBox(menu, 5, -100, 70, 90, "NodeSprite_Dark", "Information about nodes", 5, TextAnchor.UpperLeft, true, null, "AddNodeTextBox");

        DrawTextButton(menu, 5, -180, 10, 90, "NodeSprite_Dark", "Add Node", 7, "AddNode", TextAnchor.MiddleCenter);
    }

    #region draw menu functions

    //This draws the base node gameobject
    public static void DrawMenuBase(Menu menu)
    {
        //This sets up the node background
        menu.rectTransform = menu.gameObject.AddComponent<RectTransform>();

        menu.background = menu.gameObject.AddComponent<Image>();
        menu.background.sprite = Resources.Load<Sprite>("Data/EditorAssets/NodeSprite_Grey");
        menu.background.type = Image.Type.Sliced;
        menu.background.pixelsPerUnitMultiplier = 5;
        menu.rectTransform.sizeDelta = new Vector2(menu.sizeX, menu.sizeZ);
        menu.rectTransform.localPosition = new Vector2(menu.xPos, menu.yPos);
        menu.rectTransform.localScale = new Vector3(1, 1, 1);
    }

    //This draws a title
    public static void DrawText(Menu menu, string title, int fontSize, float xPos, float yPos, float height, float width)
    {
        //This draws the input label
        GameObject titleGO = new GameObject();

        titleGO.transform.SetParent(menu.rectTransform.transform);
        RectTransform rectTransform = titleGO.AddComponent<RectTransform>();
        rectTransform.anchorMax = new Vector2(0, 1);
        rectTransform.anchorMin = new Vector2(0, 1);
        rectTransform.pivot = new Vector2(0, 1);
        rectTransform.anchoredPosition = new Vector2(xPos, yPos);
        rectTransform.sizeDelta = new Vector2(width, height);
        rectTransform.localScale = new Vector3(1, 1, 1);

        Text labelText = titleGO.AddComponent<Text>();
        labelText.supportRichText = false;
        labelText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        labelText.text = title;
        labelText.fontSize = fontSize;
        labelText.color = Color.white;
        labelText.alignment = TextAnchor.MiddleLeft;

        titleGO.name = "Title_" + title;
    }

    //This draws a line break
    public static void DrawLineBreak(Menu menu, string color, float xPos, float yPos, float height, float width)
    {
        GameObject lineBreakGO = new GameObject();

        lineBreakGO.transform.SetParent(menu.rectTransform.transform);
        RectTransform rectTransform = lineBreakGO.AddComponent<RectTransform>();
        rectTransform.anchorMax = new Vector2(0, 1);
        rectTransform.anchorMin = new Vector2(0, 1);
        rectTransform.pivot = new Vector2(0, 1);
        rectTransform.anchoredPosition = new Vector2(xPos, yPos);
        rectTransform.sizeDelta = new Vector2(width, height);
        rectTransform.localScale = new Vector3(1, 1, 1);

        Image lineBreakImage = lineBreakGO.AddComponent<Image>();

        if (!ColorUtility.TryParseHtmlString(color, out Color myColor))
        {
            lineBreakImage.color = Color.black;
        }
        else
        {
            lineBreakImage.color = myColor;
        }

        lineBreakGO.name = "linebreak";
    }


    //This draws a button and allocates a function
    public static void DrawImageButton(Menu menu, float xPos, float yPos, float height, float width, string imageName, string functionType, bool parentToNode = true, Transform differentTransform = null)
    {
        GameObject buttonGO = new GameObject();

        if (parentToNode == true)
        {
            buttonGO.transform.SetParent(menu.rectTransform.transform);
        }
        else
        {
            buttonGO.transform.SetParent(differentTransform);
        }
       
        RectTransform rectTransform = buttonGO.AddComponent<RectTransform>();
        rectTransform.anchorMax = new Vector2(0, 1);
        rectTransform.anchorMin = new Vector2(0, 1);
        rectTransform.pivot = new Vector2(0, 1);
        rectTransform.anchoredPosition = new Vector2(xPos, yPos);
        rectTransform.sizeDelta = new Vector2(width, height);
        rectTransform.localScale = new Vector3(1, 1, 1);

        Image buttonImage = buttonGO.AddComponent<Image>();
        buttonImage.sprite = Resources.Load<Sprite>("Data/EditorAssets/" + imageName);

        Button button = buttonGO.AddComponent<Button>();
        button.image = buttonImage;

        if (functionType == "ExitMissionEditor")
        {
            button.onClick.AddListener(() => { MissionEditorFunctions.ExitMissionEditor(); });
        }

        buttonGO.name = "button_" + functionType;
    }

    //This draws a button and allocates a function
    public static void DrawTextButton(Menu menu, float xPos, float yPos, float height, float width, string buttonImageName, string buttonText, int fontSize, string functionType, TextAnchor alignement = TextAnchor.MiddleCenter, bool parentToNode = true, Transform differentTransform = null)
    {
        GameObject buttonGO = new GameObject();
        GameObject buttonTextGO = new GameObject();

        if (parentToNode == true)
        {
            buttonGO.transform.SetParent(menu.rectTransform.transform);
        }
        else
        {
            buttonGO.transform.SetParent(differentTransform);
        }

        buttonTextGO.transform.SetParent(buttonGO.transform);

        RectTransform rectTransform1 = buttonGO.AddComponent<RectTransform>();
        rectTransform1.anchorMax = new Vector2(0, 1);
        rectTransform1.anchorMin = new Vector2(0, 1);
        rectTransform1.pivot = new Vector2(0, 1);
        rectTransform1.anchoredPosition = new Vector2(xPos, yPos);
        rectTransform1.sizeDelta = new Vector2(width, height);
        rectTransform1.localScale = new Vector3(1, 1, 1);

        RectTransform rectTransform2 = buttonTextGO.AddComponent<RectTransform>();
        rectTransform2.anchorMax = new Vector2(0, 1);
        rectTransform2.anchorMin = new Vector2(0, 1);
        rectTransform2.pivot = new Vector2(0, 1);
        rectTransform2.anchoredPosition = new Vector2(0, 0);
        rectTransform2.sizeDelta = new Vector2(width, height);
        rectTransform2.localScale = new Vector3(1, 1, 1);

        Image buttonImage = buttonGO.AddComponent<Image>();
        buttonImage.type = Image.Type.Sliced;
        buttonImage.pixelsPerUnitMultiplier = 30;

        if (buttonImageName != "none" & buttonImageName != "")
        {
            buttonImage.sprite = Resources.Load<Sprite>("Data/EditorAssets/" + buttonImageName);
        }
        else
        {
            buttonImage.color = Color.gray;
        }

        Button button = buttonGO.AddComponent<Button>();
        button.image = buttonImage;

        Text text = buttonTextGO.AddComponent<Text>();
        text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        text.fontSize = fontSize;
        text.text = buttonText;
        text.alignment = alignement;

        if (functionType == "ExitMissionEditor")
        {
            button.onClick.AddListener(() => { MissionEditorFunctions.ExitMissionEditor(); });
        }
        else if (functionType == "SelectNodeTypeToLoad")
        {
            button.onClick.AddListener(() => { MissionEditorFunctions.SelectNodeType(buttonText); });
        }
        else if (functionType == "AddNode")
        {
            button.onClick.AddListener(() => { MissionEditorFunctions.AddSelectedNodeType(); });
        }

        buttonGO.name = "button_" + functionType;
    }

    public static void DrawScrollableButtons(Menu menu, float xPos, float yPos, float height, float width, float buttonHeight, int fontSize, string[] buttons, string[] functions)
    {
        GameObject baseGO = new GameObject();
        GameObject viewportGO = new GameObject();
        GameObject contentGO = new GameObject();

        baseGO.transform.SetParent(menu.transform);
        viewportGO.transform.SetParent(baseGO.transform);
        contentGO.transform.SetParent(viewportGO.transform);

        RectTransform baseRectTransform = baseGO.AddComponent<RectTransform>();
        RectTransform viewportRectTransform = viewportGO.AddComponent<RectTransform>();
        RectTransform contentRectTransform = contentGO.AddComponent<RectTransform>();

        baseRectTransform.name = "Scrollable_Buttons";
        viewportRectTransform.name = "Viewport";
        contentRectTransform.name = "ContentRect";

        baseRectTransform.anchorMax = new Vector2(0, 1);
        baseRectTransform.anchorMin = new Vector2(0, 1);
        baseRectTransform.pivot = new Vector2(0, 1);
        baseRectTransform.anchoredPosition = new Vector2(xPos, yPos);
        baseRectTransform.sizeDelta = new Vector2(width, height);
        baseRectTransform.localScale = new Vector3(1, 1, 1);

        viewportRectTransform.anchorMax = new Vector2(0, 1);
        viewportRectTransform.anchorMin = new Vector2(0, 1);
        viewportRectTransform.pivot = new Vector2(0, 1);
        viewportRectTransform.anchoredPosition = new Vector2(0, 0);
        viewportRectTransform.sizeDelta = new Vector2(width, height);
        viewportRectTransform.localScale = new Vector3(1, 1, 1);

        float contentRectHeight = buttonHeight * buttons.Length;

        contentRectTransform.anchorMax = new Vector2(0, 1);
        contentRectTransform.anchorMin = new Vector2(0, 1);
        contentRectTransform.pivot = new Vector2(0, 1);
        contentRectTransform.anchoredPosition = new Vector2(0, 0);
        contentRectTransform.sizeDelta = new Vector2(width, contentRectHeight);
        contentRectTransform.localScale = new Vector3(1, 1, 1);

        Image maskImage = viewportGO.AddComponent<Image>();
        maskImage.type = Image.Type.Sliced;
        maskImage.pixelsPerUnitMultiplier = 30;
        maskImage.color = Color.gray;

        Mask mask = viewportGO.AddComponent<Mask>();
        
        ScrollRect scrollRect = baseGO.AddComponent<ScrollRect>();
        scrollRect.content = contentRectTransform;
        scrollRect.viewport = viewportRectTransform;
        scrollRect.horizontal = false;
        scrollRect.inertia = false;
        scrollRect.elasticity = 0;

        float buttonDrop = 0;
        int i = 0;

        foreach (string button in buttons)
        {
            DrawTextButton(menu, 0, buttonDrop, buttonHeight, width, "none", button, fontSize, functions[i], TextAnchor.MiddleLeft, false, contentGO.transform);
            buttonDrop -= buttonHeight;
            i++;
        }
    }

    //This draws a text box
    public static void DrawTextBox(Menu menu, float xPos, float yPos, float height, float width, string backgroundImageName, string textBoxText, int fontSize, TextAnchor alignement = TextAnchor.MiddleCenter, bool parentToNode = true, Transform differentTransform = null, string name = "none")
    {
        GameObject textboxGO = new GameObject();
        GameObject textBoxTextGO = new GameObject();

        if (parentToNode == true)
        {
            textboxGO.transform.SetParent(menu.rectTransform.transform);
        }
        else
        {
            textboxGO.transform.SetParent(differentTransform);
        }

        textBoxTextGO.transform.SetParent(textboxGO.transform);

        RectTransform rectTransform1 = textboxGO.AddComponent<RectTransform>();
        rectTransform1.anchorMax = new Vector2(0, 1);
        rectTransform1.anchorMin = new Vector2(0, 1);
        rectTransform1.pivot = new Vector2(0, 1);
        rectTransform1.anchoredPosition = new Vector2(xPos, yPos);
        rectTransform1.sizeDelta = new Vector2(width, height);
        rectTransform1.localScale = new Vector3(1, 1, 1);

        RectTransform rectTransform2 = textBoxTextGO.AddComponent<RectTransform>();
        rectTransform2.anchorMax = new Vector2(0, 1);
        rectTransform2.anchorMin = new Vector2(0, 1);
        rectTransform2.pivot = new Vector2(0, 1);
        rectTransform2.anchoredPosition = new Vector2(1, -1);
        rectTransform2.sizeDelta = new Vector2(width - 2, height -2);
        rectTransform2.localScale = new Vector3(1, 1, 1);

        Image backgroundImage = textboxGO.AddComponent<Image>();
        backgroundImage.type = Image.Type.Sliced;
        backgroundImage.pixelsPerUnitMultiplier = 30;

        if (backgroundImageName != "none" & backgroundImageName != "")
        {
            backgroundImage.sprite = Resources.Load<Sprite>("Data/EditorAssets/" + backgroundImageName);
        }
        else
        {
            backgroundImage.color = Color.gray;
        }

        Text text = textBoxTextGO.AddComponent<Text>();
        text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        text.fontSize = fontSize;
        text.text = textBoxText;
        text.alignment = alignement;

        if (name != "none")
        {
            textboxGO.name = name;
        }
        else
        {
            textboxGO.name = "textbox";
        }

    }

    #endregion
}
