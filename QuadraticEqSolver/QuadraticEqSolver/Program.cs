namespace QuadraticEqSolver {
  class Program {
    static void Main(string[] args) {

      float[] koefs = new float[3];
      float temp = 0;
      float D, x1, x2;

      void Setup() {
        for (int i = 0; i < koefs.Length; ++i) {
          while (ValueTester(i) == false) { }
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
    }
  }
}
