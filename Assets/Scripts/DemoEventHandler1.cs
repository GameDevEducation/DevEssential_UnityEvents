using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoEventHandler1 : MonoBehaviour
{
    [SerializeField] Button DemoButton;
    [SerializeField] Slider DemoSlider;

    // Start is called before the first frame update
    void Start()
    {
        DemoButton.onClick.AddListener(delegate { OnClickEvent_LessSimpleData("Delegate message", 57.14f); });
        DemoSlider.onValueChanged.AddListener(delegate { OnChangedEvent_MultipleParameters(124.9f, "Test delegate"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEvent_NoData()
    {
        Debug.Log("OnClickEvent_NoData");
    }

    public void OnClickEvent_SimpleData(string message)
    {
        Debug.Log("OnClickEvent_SimpleData: " + message);
    }    

    public void OnClickEvent_LessSimpleData(string message, float value)
    {
        Debug.Log("OnClickEvent_LessSimpleData: " + message + " " + value);
    }

    public void OnChangedEvent_NoData()
    {
        Debug.Log("OnChangedEvent_NoData");
    }

    public void OnChangedEvent_SingleFloat(float newValue)
    {
        Debug.Log("OnChangedEvent_SingleFloat " + newValue);
    }

    public void OnChangedEvent_MultipleParameters(float newValue, string message)
    {
        Debug.Log("OnChangedEvent_MultipleParameters " + message + " " + newValue);
    }
}
