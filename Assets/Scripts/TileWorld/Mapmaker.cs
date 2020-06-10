using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mapmaker : MonoBehaviour
{
    public RuleTile tile;
    public Tilemap tilemap;

    public int egh;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        //Vector3Int currentCell = tilemap.WorldToCell(Vector3.zero);
        //tilemap.SetTile(currentCell, tile);
    }

    // Update is called once per frame
    void Update()
    {
        if (egh % 10 == 0)
        {
            tilemap.SetTile(tilemap.WorldToCell(Vector3.zero + new Vector3((egh/10f) % 10f, egh / 100, 0)), tile);
        }
        egh++;
    }
}
