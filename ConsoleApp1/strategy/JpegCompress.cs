namespace ConsoleApp1.strategy;

public class JpegCompress : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Jpeg compress");
    }
}