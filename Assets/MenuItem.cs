using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuItem : MonoBehaviour
{
    private Action _buttonAction;

    public Text ButtonText;

    public void Initialize(string text, Action action) {
        _buttonAction = action;
        ButtonText.text = text;
    }

    public void MenuButtonClicked()
    {
        _buttonAction();
    }

}
