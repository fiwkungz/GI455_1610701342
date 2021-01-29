using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMatchingScript : MonoBehaviour
{
    public Button searchText;
    public InputField Txtinput;
    public Text resalt;  
    public string[] Text = new string[5];

    public void search_btn()
    {
        if (Text[0] == Txtinput.text)
        {
            resalt.text = Txtinput.text + " Is Found ";
        }
        else if (Text[1] == Txtinput.text)
        {
            resalt.text = Txtinput.text + " Is Found ";
        }
        else if (Text[2] == Txtinput.text)
        {
            resalt.text = Txtinput.text + " Is Found ";
        }
        else if (Text[3] == Txtinput.text)
        {
            resalt.text = Txtinput.text + " Is Found ";
        }
        else if (Text[4] == Txtinput.text)
        {
            resalt.text = Txtinput.text + " Is Found ";
        }
        else
        {
            resalt.text = Txtinput.text + " Is Not Found ";
        }
    }
}
