using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using WPFApp;

public class CalkulatorScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    public void SetText()
    {
        _text.text += GetComponentInChildren<TextMeshProUGUI>().text;
    }
    public void GetAnswer()
    {
        var parser = new ExpressionParser();
        var t = _text.text;
        _text.text = parser.Execute(t).ToString();
    }
    public void Clear()
    {
        _text.text = "";
    }
}
