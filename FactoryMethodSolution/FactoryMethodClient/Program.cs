using FactoryMethodLib;
using FactoryMethodLib.Factory;
using FactoryMethodLib.Product;
using System;
using System.Reflection;

namespace FactoryMethodClient
{
    public class Program
    {
        public static object ConfigurationManager { get; private set; }

        public static void Main(String[] args)
        {
            IAutoFactory factory = new IAutoFactory();
            IAuto auto = (IAuto)factory.Make();
            auto.Start();
            auto.Stop();

            Console.WriteLine("\nHash code of factory:{0}", factory.GetHashCode());
            IAutoFactory factory1 = GetFactoryFromAppConfig();
            Console.WriteLine("\nHash code of factory1:{0}", factory1.GetHashCode());
        }

        private static IAutoFactory GetFactoryFromAppConfig()
        {
            Assembly asm = typeof(IAutoFactory).Assembly;
            var asmName = asm.GetName();
            Type calledType = Type.GetType(ConfigurationManager.AppSettings["factory"]+" , "+asmName);

            IAutoFactory factory = calledType.InvokeMember("GetInstance",
                BindingFlags.InvokeMethod |
                BindingFlags.Public |
                BindingFlags.Static,
                null,
                null,
                null) as IAutoFactory;
            return factory;
        }

      
    }
}
