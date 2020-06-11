using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerWallDetection : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;

    public bool Down()
    {
        if (tilemap.GetTile(tilemap.WorldToCell(transform.position + Vector3.down)) != null)
        {
            return true;
        }
        return false;
    }

    public bool Left()
    {
        if (tilemap.GetTile(tilemap.WorldToCell(transform.position + Vector3.left)) != null)
        {
            return true;
        }
        return false;
    }

    public bool Right()
    {
        if (tilemap.GetTile(tilemap.WorldToCell(transform.position + Vector3.right)) != null)
        {
            return true;
        }
        return false;
    }

    public bool Up()
    {
        if (tilemap.GetTile(tilemap.WorldToCell(transform.position + Vector3.up)) != null)
        {
            return true;
        }
        return false;
    }




}
