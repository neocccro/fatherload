using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chance<T>
{
    private class ChanceObject
    {
        public T obj;
        public float chance;
        public ChanceObject(T obj, float chance)
        {
            this.obj = obj;
            this.chance = chance;
        }
    }

    private float totalChance;
    private List<ChanceObject> chanceObjects;

    public void AddChanceObject(T obj, float chance)
    {
        chanceObjects.Add(new ChanceObject(obj, chance));
        Recalc();
    }

    public void RemoveChanceObject(T obj)
    {
        ChanceObject chanceObject = chanceObjects.Find(i => i.obj.Equals(obj));
        chanceObjects.Remove(chanceObject);
        Recalc();
    }

    private void Recalc()
    {
        for (int i = 0; i < chanceObjects.Count; i++)
        {
            totalChance += chanceObjects[i].chance;
        }
    }

    public T Get()
    {
        T output = default;
        if (chanceObjects != null)
        {
            float temp = chanceObjects[0].chance;
            float random = Random.Range(0, totalChance);
            for (int i = 0; i < chanceObjects.Count; i++)
            {
                if (random < temp)
                {
                    output = chanceObjects[i].obj;
                    break;
                }
                else
                {
                    temp += chanceObjects[i + 1].chance;
                }
            }
        }
        return output;
    }
}
