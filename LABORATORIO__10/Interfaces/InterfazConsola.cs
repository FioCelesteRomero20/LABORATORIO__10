using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO__10.Interfaces
{
    internal class InterfazConsola
    {
       
        //Creamos una método para los encabezados del programa
        public static void Encabezado(string titulo)
        {
            Console.WriteLine($" ======================================\n {titulo}\n ======================================");
        }
        //Generamos una función para escribir y leer una variable
        public static int WriteandRead()
        {
            Console.Write(" ======================================\n Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        //Generamos una función para retornar la opción del menú principal
        public static int PantalladeInicio()
        {
            Encabezado(" Productos de mPhone");
            Console.WriteLine(" 1: Ventas de mPhone 3000\n 2: Ventas de mPad 3500\n 3: Ventas de MAPBrook 3800\n 4: Ventas de mWatch 8000\n 5: Salir");
            int opcion = WriteandRead();
            return opcion;
        }
        //Construimos un método para, según el producto, direccionar a ventas o devoluciones
        public static void Producto(string producto, ref int VmPhone, ref int VmPad, ref int VMAPBrook, ref int VmWatch,
            ref int DmPhone, ref int DmPad, ref int DMAPBrook, ref int DmWatch)
        {
            int opcion1;
            do
            {
                Console.Clear();
                Encabezado($" {producto}");
                Console.WriteLine(" 1: Registrar Venta\n 2: Registrar Devolución\n 3: Menú Principal");
                int opcion = WriteandRead();
                opcion1 = 0;
                string tipo = "venta";

                switch (opcion)
                {
                    case 1:
                        opcion1 = Registro(tipo, producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone,
                            ref DmPad, ref DMAPBrook, ref DmWatch);
                        break;
                    case 2:
                        tipo = "devolución";
                        opcion1 = Registro(tipo, producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone,
                            ref DmPad, ref DMAPBrook, ref DmWatch);
                        break;
                }

            } while (opcion1 == 2);
        }
        //Creamos una función para ejecutar la venta o la devolución del producto
        public static int Registro(string tipo, string producto, ref int VmPhone, ref int VmPad, ref int VMAPBrook, ref int VmWatch,
            ref int DmPhone, ref int DmPad, ref int DMAPBrook, ref int DmWatch)
        {
            int opcion;
            do
            {
                Console.Clear();
                Encabezado($" Registrar {tipo} de: ");
                Console.WriteLine($" Se va a registrar la {tipo} de un\n {producto}. ¿Desea continuar?");
                Console.WriteLine(" 1: Sí\n 2: No");
                opcion = WriteandRead();
                if (opcion == 1)
                {
                    switch (tipo)
                    {
                        case "venta":
                            if (producto == "mPhone 3000") VmPhone++;
                            if (producto == "mPad 3500") VmPad++;
                            if (producto == "MAPBrook 3800") VMAPBrook++;
                            if (producto == "mWatch 8000") VmWatch++;
                            break;
                        case "devolución":
                            if (producto == "mPhone 3000") DmPhone++;
                            if (producto == "mPad 3500") DmPad++;
                            if (producto == "MAPBrook 3800") DMAPBrook++;
                            if (producto == "mWatch 8000") DmWatch++;
                            break;
                    }
                }
            } while (opcion == 1);
            return opcion;
        }
        //Hacemos un método para mostrar el stock de cada producto y el total de ellos
        public static void Reporte(ref int mPhone, ref int mPad, ref int MAPBrook, ref int mWatch)
        {
            Encabezado(" Reporte Final");
            Console.WriteLine(" Productos Vendidos  |  Cantidad\n --------------------------------------");
            Console.WriteLine($" mPhones\t     |  {mPhone}\n mPads\t\t     |  {mPad}\n MAPBrooks\t     |  {MAPBrook}");
            Console.WriteLine($" mWatches\t     |  {mWatch}\n --------------------------------------");
            Console.WriteLine($" Total\t\t     |  {mPhone + mPad + MAPBrook + mWatch}");
            Console.WriteLine(" ======================================\n ¡Hasta luego!\n\n\n");
            Console.WriteLine(" Diseñado por: Fiorella");
        }
    }
}
