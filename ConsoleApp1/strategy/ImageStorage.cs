namespace DesignPatterns.strategy;

public class ImageStorage
{
    private readonly ICompressor _compressor;
    private readonly IFilter _filter;

    public ImageStorage(ICompressor compressor, IFilter filter)
    {
        _compressor = compressor;
        _filter = filter;
    }

    public void Save(string fileName)
    {
        _compressor.Compress();
        _filter.Apply();
        Console.WriteLine("save file");
    }
}