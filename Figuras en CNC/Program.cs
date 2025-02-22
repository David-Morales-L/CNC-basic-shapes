using System;
using System.IO;

class CNCLaser
{
    static void Main()
    {
        Console.WriteLine("Selecciona la figura a cortar:");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Círculo");
        Console.WriteLine("3. Triángulo");
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());
        string gcode = "";

        switch (opcion)
        {
            case 1:
                gcode = GenerarCuadrado(50);
                break;
            case 2:
                gcode = GenerarCirculo(25);
                break;
            case 3:
                gcode = GenerarTriangulo(50);
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        File.WriteAllText("output.gcode", gcode);
        Console.WriteLine("G-code generado en 'output.gcode'");
        Console.ReadLine();
    }

    static string GenerarCuadrado(double lado)
    {
        return "G21 ; Unidades en mm\n" +
               "G90 ; Modo absoluto\n" +
               "M3 ; Encender láser\n" +
               $"G1 X0 Y0 F1000\n" +
               $"G1 X{lado} Y0\n" +
               $"G1 X{lado} Y{lado}\n" +
               $"G1 X0 Y{lado}\n" +
               "G1 X0 Y0\n" +
               "M5 ; Apagar láser\n";
    }

    static string GenerarCirculo(double radio)
    {
        return "G21 ; Unidades en mm\n" +
               "G90 ; Modo absoluto\n" +
               "M3 ; Encender láser\n" +
               $"G2 X0 Y0 I{radio} J0\n" +
               "M5 ; Apagar láser\n";
    }

    static string GenerarTriangulo(double lado)
    {
        double altura = (Math.Sqrt(3) / 2) * lado;
        return "G21 ; Unidades en mm\n" +
               "G90 ; Modo absoluto\n" +
               "M3 ; Encender láser\n" +
               $"G1 X0 Y0 F1000\n" +
               $"G1 X{lado} Y0\n" +
               $"G1 X{lado / 2} Y{altura}\n" +
               "G1 X0 Y0\n" +
               "M5 ; Apagar láser\n";
    }
}
