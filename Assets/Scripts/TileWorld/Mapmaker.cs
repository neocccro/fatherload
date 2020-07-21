using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mapmaker : MonoBehaviour
{
    [SerializeField] public int width;
    [SerializeField] public int height;

    [SerializeField] private Tilemap tilemapOre;
    [SerializeField] private Tilemap tilemapDirt;
    [SerializeField] private Tilemap tilemapBackground;

    [SerializeField] private RuleTile tile;
    [SerializeField] private Vector3 startPoint;
    private Vector3Int Base;


    void Awake()
    {
        Base = tilemapDirt.WorldToCell(startPoint);
    }

    private void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                tilemapDirt.SetTile(Base + new Vector3Int(width / 2 - x - 1, -y, 0), tile);
                tilemapBackground.SetTile(Base + new Vector3Int(width / 2 - x - 1, -y, 0), tile);
            }
        }
    }
}
