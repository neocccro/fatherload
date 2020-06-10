using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockFactory : MonoBehaviour
{
    [Serializable]
    private class Block
    {
        public GameObject prefab;
        public float chance;
    }

    [SerializeField]
    private Block[] blocks;

    private float totalChance;

    void Awake()
    {
        for (int i = 0; i < blocks.Length; i++)
        {
            totalChance += blocks[i].chance;
        }
    }

    public GameObject GetBlock()
    {
        GameObject output = null;
        if (blocks != null)
        {
            float temp = blocks[0].chance;
            float random = Random.Range(0, totalChance);
            for (int i = 0; i < blocks.Length; i++)
            {
                if(random < temp)
                {
                    output = Instantiate(blocks[i].prefab);
                    break;
                }
                else
                {
                    temp += blocks[i+1].chance;
                }
            }
        }
        return output;
    }
}
