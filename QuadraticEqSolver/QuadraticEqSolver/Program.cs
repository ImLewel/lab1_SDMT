

namespace QuadraticEqSolver {
  class Program {
    static void Main(string[] args) {
      float[] koefs = new float[3];
      float temp = 0;
      float D, x1, x2;
      bool interactiveMode;
      string[] fileData = new string[3];

      if (args.Length != 0 && File.Exists(args[0])) {
        interactiveMode = false;
        fileData = File.ReadAllText(args[0]).Split(" ");
      }
      else
        interactiveMode = true;


      void Setup() {
        for (int i = 0; i < koefs.Length; ++i) {
          if (interactiveMode)
            while (ValueTester(i) == false) { }
          else NInterValueTester(i, fileData);
          koefs[i] = temp;
        }
      }

      bool ValueTester(int i) {
        string response = Console.ReadLine();
        if (response == "") {
          Console.WriteLine("Error. Empty answer");
          return false;
        }
        else if (float.TryParse(response, out temp)) {
          if (i == 0 && temp == 0) {
            Console.WriteLine("a can't be zero");
            return false;
          }
          else
            return true;
        }
        else {
          Console.WriteLine($"Error. Expected a valid real number, got {response} instead");
          return false;
        }
      }

      bool NInterValueTester(int i, string[] toTest) {
        if (toTest[i] == "" || toTest[i] == null) {
          Console.WriteLine("Error. Empty koef");
          return false;
        }
        else if (float.TryParse(toTest[i], out temp)) {
          if (i == 0 && temp == 0) {
            Console.WriteLine("a can't be zero");
            return false;
          }
          else
            return true;
        }
        else {
          Console.WriteLine($"Error. Expected a valid real number, got {toTest[i]} instead");
          return false;
        }
      }

      float FindDiscriminant(float a, float b, float c) => (b * b) - (4 * a * c);

      void Solve(float a, float b, float c) {
        D = FindDiscriminant(a, b, c);
        if (D > 0) {
          x1 = (-b - MathF.Sqrt(D)) / (2 * a);
          x2 = (-b + MathF.Sqrt(D)) / (2 * a);
          Console.WriteLine($"There are two roots \n x1: {x1} \n x2: {x2}");
        }
        if (D < 0)
          Console.WriteLine("There are 0 roots");
        if (D == 0) {
          x1 = (-b + MathF.Sqrt(D)) / (2 * a);
          Console.WriteLine($"There is 1 root \n x: {x1}");
        }
      }

      Setup();
      Solve(koefs[0], koefs[1], koefs[2]);
      Console.ReadLine();
    }
  }
}
