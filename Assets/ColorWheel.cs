using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorWheel
{
    public static Color GetColor(float input)
    {
        float r, g, b;
        r = g = b = 0;

        input *= 6;

        if (input < 1)
        {
            r = 0;
            g = 1;
            b = input;
        }
        else if (input < 2)
        {
            input -= 1;
            r = 0;
            g = 1 - input;
            b = 1;
        }
        else if (input < 3)
        {
            input -= 2;
            r = input;
            g = 0;
            b = 1;
        }
        else if (input < 4)
        {
            input -= 3;
            r = 1;
            g = 0;
            b = 1 -input;
        }
        else if (input < 5)
        {
            input -= 4;
            r = 1;
            g = input;
            b = 0;
        }
        else
        {
            input -= 5;
            r = 1 - input;
            g = 1;
            b = 0;
        }
        return new Color(r, g, b);
    }
}
