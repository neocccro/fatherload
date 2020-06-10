using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Start()
    {
        Chance<Chance<GameObject>> chance = new Chance<Chance<GameObject>>();
        Debug.Log(chance.Get());
        Debug.Log(chance.Get() == null);
    }




    public Rigidbody2D rigidbody2D;

    [SerializeField] private float horizontalMultiplier, verticalMultiplier;


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
}
