/* 
   Un centro educativo crea cuentas para sus estudiantes nuevos.
   Cada cuenta lleva un usuario, formado por la inicial del nombre
   y apellido en minusculas, y una llave que debe validarse.
*/

class Registro
{

    static void Main()
    {
        Crearcuenta();
    }
    static void Crearcuenta()
    {
        Console.Write("Introduzca su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Introduzca su apellido: ");
        string apellido = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
        {
            Console.WriteLine("Debe introducir su nombre y apellido.");
            return;
        }

        string usuario = nombre.Trim() + apellido.Trim();
        usuario = usuario.ToLower();

        Console.Write("Introduca su clave: ");
        string llave = Console.ReadLine();

        if (llave.Length >= 8)
        {
            Console.WriteLine("Cuenta creada con exito.");
            Console.WriteLine($"Su usuario es: {usuario}");
        }
        else
        {
            Console.WriteLine("La llave debe tener al menos 8 caracteres.");
        }

    }

}

