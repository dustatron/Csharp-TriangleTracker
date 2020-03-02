namespace TriangleTracker.Models
{
  public class Triangle
  {
    public static string IsTriangle(int sideA, int sideB, int sideC)
    {
      if (sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA)
      {
        if (sideA == sideB && sideB == sideC)
        {
          return "equilateral";
        }
        else if (sideA == sideB || sideB == sideC || sideC == sideA)
        {
          return "isoceles";
        }
        else
        {
          return "scalene";
        }
      }
      else
      {
        return "not a triangle";
      }
    }
  }
}
