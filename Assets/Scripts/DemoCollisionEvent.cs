using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DemoCollisionEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnHitGround = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        // send event if we hit the ground
        if (other.gameObject.CompareTag("Ground"))
            OnHitGround.Invoke();
    }
}
