using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    /***
     * ΩÃ±€≈Ê ∆–≈œ¿∏∑Œ ¿ŒΩ∫≈œΩ∫»≠
     */
    public static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (!_instance)
            {
                new UIManager();
            }
            return _instance;
        }
    }

    public void Awake()
    {
        UIManager._instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject _imageStart;

    GameObject ImageStart
    {
        get {
            if (!_imageStart) _imageStart = GameObject.Find("ImageStart");
            return _imageStart; 
        }
    }

    GameObject _menuCreate;

    GameObject menuCreate
    {
        get {
            if (!_menuCreate) _menuCreate = ImageStart.transform.Find("MenuCreate").gameObject;
            return _menuCreate; 
        }
    }

    GameObject _menuContinue;

    GameObject menuContinue
    {
        get
        {
            if (!_menuContinue) _menuContinue = ImageStart.transform.Find("MenuContinue").gameObject;
            return _menuContinue;
        }
    }

    GameObject _inputName;

    public GameObject inputName
    {
        get {
            if (!_inputName)
            {
                _inputName = menuCreate.transform.Find("ImageMenuFocus").Find("InputName").gameObject;
            }
            return _inputName; 
        }
    }

    /***
     * ƒ≥∏Ø≈Õ ª˝º∫ »≠∏È¿∏∑Œ ¿¸»Ø
     */
    public void onCreateCharacter()
    {
        
        menuCreate.SetActive(true);
        menuContinue.SetActive(false);

        TMP_InputField inputField = inputName.GetComponent<TMP_InputField>();

        inputField.characterLimit = 8;
        inputField.onValueChanged.AddListener(
            (word) => inputField.text = Regex.Replace(word, @"[^0-9a-zA-Z∞°-∆R]", "")
        );

    }

    void OnGameStart()
    {

    }

    

}
