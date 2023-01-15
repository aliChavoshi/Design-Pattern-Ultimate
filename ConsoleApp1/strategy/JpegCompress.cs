namespace DesignPatterns.strategy;

public class JpegCompress : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Jpeg compress");
    }
}