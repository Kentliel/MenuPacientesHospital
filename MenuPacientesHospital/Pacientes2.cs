using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace MenuPacientesHospital
{
    internal class Pacientes2
    {
             string[] ListaPacientes = new string[50];   // OPCION 1: VARIABLE GLOBAL
             int CantidadPacientes = 0; 

            public static void Main(string[] args)
            {
                int Option = 0;
                PacientesHospital hospital = new PacientesHospital(); 

                do
                {
                    Console.WriteLine("1. Alta de Paciente");
                    Console.WriteLine("2. Eliminar Paciente");
                    Console.WriteLine("3. Listar Pacientes Sin Ordenar");
                    Console.WriteLine("4. Listar Pacientes Ordenados Por Nombre");
                    Console.WriteLine("5. Indicar La Posicion En La Que Se Encuentra Un Paciente En La Lista");
                    Console.WriteLine("6. Buscar 1 Paciente");
                    Console.WriteLine("7. Modificar un Paciente");

                    try
                    {
                        Console.WriteLine("\nEscribe un numero del menu");
                        Option = int.Parse(Console.ReadLine());
                        switch (Option)
                        {
                            case 1:
                                hospital.AltaPaciente();
                                break;
                            // Implementar los casos restantes aquí
                            default:
                                Console.WriteLine("Opción no válida. Intente nuevamente.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Por favor ingrese un número válido." + ex.Message);
                    }

                } while (Option != 0 && Option <= 7);

                Console.WriteLine("Has Salido del Programa");
            }

            // Método para dar de alta un paciente
            public void AltaPaciente()
            {
                if (CantidadPacientes < ListaPacientes.Length)
                {
                    Console.WriteLine("Ingrese el nombre del paciente:");
                    string nombrePaciente = Console.ReadLine();
                    ListaPacientes[CantidadPacientes] = nombrePaciente;
                    CantidadPacientes++;
                    Console.WriteLine("Paciente agregado correctamente.");
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible para agregar más pacientes.");
                }
            }
        
    }
}
public void EliminarPaciente()
{
    if (cantidadPacientes > 0)
    {
        Console.WriteLine("Lista de Pacientes:");
        for (int i = 0; i < cantidadPacientes; i++)
        {
            Console.WriteLine($"{i + 1}. {ListaPacientes[i]}");
        }

        Console.WriteLine("Ingrese el número del paciente que desea eliminar:");
        try
        {
            int indiceEliminar = int.Parse(Console.ReadLine()) - 1;

            if (indiceEliminar >= 0 && indiceEliminar < cantidadPacientes)
            {
                // Desplazar los elementos hacia la izquierda para llenar el espacio vacío
                for (int i = indiceEliminar; i < cantidadPacientes - 1; i++)
                {
                    ListaPacientes[i] = ListaPacientes[i + 1];
                }
                ListaPacientes[cantidadPacientes - 1] = null; // Eliminar la última posición
                cantidadPacientes--;
                Console.WriteLine("Paciente eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Índice de paciente no válido.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Por favor ingrese un número válido." + ex.Message);
        }
    }
    else
    {
        Console.WriteLine("No hay pacientes para eliminar.");
    }
}*/
