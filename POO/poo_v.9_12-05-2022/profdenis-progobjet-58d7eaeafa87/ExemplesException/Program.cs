namespace ExemplesException;

public class Program
{
    // static int ReadInt(string message, int start, int end)
    // {
    //     bool ok = false;
    //     int result = start - 1;
    //     while (!(ok && result >= start && result <= end))
    //     {
    //         Console.Write(message);
    //         ok = int.TryParse(Console.ReadLine(), out result);
    //     }
    //
    //     return result;
    // }
    static int ReadInt(string message, int start, int end)
    {
        while (true)
        {
            Console.Write(message);
            try
            {
                int result = int.Parse(Console.ReadLine());
                if (result >= start && result <= end)
                {
                    return result;
                }

                Console.WriteLine($"Le nombre doit être entre {start} et {end} inclusivement");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ! " + e.Message);
            }
        }
    }
    
    static int Sum(int n) 
    {
        if (n < 0)
        {
            // throw new ArgumentException("Must be greater than or equal to 0");
            throw new NumberException("Must be greater than or equal to 0");
        }
    
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
        }
    
        return total;
    }

    static int PlayWithExceptions(int x)
    {
        if (x < 0)
        {
            throw new TooLowException();
        }
        if (x > 100)
        {
            throw new TooHighException();
        }

        return x;
    }
    
    
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(10));
        try
        {
            Console.WriteLine(Sum(-10));
        }
        // catch (ArgumentException e)
        catch (NumberException e)
        {
            Console.WriteLine(e.Message);
        }

        int x = ReadInt("Entrez un nombre entre 1 et 10: ", 1, 10);
        Console.WriteLine($"Le nombre = {x}");
        
        try
        {
            x = PlayWithExceptions(-5);
            Console.WriteLine("Pas de problème! " + x);
        }
        catch (TooLowException e)
        {
            Console.WriteLine("Trop bas!");
        }
        catch (TooHighException e)
        {
            Console.WriteLine("Trop haut!");
        }
        finally{
            Console.WriteLine("Finalement " + x);
        }
    }

}

class NumberException : Exception
{
    public NumberException(string? message) : base(message)
    {
    }
}

class TooLowException : Exception
{
}

class TooHighException : Exception
{
}