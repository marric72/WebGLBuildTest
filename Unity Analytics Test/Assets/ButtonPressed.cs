using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour
{
    public Text myLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fcn1()
    {
        myLabel.GetComponent<Text>().text = "Button1 Pressed";
    }
    public void Fcn2()
    {
        myLabel.GetComponent<Text>().text = "Button2 Pressed";
    }
}
