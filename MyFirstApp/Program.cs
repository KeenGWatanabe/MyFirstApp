internal class Program
{
    public static void Main()
    {
        float vat = 19f;
        float productA = 3.99f;
        float productB = 11.99f;
        float productC = 5.75f;

        float summed = productA + productB + productC;
        float totalTax = (summed /100  ) * vat;
        Console.WriteLine("summed " + summed + " and totalTax " + totalTax);

        summed += totalTax;
        Console.WriteLine("Total price with vat is " + summed);
    }
}