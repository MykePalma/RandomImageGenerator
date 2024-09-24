using System.Drawing;

namespace ContentGenerator;

public class ColorMap
{
    public Random _random { get; set; }
    private List<Color> Colors { get; set; }

    public ColorMap()
    {
        _random = new Random();
        Colors = [];

        for (int i = 0; i < 14; i++)
        {
            Colors.Add(GenerateRandomColor());
        }
    }

    public Color GetColor(float v)
    {
        if (v < -0.35)
        {
            return Colors[0];
        }
        else if (v < -0.25)
        {
            return Colors[1];
        }
        else if (v < -0.15)
        {
            return Colors[2];
        }
        else if (v < -0.1)
        {
            return Colors[3];
        }
        else if (v < 0.0)
        {
            return Colors[4];
        }
        else if (v < 0.1)
        {
            return Colors[5];
        }
        else if (v < 0.2)
        {
            return Colors[6];
        }
        else if (v < 0.5)
        {
            return Colors[7];
        }
        else if (v < 0.7)
        {
            return Colors[8];
        }
        else if (v < 0.8)
        {
            return Colors[9];
        }
        else if (v < 0.85)
        {
            return Colors[10];
        }
        else if (v < 0.90)
        {
            return Colors[11];
        }
        else if (v <= 0.9995)
        {
            return Colors[12];
        }
        else if (v <= 1.0 - 0.000001)
        {
            return Colors[13];
        }
        else
        {
            return Colors[0];
        }
    }

    private Color GenerateRandomColor()
    {
        return Color.FromArgb(255, _random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255));
    }
}