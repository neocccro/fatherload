using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    private Dictionary<KeyCode, Action> actions;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        actions = new Dictionary<KeyCode, Action>();
    }

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void Do(KeyCode key)
    {
        if(actions.ContainsKey(key))
        {
            actions[key].Invoke();
        }
    }

    public void SetKey(KeyCode key, Action action)
    {
        actions.Add(key, action);
    }
}
