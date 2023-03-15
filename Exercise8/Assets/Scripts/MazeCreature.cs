using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCreature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.AddDestroyEventListener(HandleDestroyEvent);
    }

    void HandleDestroyEvent()
    {
        Destroy(gameObject);
    }
}