using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    #region Fields

    static DestroyButton destroyEventInvoker;
    static UnityAction destroyEventListener;

    #endregion

    #region Unity Methods

    #endregion


    #region Public Methods

    public static void AddDestroyEventInvoker(DestroyButton invoker)
    {
        destroyEventInvoker = invoker;

        if (destroyEventListener != null)
        {
            destroyEventInvoker.AddDestroyEventListener(destroyEventListener);
        }
    }

    public static void AddDestroyEventListener(UnityAction listener)
    {
        destroyEventListener = listener;

        if (destroyEventInvoker != null)
        {
            destroyEventInvoker.AddDestroyEventListener(destroyEventListener);
        }
    }

    #endregion
}
