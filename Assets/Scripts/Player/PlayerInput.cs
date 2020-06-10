using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerController playerController;

    private int[] values;
    private bool[] keys;

    void Awake()
    {
        values = (int[])System.Enum.GetValues(typeof(KeyCode));
        keys = new bool[values.Length];
    }

    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        for (int i = 0; i < values.Length; i++)
        {
            keys[i] = Input.GetKey((KeyCode)values[i]);
            if (keys[i])
            {
                playerController.Do((KeyCode)values[i]);
            }
        }
    }
}
