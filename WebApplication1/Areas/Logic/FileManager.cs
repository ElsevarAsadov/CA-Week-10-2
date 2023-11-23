namespace WebApplication1.Areas.Logic
{
    public class FileManager
    {
        public IFormFile File { get; }
        public FileManager(IFormFile file)
        {
            File = file;
        }


        public void SaveFile(string path, FileMode modes)
        {
            using(FileStream fs = new FileStream(path, modes))
            {
                File.CopyTo(fs);
            }
        }

        public static string GetImageGUIDForm(string filePath)
        {
            return filePath;
        }
    }
}
