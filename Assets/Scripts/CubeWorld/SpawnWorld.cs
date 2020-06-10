using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWorld : MonoBehaviour
{
    [SerializeField]
    private float width, height;

    BlockFactory blockFactory;

    void Start()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
        }
        blockFactory = FindObjectOfType<BlockFactory>();
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void Spawn()
    {
        GameObject temp = null;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                temp = blockFactory.GetBlock();
                temp.transform.position = new Vector3(x - width / 2 + 0.5f, -y, 0);
            }
        }
    }
}
