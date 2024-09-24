using Generation.Noise;
using System.Drawing;
using static Generation.Noise.FastNoiseLite;

namespace ContentGenerator;

public class NoiseImageGenerator
{
    private readonly int _size;
    private readonly NoiseType _noiseType;
    private readonly FractalType _fractalType;
    private readonly float _frequency;
    private readonly int _octaves;

    public Random RandomNumber { get; set; }
    public ColorMap ColorMap { get; set; }

    public NoiseImageGenerator(int? size)
    {
        RandomNumber = new Random();
        ColorMap = new ColorMap();
        _size = size ?? 1024;
        _noiseType = NoiseType.OpenSimplex2;
        _fractalType = FractalType.FBm;
        _frequency = 0.005f;
        _octaves = 8;
    }

    public NoiseImageGenerator(int size, NoiseType noiseType, FractalType fractalType, float frequency, int octaves)
    {
        RandomNumber = new Random();
        ColorMap = new ColorMap();
        FastNoiseLite noise = new(RandomNumber.Next(1, 20000));
        _size = size;
        _noiseType = noiseType;
        _fractalType = fractalType;
        _frequency = frequency;
        _octaves = octaves;
    }

    public void Generate()
    {
        FastNoiseLite noise = new(RandomNumber.Next(1, 20000));

        noise.SetNoiseType(_noiseType);
        noise.SetFractalType(_fractalType);
        noise.SetFrequency(_frequency);
        noise.SetFractalOctaves(_octaves);

        int sizeX = _size;
        int sizeY = _size;

        Bitmap bmp = new(sizeX, sizeY);

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                float calc1 = noise.GetNoise(x, y);
                bmp.SetPixel(x, y, color: ColorMap.GetColor(calc1));
            }
        }

        SaveBitmapToFile(bmp);
    }

    private void SaveBitmapToFile(Bitmap bmp)
    {
        using (var stream = new MemoryStream())
        {
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] byteArray = stream.ToArray();

            string folderPath = Path.Combine(Environment.CurrentDirectory, "Generated\\");

            if (!File.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = folderPath + string.Join(".", _size.ToString(), _noiseType.ToString(), _fractalType.ToString(), Guid.NewGuid() + ".jpg");

            var newfile = File.OpenWrite(filePath);

            newfile.Write(byteArray, 0, byteArray.Length);
        }
    }

    private Color GenerateRandomColor()
    {
        return Color.FromArgb(255, RandomNumber.Next(0, 255), RandomNumber.Next(0, 255), RandomNumber.Next(0, 255));
    }
}
