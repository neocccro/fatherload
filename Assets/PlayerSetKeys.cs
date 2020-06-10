using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetKeys : MonoBehaviour
{
    [SerializeField] private KeyCode left, right, up;

    private PlayerMovement playerMovement;
    private PlayerController playerController;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerController = GetComponent<PlayerController>();

        playerController.SetKey(left, playerMovement.MoveLeft);
        playerController.SetKey(right, playerMovement.MoveRight);
        playerController.SetKey(up, playerMovement.MoveUp);
    }
}
