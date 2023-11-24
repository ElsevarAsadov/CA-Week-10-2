using WebApplication1.Areas.Admin.Logic;
using System;
namespace WebApplication1.Areas.Admin.Logic
{
    public class Program
    {
        public static void Main()
        {
            string test1 = "hello.jpg";
            string a = FormFileManager.ConvertUniqueName(test1);
            string b = FormFileManager.ConvertUniqueName(test1, 2);

            string test2 = "helooos.jpg";
            string c = FormFileManager.ConvertUniqueName(test2);
            string d = FormFileManager.ConvertUniqueName(test2, 100);

            Console.WriteLine("SA");
        }
    }
}
