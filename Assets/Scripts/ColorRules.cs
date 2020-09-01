using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorRules : MonoBehaviour
{
    public List<MyColors> colorList;


    private void Start() {
        InitalizeColors();
        MyColors blue = new MyColors("Blue", "0000FF", "belu");
        MyColors yellow = new MyColors("Yellow", "FFFF00", "ellowy");
       MyColors mynewcolor= MergeColors(blue, blue);
        Debug.Log(mynewcolor.name);
    }


    MyColors MergeColors(MyColors color1,MyColors color2) {
        string mergedString = color1.name.ToLower() + color2.name.ToLower();
       string orderedMergedString= new string(mergedString.OrderBy(c => c).ToArray());

        foreach (var color in colorList) {
            if (color.colorKey==orderedMergedString) {
                return color;
            }
        }
        return color1;
     
    }

    void InitalizeColors() {
        colorList = new List<MyColors>();
        MyColors red = new MyColors("Red", "FF0000", "der");
        colorList.Add(red);
        MyColors blue = new MyColors("Blue", "0000FF", "belu");
        colorList.Add(blue);
        MyColors yellow = new MyColors("Yellow", "FFFF00", "ellowy");
        colorList.Add(yellow); 
        MyColors green = new MyColors("Green", "00FF00", "beelllouwy");
        colorList.Add(green); 
        MyColors orange = new MyColors("Orange", "FFA500", "deellorwy");
        colorList.Add(orange); 
        MyColors purple = new MyColors("Purple", "800080", "bdeelru");
        colorList.Add(purple); 

    }



}


public class MyColors {
   public string name;
   public string colorCode;
   public string colorKey;

    public MyColors(string name, string colorCode, string colorKey) {
        this.name = name;
        this.colorCode = colorCode;
        this.colorKey = colorKey;
    }
}