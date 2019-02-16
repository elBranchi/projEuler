using System;

namespace projEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var defProblem = 4;

            var arg0 = args.Length > 0 ? args[0] : defProblem.ToString();
            int probNumber;
            if(!int.TryParse(arg0, out probNumber))
            {
                Console.WriteLine($"Unknown problem {arg0}");
                return;
            }

            var problemTypeName = $"projEuler.Problems.Problem{probNumber:0000}";


            //Console.WriteLine(problemTypeName);
            var problemType = Type.GetType(problemTypeName);

            if (problemType == null)
                return;
            var problem = (ProblemBase)Activator.CreateInstance(problemType);


            problem.Run();
            Console.ReadKey();
        }
    }
}
