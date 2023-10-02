using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MissionEditor : MonoBehaviour
{
    public Node[] nodes;
    public Canvas canvas;
    public RectTransform EditorContentRect;
    public float scale = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject EditorContentGo = GameObject.Find("EditorContent");
        EditorContentRect = EditorContentGo.GetComponent<RectTransform>();

        OGSettings settings = OGSettingsFunctions.GetSettings();

        if (settings.editorWindowMode == "fullscreen")
        {
            int widthRes = Screen.currentResolution.width;
            int heightRes = Screen.currentResolution.height;
            Screen.SetResolution(widthRes, heightRes, FullScreenMode.FullScreenWindow);
        }
        else if (settings.editorWindowMode == "window")
        {
            int widthRes = Screen.currentResolution.width /2;
            int heightRes = Screen.currentResolution.height /2;
            Screen.SetResolution(widthRes, heightRes, FullScreenMode.Windowed);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnGUI()
    {
        scale += Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 20;

        if (EditorContentRect != null)
        {
            EditorContentRect.localScale = new Vector3(scale, scale);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("I was clicked");
    }

}
