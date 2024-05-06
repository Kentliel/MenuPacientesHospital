using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuPacientesHospital
{
    internal class PacientesHospital
    {
        static String[] ListaPacientes = new String[50];   // OPCION 1: VARIABLE GLOBAL
        static int CantidadPacientes = 0; // Variable para llevar el registro de la cantidad de pacientes ingresados
        public static void Main(string[] args)
        {
            int Option = 0;
            PacientesHospital hospital = new PacientesHospital(); // Crear una instancia de la clase para acceder a los métodos de instancia
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Por favor por un numero, no un letra o caracter especial!" + ex.Message);
                }
                if(Option == 1)
                {
                    AltaPaciente();
                }
                if(Option == 2)
                {
                    EliminarPaciente();
                }
                if(Option == 3)
                {
                    ListaPacientesSinOrdenar();
                }
                if(Option == 4)
                {
                    ListaPacientesOrdenados();
                }
                if(Option == 5)
                {
                    PosicionPacienteLista();
                }
                if(Option == 6)
                {
                    BuscarPaciente();
                }
                if(Option == 7)
                {
                    ModificarPaciente();
                }

            } while (Option != 0 && Option <= 7);
            Console.WriteLine("Has Salido del Programa");
        }
        //1. Alta Paciente
        public static void AltaPaciente()
        {
            do
            {
                if (CantidadPacientes < ListaPacientes.Length)
                {
                    Console.WriteLine("Ingrese el nombre del paciente:\n");
                    string nombrePaciente = Console.ReadLine();
                    ListaPacientes[CantidadPacientes] = nombrePaciente;
                    CantidadPacientes++;
                    Console.WriteLine("Paciente agregado correctamente.\n");
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible para agregar más pacientes.");
                }
                Console.WriteLine("¿Desea agregar otro Paciente? (s/n):\n");
            } while (Console.ReadLine().Trim().ToLower() == "s");
            
        }
        //2. Eliminar Paciente
        public static void EliminarPaciente()
        {
            do
            {
                if (CantidadPacientes > 0)
                {
                    Console.WriteLine("Lista de Pacientes:");
                    for (int i = 0; i < CantidadPacientes; i++)
                    {
                        Console.WriteLine($"{i + 1}. {ListaPacientes[i]}\n");
                    }

                    Console.WriteLine("Ingrese el número del paciente que desea eliminar:\n");
                    try
                    {
                        int indiceEliminar = int.Parse(Console.ReadLine()) - 1;

                        if (indiceEliminar >= 0 && indiceEliminar < CantidadPacientes)
                        {
                            // Desplazar los elementos hacia la izquierda para llenar el espacio vacío
                            for (int i = indiceEliminar; i < CantidadPacientes - 1; i++)
                            {
                                ListaPacientes[i] = ListaPacientes[i + 1];
                            }
                            ListaPacientes[CantidadPacientes - 1] = null; // Eliminar la última posición
                            CantidadPacientes--;
                            Console.WriteLine("Paciente eliminado correctamente.\n");
                        }
                        else
                        {
                            Console.WriteLine("Índice de paciente no válido.\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Por favor ingrese un número válido." + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No hay pacientes para eliminar.\n");
                }
                Console.WriteLine("¿Desea eliminar otro Paciente? (s/n):\n");
            } while (Console.ReadLine().Trim().ToLower() == "s");
            
        }
        //3. Listar Pacientes sin ordenar

        public static void ListaPacientesSinOrdenar()
        {
      
                if (CantidadPacientes > 0)
                {
                    Console.WriteLine("Lista de Pacientes Sin Ordenar:\n");
                    for (int i = 0; i < CantidadPacientes; i++)
                    {
                        Console.WriteLine($"{i + 1}. {ListaPacientes[i]}\n");
                    }
                }
                else
                {
                    Console.WriteLine("No hay pacientes para mostrar.\n");
                }
            
        }

        //4. LIstar Pacientes ordenados por nombre

        public static void ListaPacientesOrdenados()
        {
            if (CantidadPacientes > 0)
            {
                // Copiar el array original para no alterar el original
                string[] ListaPacientesOrdenados = new string[CantidadPacientes];
                Array.Copy(ListaPacientes, ListaPacientesOrdenados, CantidadPacientes);

                // Ordenar el array copiado
                Array.Sort(ListaPacientesOrdenados);

                Console.WriteLine("Lista de Pacientes Ordenados por Nombre:\n");
                for (int i = 0; i < CantidadPacientes; i++)
                {
                    Console.WriteLine($"{i + 1}. {ListaPacientesOrdenados[i]}\n");
                }
            }
            else
            {
                Console.WriteLine("No hay pacientes para mostrar.\n");
            }
        }

        //5. Indicar la posicion en la que se encuentra un paciente en la lista

        public static void PosicionPacienteLista()
        {
            do
            {
                if (CantidadPacientes > 0)
                {
                    Console.WriteLine("Ingrese el nombre del paciente:\n");
                    string nombrePaciente = Console.ReadLine();

                    int posicion = Array.IndexOf(ListaPacientes, nombrePaciente);
                    if (posicion != -1)
                    {
                        Console.WriteLine($"El paciente '{nombrePaciente}' se encuentra en la posición {posicion + 1} en la lista.\n");
                    }
                    else
                    {
                        Console.WriteLine($"El paciente '{nombrePaciente}' no se encuentra en la lista.\n");
                    }
                }
                else
                {
                    Console.WriteLine("No hay pacientes para buscar.\n");
                }
                Console.WriteLine("¿Desea ver la posicion de otro Paciente? (s/n):\n");
            } while (Console.ReadLine().Trim().ToLower() == "s");
        }

        //6. Buscar 1 Paciente

        public static void BuscarPaciente()
        {
            do
            {
                if (CantidadPacientes > 0)
                {
                    Console.WriteLine("Ingrese el nombre del paciente que desea buscar:\n");
                    string nombrePaciente = Console.ReadLine();

                    bool encontrado = false;
                    for (int i = 0; i < CantidadPacientes; i++)
                    {
                        if (ListaPacientes[i] == nombrePaciente)
                        {
                            Console.WriteLine($"El paciente '{nombrePaciente}' se encuentra en la lista en la posición {i + 1}.\n");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine($"El paciente '{nombrePaciente}' no se encuentra en la lista.\n");
                    }
                }
                else
                {
                    Console.WriteLine("No hay pacientes para buscar.\n");
                }
                Console.WriteLine("¿Desea Buscar otro Paciente? (s/n):\n");
            } while (Console.ReadLine().Trim().ToLower() == "s");
        }

        //7. Modificar un Paciente

        public static void ModificarPaciente()
        {
            do
            {
                if (CantidadPacientes > 0)
                {
                    Console.WriteLine("Ingrese el nombre del paciente que desea modificar:\n");
                    string nombrePaciente = Console.ReadLine();

                    int indicePaciente = Array.IndexOf(ListaPacientes, nombrePaciente);
                    if (indicePaciente != -1)
                    {
                        Console.WriteLine($"Ingrese el nuevo nombre para el paciente '{nombrePaciente}':\n");
                        string nuevoNombre = Console.ReadLine();
                        ListaPacientes[indicePaciente] = nuevoNombre;
                        Console.WriteLine($"El paciente '{nombrePaciente}' ha sido modificado correctamente a '{nuevoNombre}'.\n");
                    }
                    else
                    {
                        Console.WriteLine($"El paciente '{nombrePaciente}' no se encuentra en la lista.\n");
                    }
                }
                else
                {
                    Console.WriteLine("No hay pacientes para modificar.\n");
                }
                Console.WriteLine("¿Deseas Modificar otro Paciente? (s/n):\n");
            } while (Console.ReadLine().Trim().ToLower() == "s");
        }

    }
}
