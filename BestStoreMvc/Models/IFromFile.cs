
namespace Microsoft.AspNetCore.Http
{
    public interface IFromFile
    {
        string Name { get; }    

        String FileName { get; }    
        string? File { get; set; }

        void CopyTo(FileStream stream);
        void CopyTo(Stream stream);
    }
}