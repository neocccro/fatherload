using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    private float karel;
    [SerializeField] float karelThreshold;

    private PlayerController playerController;
    private PlayerMovement playerMovement;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    
    void Update()
    {
        Debug.Log(playerController.Did(playerMovement.MoveRight));

        //when holding move
        //if(grounded && wall in direction of move)
        if (true)
        {
            karel += Time.deltaTime;
        }
        else
        {
            karel = 0;
        }

        if (karel > karelThreshold)
        {
            mine();
        }
    }

    public void mine()
    {

    }
}
