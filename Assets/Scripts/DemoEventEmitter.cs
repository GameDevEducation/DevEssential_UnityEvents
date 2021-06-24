using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// You may need to use this syntax in older unity versions
[System.Serializable] public class StringEvent : UnityEvent<string> {}

public class DemoEventEmitter : MonoBehaviour
{
    [SerializeField] UnityEvent OnSomethingHappened = new UnityEvent();
    [SerializeField] UnityEvent<float> OnFloatHappened = new UnityEvent<float>();
    [SerializeField] StringEvent OnStringHappened = new StringEvent();
    [SerializeField] UnityEvent<string, float> OnStringFloatHappened = new UnityEvent<string, float>();

    [SerializeField] bool DEBUG_SendSomethingHappened = false;
    [SerializeField] bool DEBUG_SendFloatHappened = false;
    [SerializeField] bool DEBUG_SendStringHappened = false;
    [SerializeField] bool DEBUG_SendStringFloatHappened = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // debug sending of something happened requested?
        if (DEBUG_SendSomethingHappened)
        {
            DEBUG_SendSomethingHappened = false;

            // invoke the OnSomethingHappened event (ie. notifies all listeners of the event)
            OnSomethingHappened.Invoke();
        }

        // debug sending of float happened requested?
        if (DEBUG_SendFloatHappened)
        {
            DEBUG_SendFloatHappened = false;

            // invoke the OnFloatHappened event (ie. notifies all listeners of the event)
            OnFloatHappened.Invoke(Random.Range(0f, 100f));
        }   

        // debug sending of string happened requested?
        if (DEBUG_SendStringHappened)
        {
            DEBUG_SendStringHappened = false;

            // invoke the OnStringHappened event (ie. notifies all listeners of the event)
            OnStringHappened.Invoke(Random.Range(0f, 100f).ToString());
        }      

        // debug sending of string float happened requested?
        if (DEBUG_SendStringFloatHappened)
        {
            DEBUG_SendStringFloatHappened = false;

            // invoke the OnStringFloatHappened event (ie. notifies all listeners of the event)
            OnStringFloatHappened.Invoke("String float happened", Random.Range(0f, 100f));
        }                     
    }
}
