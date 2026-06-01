Empleado[] empleados = new Empleado[10];
Console.WriteLine("Sea bienvenido al registro de empleado");
void agregarEmpleado(int pos)
{
    Console.WriteLine("===================================");
    Console.Write("Nombre: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellido: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.Write("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamente");
    Console.ReadKey();
    Console.ResetColor();
    Console.WriteLine("===================================");
}
void guardarEmpleados(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\Programacion2\\empleados.csv");
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine($"Registro {i+1}");
        archivo.WriteLine($"{empleados[i].nombres}; {empleados[i].apellidos}; {empleados[i].cargo}; {empleados[i].salario}");
        Console.WriteLine("Registro guardado.");
        Console.ReadKey();
    }
    archivo.Close();
}
int menu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Clear();
    Console.WriteLine("Menu:");
    Console.Write("1. Agregar \n2. Mostrar \n3. Guardar \n4. Salir \nDigite su opcion: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.ResetColor();
    int op = int.Parse(Console.ReadLine()!);
    return op;
}
void mostrarDatos(int pos)
{
    Console.WriteLine("Mostrar registros");
    Console.WriteLine("----------------------------");
    for (int i=0; i<pos; i++)
    {
        Console.WriteLine($"Registro #{i+1}");
        Console.WriteLine($"Nombre: {empleados[i].nombres} \nApellidos: {empleados[i].apellidos} " +
            $" \nCargo: {empleados[i].cargo} \nSalario: {empleados[i].salario};");
        Console.ReadKey();
        Console.WriteLine("----------------------------");
       

    }
   
}
int main()
{
    int op = 0, i = 0;
    do
    {
        
        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                Console.WriteLine("===================================");
                mostrarDatos(i);
                Console.WriteLine("===================================");
                break;
            case 3:
                guardarEmpleados(i);
                break;
            default:
                Console.WriteLine("Opcion invalida...");
                break;

        }
    } while (op != 4);

    return 0;
}
main();
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}
