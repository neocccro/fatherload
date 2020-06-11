using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mining : MonoBehaviour
{
    [SerializeField] float karelThreshold;
    private float karelLeft;
    private float karelRight;
    private float karelDown;

    private PlayerController playerController;
    private PlayerMovement playerMovement;
    private PlayerWallDetection playerWallDetection;
    [SerializeField] private Tilemap tilemap;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
        playerMovement = GetComponent<PlayerMovement>();
        playerWallDetection = GetComponent<PlayerWallDetection>();
    }
    
    void Update()
    {
        //when holding move
        //if(grounded && wall in direction of move)
        if (playerController.Did(playerMovement.MoveLeft) && playerWallDetection.Down() && playerWallDetection.Left())
        {
            karelLeft += Time.deltaTime;
        }
        else
        {
            karelLeft = 0;
        }

        if (playerController.Did(playerMovement.MoveRight) && playerWallDetection.Down() && playerWallDetection.Right())
        {
            karelRight += Time.deltaTime;
        }
        else
        {
            karelRight = 0;
        }

        if (playerController.Did(playerMovement.MoveDown) && playerWallDetection.Down())
        {
            karelDown += Time.deltaTime;
        }
        else
        {
            karelDown = 0;
        }
        ///////////////
        if (karelLeft > karelThreshold)
        {
            karelLeft = 0;
            mineLeft();
        }
        if (karelRight > karelThreshold)
        {
            karelRight = 0;
            mineRight();
        }
        if (karelDown > karelThreshold)
        {
            karelDown = 0;
            mineDown();
        }
    }

    public void mineLeft()
    {
        Debug.Log("mineLeft");
        tilemap.SetTile(tilemap.WorldToCell(transform.position + Vector3.left), null);
    }
    public void mineRight()
    {
        Debug.Log("mineRight");
        tilemap.SetTile(tilemap.WorldToCell(transform.position + Vector3.right), null);
    }
    public void mineDown()
    {
        Debug.Log("mineDown");
        tilemap.SetTile(tilemap.WorldToCell(transform.position + Vector3.down), null);
    }
}
