using System;
using System.IO;

namespace GeneratorCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootdiv = new Group("div");
            Group username = new Group("div");
            Group UserName = new Group("p", "UserName:");
            UserName.AddTag(new Individual("input", "text"));
            username.AddTag(UserName);

            Group userpassword = new Group("div");
            Group UserPassword = new Group("p", "Password:");
            UserPassword.AddTag(new Individual("input", "password"));
            userpassword.AddTag(UserPassword);

            rootdiv.AddTag(username);
            rootdiv.AddTag(userpassword);
            rootdiv.AddTag(new Individual("input", "submit"));
            Console.WriteLine(rootdiv.display(" "));




                
        }
        public static void PrintDetail(string htmlScript)
        {
            string filePath = @"E:\SwabhavTech\C#\DesignPattern\Demo.html";
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, htmlScript);
            
        
        }
    }
}
