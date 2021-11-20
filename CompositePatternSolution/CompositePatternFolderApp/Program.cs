using System;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folder = new Folder("Movice");
            folder.AddChild(new File("titanic", "700MB"));

            Folder comedy = new Folder("Comedy");
            folder.AddChild(comedy);
            comedy.AddChild(new File("3 idiots", "800MB"));
            folder.display();
        }
    }
}
