using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

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
        //an example of sending a string to Analytics
        AnalyticsResult result=Analytics.CustomEvent("Button1 pressed");
        Debug.Log("analyticsResult:" + result);
    }
    public void Fcn2()
    {
        myLabel.GetComponent<Text>().text = "Button2 Pressed";
        //an example of sending a dictionary to Analytics
        AnalyticsResult result = Analytics.CustomEvent(
            "ButtonPressInfo",
            new Dictionary<string, object>{
                { "Button", "2" },
                { "UserID", "TBD" } });

                ;
        Debug.Log("analyticsResult:" + result);
    }
}
