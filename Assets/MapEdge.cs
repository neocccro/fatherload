using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEdge : MonoBehaviour
{
    [SerializeField] Transform[] playersPossies;
    [SerializeField] float maxHeight;

    Mapmaker mapmaker;

    Vector2 height;
    Vector2 width;


    private void Start()
    {
        mapmaker = GetComponent<Mapmaker>();
        height = new Vector2(-mapmaker.height + 0.6f, 10);
        width = new Vector2(-mapmaker.width / 2 + 0.6f, mapmaker.width / 2 - 0.6f);
    }

    void LateUpdate()
    {
        foreach (Transform playerPos in playersPossies)
        {
            if (true)
            {
                playerPos.position = new Vector3(Mathf.Clamp(playerPos.position.x, width.x, width.y), Mathf.Clamp(playerPos.position.y, height.x, height.y), 0);
            }
        }
    }
}
