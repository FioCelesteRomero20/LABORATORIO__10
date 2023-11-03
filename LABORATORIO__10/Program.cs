using LABORATORIO__10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABORATORIO__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, VmPhone = 0, VmPad = 0, VMAPBrook = 0, VmWatch = 0, DmPhone = 0, DmPad = 0, DMAPBrook = 0, DmWatch = 0;
            do
            {
                opcion = InterfazConsola.PantalladeInicio();
                string producto = "mPhone 3000";

                switch (opcion)
                {
                    case 1:
                        InterfazConsola.Producto(producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone, ref DmPad,
                            ref DMAPBrook, ref DmWatch);
                        break;
                    case 2:
                        producto = "mPad 3500";
                        InterfazConsola.Producto(producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone, ref DmPad,
                            ref DMAPBrook, ref DmWatch);
                        break;
                    case 3:
                        producto = "MAPBrook 3800";
                        InterfazConsola.Producto(producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone, ref DmPad,
                            ref DMAPBrook, ref DmWatch);
                        break;
                    case 4:
                        producto = "mWatch 8000";
                        InterfazConsola.Producto(producto, ref VmPhone, ref VmPad, ref VMAPBrook, ref VmWatch, ref DmPhone, ref DmPad,
                            ref DMAPBrook, ref DmWatch);
                        break;
                }
                if (opcion != 5) Console.Clear();
            } while (opcion != 5);

            int mPhone = VmPhone - DmPhone;
            int mPad = VmPad - DmPad;
            int MAPBrook = VMAPBrook - DMAPBrook;
            int mWatch = VmWatch - DmWatch;
            InterfazConsola.Reporte(ref mPhone, ref mPad, ref MAPBrook, ref mWatch);
            Console.ReadKey();
        }
    }
}
