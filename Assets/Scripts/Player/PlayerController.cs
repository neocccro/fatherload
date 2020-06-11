using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    private class klaas
    {
        public bool CalledLastFrame = false;
        public bool Called = false;
        public KeyCode key;
        public Action action;
        public klaas(KeyCode key, Action action)
        {
            this.key = key;
            this.action = action;
        }
    }

    private List<klaas> actions;

    private void LateUpdate()
    {
        foreach (klaas k in actions)
        {
            k.CalledLastFrame = k.Called;
            k.Called = false;
        }
    }

    private void Awake()
    {
        actions = new List<klaas>();
    }

    public void Do(KeyCode key)
    {
        foreach (klaas k in actions.Where(x => x.key == key))
        {
            k.action.Invoke();
            k.Called = true;
        }
    }

    public bool Did(Action action)
    {
        foreach (klaas k in actions.Where(x => x.action == action && x.CalledLastFrame == true))
        {
            return true;
        }
        return false;
    }

    public void Add(KeyCode key, Action action)
    {
        actions.Add(new klaas(key, action));
    }

    public void Remove(KeyCode key, Action action)
    {
        actions.RemoveAll(x => x.key == key && x.action == action);
    }
    public void Remove(KeyCode key)
    {
        actions.RemoveAll(x => x.key == key);
    }
    public void Remove(Action action)
    {
        actions.RemoveAll(x => x.action == action);
    }
}
