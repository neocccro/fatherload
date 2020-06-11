using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;

    [SerializeField] private float horizontalMultiplier, verticalMultiplier;
    
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Chance<GameObject> chance = new Chance<GameObject>();
    }

    public void MoveRight()
    {
        rigidbody2D.AddForce(Vector2.right * horizontalMultiplier * Time.fixedDeltaTime);
    }

    public void MoveLeft()
    {
        rigidbody2D.AddForce(Vector2.left * horizontalMultiplier * Time.fixedDeltaTime);
    }

    public void MoveUp()
    {
        rigidbody2D.AddForce(Vector2.up * verticalMultiplier * Time.fixedDeltaTime);
    }

    public void MoveDown()
    {
    }
}
