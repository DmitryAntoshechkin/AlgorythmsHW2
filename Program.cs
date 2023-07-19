using BenchmarkDotNet.Running;
//using ArrayUtils

namespace name11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(args, new BenchmarkDotNet.Configs.DebugInProcessConfig());

            BenchmarkRunner.Run<SortTests>();

            // int[] array = ArrayUtils.prepareArray(10);
       
            // for (int i =0; i < array.Length; ++i)
            // {
            //     Console.Write(array[i]+"\t");    
            // }
            // Console.WriteLine();

            // SortUtils.pyramSort(array);

            // for (int i =0; i < array.Length; ++i)
            // {
            //     Console.Write(array[i]+"\t");    
            // }
            // Console.WriteLine();

    }
}
}