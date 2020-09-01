using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tube : MonoBehaviour
{
    public string tubeColor;
    public MyColors myColor;
    public ColorRules rules;
    public Image fillImage;
    public Color color;
    void Start()
    {
        myColor = rules.GetCorrectColor(tubeColor);
        ColorUtility.TryParseHtmlString(myColor.colorCode, out color);
        fillImage.color = color;

    }


}
