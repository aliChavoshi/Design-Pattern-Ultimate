namespace DesignPatterns.strategy;

public class PngCompressor : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("png compressor");
    }
}