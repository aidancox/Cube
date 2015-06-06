using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour 
{
    public Camera camera;
    public Light light;

    public Color rgb;

    void Start()
    {
        rgb = camera.backgroundColor;
    }

    void Update()
    {
        if(rgb.r == 1 && rgb.b == 0 && rgb.g < 1)
        {
            rgb += new Color(0, 0.01f, 0);
        }

        if (rgb.g == 1 && rgb.b == 0 && rgb.r > 0)
        {
            rgb += new Color(-0.01f, 0, 0);
        }

        if (rgb.r == 0 && rgb.g == 1 && rgb.b < 1)
        {
            rgb += new Color(0, 0, 0.01f);
        }

        if (rgb.r == 0 && rgb.b == 1 && rgb.g > 0)
        {
            rgb += new Color(0, -0.01f, 0);
        }

        if (rgb.g == 0 && rgb.b == 1 && rgb.r < 1)
        {
            rgb += new Color(0.01f, 0, 0);
        }

        if (rgb.g == 0 && rgb.r == 1 && rgb.b > 0)
        {
            rgb += new Color(0, 0, -0.01f);
        }

        camera.backgroundColor = rgb;
        light.color = rgb;

        if(rgb.r < 0)
        {
            rgb.r = 0;
        }
        if (rgb.r > 1)
        {
            rgb.r = 1;
        }
        if (rgb.g < 0)
        {
            rgb.g = 0;
        }
        if (rgb.g > 1)
        {
            rgb.g = 1;
        }
        if (rgb.b < 0)
        {
            rgb.b = 0;
        }
        if (rgb.b > 1)
        {
            rgb.b = 1;
        }
    }
}
