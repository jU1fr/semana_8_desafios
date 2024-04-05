using System.Collections.Generic;
using System.IO;

// Clase Base Auto
class Auto
{
    protected string marca;
    protected string modelo;
    protected int año;
    protected List<string> historialReparaciones = new List<string>();

    public Auto(string marca, string modelo, int año)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
    }

    public void Reparar(string reparacion)
    {
        historialReparaciones.Add(reparacion);
    }

    public void HistoriaDeReparaciones()
    {
        Console.WriteLine($"Historial de reparaciones para {marca} {modelo} ({año}):");
        foreach (string reparacion in historialReparaciones)
        {
            Console.WriteLine($"- {reparacion}");
        }
    }
}

// Subclase BMW
class BMW : Auto
{
    private string rutaArchivo = "reparaciones_bmw.txt";

    public BMW(string modelo, int año) : base("BMW", modelo, año)
    {
    }

    public new void Reparar(string reparacion)
    {
        base.Reparar(reparacion);
        File.AppendAllText(rutaArchivo, $"{marca} {modelo} ({año}): {reparacion}\n");
    }

    public new void HistoriaDeReparaciones()
    {
        Console.WriteLine($"Historial de reparaciones para {marca} {modelo} ({año}):");
        if (File.Exists(rutaArchivo))
        {
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine("No hay reparaciones registradas.");
        }
    }
}

// Clase Program
class desafio_3
{
    static void Main(string[] args)
    {
        // Instancia de BMW
        BMW bmw = new BMW("Serie 3", 2020);

        // Realizando reparaciones
        bmw.Reparar("Cambio de aceite");
        bmw.Reparar("Reemplazo de frenos");
        bmw.Reparar("Reparación de suspenión");

        // Mostrando historial de reparaciones
        bmw.HistoriaDeReparaciones();

        Console.ReadLine();
    }
}