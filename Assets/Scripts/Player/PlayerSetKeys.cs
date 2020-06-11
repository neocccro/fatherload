using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetKeys : MonoBehaviour
{
    [SerializeField] private KeyCode left, right, up, down;

    private PlayerMovement playerMovement;
    private PlayerController playerController;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerController = GetComponent<PlayerController>();
    }

    private void Start()
    {
        playerController.Add(left, playerMovement.MoveLeft);
        playerController.Add(right, playerMovement.MoveRight);
        playerController.Add(up, playerMovement.MoveUp);
    }
}
