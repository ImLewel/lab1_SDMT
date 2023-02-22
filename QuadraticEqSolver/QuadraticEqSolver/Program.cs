using System.Globalization;

namespace QuadraticEqSolver {
  class Program {
    static void Main(string[] args) {
      CultureInfo ci = new CultureInfo("en-US");
      ci.NumberFormat.CurrencyDecimalSeparator = ".";

      float[] coeffs = new float[3];
      float temp = 0;
      float D, x1, x2;
      bool interactiveMode;
      string[] fileData = new string[3];
      string[] coeffNames = new string[3] {"a", "b", "c"};

      if (args.Length != 0 && File.Exists(args[0])) {
        interactiveMode = false;
        fileData = File.ReadAllText(args[0]).Split(" ");
      }
      else
        interactiveMode = true;


      void Setup() {
        for (int i = 0; i < coeffs.Length; ++i) {
          if (interactiveMode) {
            Console.WriteLine($"Enter {coeffNames[i]}:");
            while (Interactive(i) == false)
              Console.WriteLine($"Enter {coeffNames[i]}:");
          }
          else if (NotInteractvie(i, fileData) == false)
            return;
          coeffs[i] = temp;
        }
        Console.WriteLine(
          string.Format(
            ci,
            "Solve {0:0.###}x²{1:+0.###;-0.###;+0}x{2:+0.###;-0.###;+0}=0", 
            coeffs[0], coeffs[1], coeffs[2]
          )
        );
        Solve(coeffs[0], coeffs[1], coeffs[2]);
      }

      bool Interactive(int i) {
        string response = Console.ReadLine() ?? "";
        if (response == "") {
          Console.WriteLine("Error. Empty answer");
          return false;
        }
        else if (float.TryParse(response, NumberStyles.Float | NumberStyles.AllowDecimalPoint, ci, out temp)) {
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

      bool NotInteractvie(int i, string[] toTest) {
        if (toTest.Length < 3 || toTest[i] == "") {
          Console.WriteLine("Error. Missing some data");
          return false;
        }
        else if (float.TryParse(toTest[i], NumberStyles.Float | NumberStyles.AllowDecimalPoint, ci, out temp)) {
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
          Console.WriteLine($"There are two roots \n x1: {x1:0.###} \n x2: {x2:0.###}");
        }
        if (D < 0)
          Console.WriteLine("There are 0 roots");
        if (D == 0) {
          x1 = (-b + MathF.Sqrt(D)) / (2 * a);
          Console.WriteLine($"There is 1 root \n x: {x1:0.###}");
        }
      }

      Setup();
      Console.ReadLine();
    }
  }
}
