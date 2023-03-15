using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour
{
    DestroyEvent destroyEvent = new DestroyEvent();

    //Start is called before the first frame update
    void Start()
    {
        EventManager.AddDestroyEventInvoker(this);
    }

    public void AddDestroyEventListener(UnityAction listener)
    {
        destroyEvent.AddListener(listener);
    }

    public void HandleButtonClicked()
    {
        destroyEvent.Invoke();
    }
}
