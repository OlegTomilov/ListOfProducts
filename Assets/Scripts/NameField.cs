using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameField : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private string _product;
    private bool _isBuy = false;

    public void InputText(string userInput)
    {
        _product = userInput;
    }

    public void Strikethrough()
    {
        if (_isBuy != true)
        {
            _text.fontStyle = FontStyles.Strikethrough;
            _isBuy = true;
        }
        else
        {
            _text.fontStyle = FontStyles.Normal;
            _isBuy = false;
        }
    }
}
