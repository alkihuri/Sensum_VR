using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data;//import this namespace


public class CalkulatorScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    public void SetText()
    {
        _text.text += GetComponentInChildren<TextMeshProUGUI>().text;
    }
    public void GetAnswer()
    {
        var t = _text.text;
        string value = new DataTable().Compute(t, null).ToString();
        _text.text = value;
    }
    public void Clear()
    {
        _text.text = "";
    }
}
