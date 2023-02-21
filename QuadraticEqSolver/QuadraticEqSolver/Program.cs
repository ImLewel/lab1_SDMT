float a, b, c, D, x1, x2;
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());

D = b * b - 4 * a * c;

if (D > 0) {
  x1 = (-b - MathF.Sqrt(D)) / (2 * a);
  x2 = (-b + MathF.Sqrt(D)) / (2 * a);
  Console.WriteLine($"There are two roots \n" +
    $"x1: {x1} \n" +
    $"x2: {x2}");
}
if (D < 0) Console.WriteLine("There are 0 roots");
if (D == 0) {
  x1 = (-b + MathF.Sqrt(D)) / (2 * a);
  Console.WriteLine($"There is 1 root \n" +
    $"x: {x1}");
}
