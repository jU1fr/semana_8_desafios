// Clase Base Calculadora
class Calculadora
{
    // Atributos
    public string Marca { get; set; }
    public string Serie { get; set; }

    // Métodos
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("No se puede dividir por cero.");
    }
}

// SubClase CalculadoraCientifica
class CalculadoraCientifica : Calculadora
{
    // Métodos
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a, double b)
    {
        return Math.Pow(a, 1 / b);
    }

    public double Modulo(double a)
    {
        return Math.Abs(a);
    }

    public double Logaritmo(double a, double b)
    {
        return Math.Log(a, b);
    }
}

// Método Main
class Program
{
    static void Main(string[] args)
    {
        // Instancia de la Clase Base Calculadora
        Calculadora calculadora = new Calculadora();
        calculadora.Marca = "Casio";
        calculadora.Serie = "FX-991ES";

        // Instancia de la SubClase CalculadoraCientifica
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
        calculadoraCientifica.Marca = "Texas Instruments";
        calculadoraCientifica.Serie = "TI-Nspire CX";

        // Usar los métodos de la Clase Base Calculadora
        double suma = calculadora.Sumar(2, 3);
        double resta = calculadora.Restar(5, 2);
        double multiplicacion = calculadora.Multiplicar(4, 6);
        double division = calculadora.Dividir(10, 2);

        // Usar los métodos de la SubClase CalculadoraCientifica
        double potencia = calculadoraCientifica.Potencia(2, 3);
        double raiz = calculadoraCientifica.Raiz(16, 2);
        double modulo = calculadoraCientifica.Modulo(-5);
        double logaritmo = calculadoraCientifica.Logaritmo(100, 10);

        // Imprimir los resultados
        Console.WriteLine("Resultados de la Clase Base Calculadora:");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");

        Console.WriteLine("\nResultados de la SubClase CalculadoraCientifica:");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Raíz: {raiz}");
        Console.WriteLine($"Módulo: {modulo}");
        Console.WriteLine($"Logaritmo: {logaritmo}");

        Console.ReadLine();
    }
}