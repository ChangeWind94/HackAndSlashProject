using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SystemManager : MonoBehaviour
{

    Texture2D cursorImg;

    // Start is called before the first frame update
    void Start()
    {
        cursorImg = Resources.Load<Texture2D>("Images/Cursors/cursor.png");
        changeCurcer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeCurcer()
    {
        
        Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
    }

}
