using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio ini = new Inicio();
            ini.inicio();
        }
    }

    public class arrays
    {
        Inicio inicio =new Inicio();
        
        public string Nombren, Proveedn, Detallen, Precion;
        public string rArea, nArea;
        public string rCat;
        public string rProd, rProd2, rProd7, rProd6,rProd9;
        public string A1, Ecat,epro;
        public string AN1, AN2;
        public void areas()
        {

            inicio.admin();
            string[] Area = new string[4];
            Area[0] = "1- Infantil";
            Area[1] = "2- Igiene";

            for (int i = 0; i < Area.Length; i++)
            {
                Console.WriteLine(Area[i]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escoja una area o si desea crear una nueva ingrese (/area) ");
            Console.ForegroundColor = ConsoleColor.White;

            rArea = Console.ReadLine();
            Console.Clear();
            if (rArea == "/area")
            {
                Console.WriteLine("Escribe el nombre de la nueva Area a añadir. ");
                nArea = Console.ReadLine();
                Console.WriteLine("Escribe el nombre de una categoria para el área de nombre "+nArea);
                AN1 = Console.ReadLine();
                Console.WriteLine("Escribe el nombre de un producto para la categoria de nombre "+AN1);
                AN2 = Console.ReadLine();
                Console.WriteLine("Escribe un proveedor para el producto "+AN2);
                Proveedn = Console.ReadLine();
                Console.WriteLine("Escribe los detalles para el producto "+AN2);
                Detallen = Console.ReadLine();
                Console.WriteLine("Escribe el precio del producto "+"$"+AN2);
                Precion = Console.ReadLine();
                Console.WriteLine("Añadido exitosamente, preciona una tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();

                

                Area[2] = "3- " + nArea;
                for (int i = 0; i < Area.Length; i++)
                {
                    Console.WriteLine(Area[i]);
                }
                Console.WriteLine("Escoja una area ");
                rArea = Console.ReadLine();
                Console.Clear();
            }
            
            if (rArea == "1")
            {
                categorias();
            }
            if (rArea == "2")
            {
                categoriaIg();
            }
            if (rArea == "3") ;
            {
                catnue();

            }
        }
        public void catnue()
        {
            /////////////////////////////
            string[] catN = new string[4];
            catN[0] = "1- " + AN1;

            string[] prodN = new string[4];
            prodN[0] = "1- " + AN2;
            //////////////////////////////
            ///

            for (int v = 0; v < catN.Length; v++)
            {
                Console.WriteLine(catN[v]);
            }
            Console.WriteLine("Escoja una categoria. ");
            Ecat = Console.ReadLine();
            Console.Clear();
            for (int b = 0; b < prodN.Length; b++)
            {
                Console.WriteLine(prodN[b]);
            }
            Console.WriteLine("Escoja el producto que desea vender. ");
            epro = Console.ReadLine();
            Console.Clear();
            if (epro == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       " + AN2 + "                      " + Proveedn + "                 " + Detallen + "                        " + Precion);
                Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
        }
        public void continuar()
        {
            
        }
        public void categoriaIg()
        {
            string[] categorias = new string[4];
            categorias[0] = "1- Personal ";
            categorias[1] = "2- Casa ";
            categorias[2] = "3- Vehiculo ";

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);
            }

            Console.WriteLine("Escoje una categoria para continuar ó /cat para añadir una ");
            rCat = Console.ReadLine();
            Console.Clear();
            if (rCat == "1")
            {
                productosP();
            }
            if (rCat == "2")
            {
                productosH();
            }
            if (rCat == "3") ;
            {
                productosV();
            }


        }
        public void productosP()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         ALCOHOL GEL.          DS                  PLASTICO           5.00      ";
            productosj[1] = "2-         TUALLITAS HUMEDAS.    SSA                 ALGODON            7.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd = Console.ReadLine();
            Console.Clear();
            if (rProd == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       ALCOHOL GEL.          DS                   PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       TUALLITAS HUMEDAS     SSA                  ALGODON            7.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          7.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd2 = Console.ReadLine();
                Console.Clear();
                if (rProd2 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       ALCOHOL GEL.          DS                   PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       TUALLITAS HUMEDAS     SSA                  ALGODON            7.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          7.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }
        public void productosH()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         DESINFECTANTE.        LIC                  PLASTICO            5.00      ";
            productosj[1] = "2-         LEGIA.                LIC                  PLASTICO            6.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd = Console.ReadLine();
            Console.Clear();
            if (rProd == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       DESINFECTANTE.        LIC                  PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       LEGIA                 LIC                  PLASTICO           6.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          6.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd2 = Console.ReadLine();
                Console.Clear();
                if (rProd2 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       DESINFECTANTE.        LIC                  PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       LEGIA                 LIC                  PLASTICO           6.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          6.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }
        public void productosV()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         JABON.                CARS.                PLASTICO           5.00      ";
            productosj[1] = "2-         ABRILLANTADOR R.      CARS.                PLASTICO           8.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd = Console.ReadLine();
            Console.Clear();
            if (rProd == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       JABON.                CARS.                PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       ABRILLANTADOR R       CARS                 PLASTICO           8.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          8.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd = Console.ReadLine();
                Console.Clear();
                if (rProd == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       JABON.                CARS.                PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       ABRILLANTADOR R       CARS                 PLASTICO           8.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          8.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }

        public void categorias()
        {
            string[] categorias = new string[4];
            categorias[0] = "1- Jugetes ";
            categorias[1] = "2- Lociones ";
            categorias[2] = "3- Comida ";

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);
            }

            Console.WriteLine("Escoje una categoria para continuar ó /cat para añadir una ");
            rCat = Console.ReadLine();
            Console.Clear();
            if (rCat == "1")
            {
                productosJ();
            }
            if (rCat == "2")
            {
                productosL();
            }
            if (rCat == "3") ;
            {
                productosC();
            }

        }
        public void productosJ()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         Retro Escabadora.     CAT                  PLASTICO           75.00      ";
            productosj[1] = "2-         Bolqueta.             CAT                  PLASTICO           65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd7 = Console.ReadLine();
            Console.Clear();
            if (rProd6 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       Retro Escabadora.     CAT                  PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd6 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       Bolqueta              CAT                  PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd6 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd2 = Console.ReadLine();
                Console.Clear();
                if (rProd2 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       Retro Escabadora.     CAT                  PLASTICO           75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       Bolqueta              CAT                  PLASTICO           75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd2 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }
        
        public void productosL()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         SPARTANO.             AVG                  VIDRIO             75.00      ";
            productosj[1] = "2-         PRINCESS.             AVG                  VIDRIO             65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd6 = Console.ReadLine();
            Console.Clear();
            if (rProd6 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       SPARTANO.             AVG                  VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd6 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       PRINCESS              AVG                  VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd6 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd6 = Console.ReadLine();
                Console.Clear();
                if (rProd6 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       SPARTANO.             AVG                  VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd6 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       PRINCESS              AVG                  VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd6 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }
        public void productosC()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         GERBERT.              GERBERT INC.         VIDRIO             75.00      ";
            productosj[1] = "2-         AVENA.                QUAKERS              PLASTICO           65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ó /prod para añadir otro. ");
            rProd9 = Console.ReadLine();
            Console.Clear();
            if (rProd9 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       GERBERT.              GERBERT INC.         VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd9 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       AVENA                 QUAKERS              PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd9 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren + "                 " + Proveedn + "                  " + Detallen + "             " + Precion + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd9 = Console.ReadLine();
                Console.Clear();
                if (rProd9 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       GERBERT.              GERBERT INC.         VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd9 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       AVENA                 QUAKERS              VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd9 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren + "           " + Proveedn + "         " + Detallen + "       " + Precion);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }
        public void CatN()
        {

        }



    }
    

    public class Inicio
    {
        public string num;


        public void admin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                                                           Administrador\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void usuario()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                                                                 Usuario\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void inicio()
        {
            Console.WriteLine("BIENVENIDO AL SUPERMERCADO ECONOMICO!\n ");
            Console.WriteLine("PRESIONA CUALQUIER TECLA PARA CONTINUAR ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingresa el nivel de usuario al que deseas acceder (1 = Administrador ó 2= Usuario )");
            num = Console.ReadLine();
            Console.Clear();
            if (num == "1")
            {
               
                arrays arrays = new arrays();
                arrays.areas();

            }
            if (num == "2")
            {
                arrays1 arrays1 = new arrays1();
                arrays1.areas();
            }
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class arrays1
    {
        public string Nombren1, Proveedn1, Detallen1, Precion1;
        public string rArea1, nArea1;
        public string rCat1;
        public string rProd1, rProd21;
        public string A11, Ecat1, epro1;
        public string AN11, AN21;
        Inicio inicio = new Inicio();
        
        public void areas()
        {
            inicio.usuario();
            //mostrando datos
            string[] Area = new string[4];
            Area[0] = "1- Infantil";
            Area[1] = "2- Igiene";

            for (int i = 0; i < Area.Length; i++)
            {
                Console.WriteLine(Area[i]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escoja una area ");
            Console.ForegroundColor = ConsoleColor.White;

            rArea1 = Console.ReadLine();
            Console.Clear();
            if (rArea1 == "/area")
            {
                Console.WriteLine("Escribe el nombre de la nueva Area a añadir. ");
                nArea1 = Console.ReadLine();
                Console.WriteLine("Escribe el nombre de una categoria para el área de nombre " + nArea1);
                AN11 = Console.ReadLine();
                Console.WriteLine("Escribe el nombre de un producto para la categoria de nombre " + AN11);
                AN21 = Console.ReadLine();
                Console.WriteLine("Escribe un proveedor para el producto " + AN21);
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Escribe los detalles para el producto " + AN21);
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Escribe el precio del producto " + "$" + AN21);
                Precion1 = Console.ReadLine();
                Console.WriteLine("Añadido exitosamente, preciona una tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();



                Area[2] = "3- " + nArea1;
                for (int i = 0; i < Area.Length; i++)
                {
                    Console.WriteLine(Area[i]);
                }


            }
            Console.WriteLine("Escoja una area ");
            rArea1 = Console.ReadLine();
            if (rArea1 == "1")
            {
                categorias();
            }
            if (rArea1 == "2")
            {
                categoriaIg();
            }
            if (rArea1 == "3") ;
            {
                catnue();

            }
        }
        public void catnue()
        {
            /////////////////////////////
            string[] catN = new string[4];
            catN[0] = "1- " + AN11;

            string[] prodN = new string[4];
            prodN[0] = "1- " + AN21;
            //////////////////////////////
            ///

            for (int v = 0; v < catN.Length; v++)
            {
                Console.WriteLine(catN[v]);
            }
            Console.WriteLine("Escoja una categoria. ");
            Ecat1 = Console.ReadLine();
            Console.Clear();
            for (int b = 0; b < prodN.Length; b++)
            {
                Console.WriteLine(prodN[b]);
            }
            Console.WriteLine("Escoja el producto que desea vender. ");
            epro1 = Console.ReadLine();
            Console.Clear();
            if (epro1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       " + AN21 + "                      " + Proveedn1 + "                 " + Detallen1 + "                        " + Precion1);
                Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
        }
        public void continuar()
        {

        }
        public void categoriaIg()
        {
            string[] categorias = new string[4];
            categorias[0] = "1- Personal ";
            categorias[1] = "2- Casa ";
            categorias[2] = "3- Vehiculo ";

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);
            }

            Console.WriteLine("Escoje una categoria para continuar ");
            rCat1 = Console.ReadLine();
            Console.Clear();
            if (rCat1 == "1")
            {
                productosP();
            }
            if (rCat1 == "2")
            {
                productosH();
            }
            if (rCat1 == "3") ;
            {
                productosV();
            }


        }
        public void productosP()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         ALCOHOL GEL.          DS                  PLASTICO           5.00      ";
            productosj[1] = "2-         TUALLITAS HUMEDAS.    SSA                 ALGODON            7.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender. ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       ALCOHOL GEL.          DS                   PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       TUALLITAS HUMEDAS     SSA                  ALGODON            7.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          7.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       ALCOHOL GEL.          DS                   PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       TUALLITAS HUMEDAS     SSA                  ALGODON            7.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          7.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }
        public void productosH()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         DESINFECTANTE.        LIC                  PLASTICO            5.00      ";
            productosj[1] = "2-         LEGIA.                LIC                  PLASTICO            6.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender. ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       DESINFECTANTE.        LIC                  PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       LEGIA                 LIC                  PLASTICO           6.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          6.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       DESINFECTANTE.        LIC                  PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       LEGIA                 LIC                  PLASTICO           6.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          6.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }
        public void productosV()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         JABON.                CARS.                PLASTICO           5.00      ";
            productosj[1] = "2-         ABRILLANTADOR R.      CARS.                PLASTICO           8.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender. ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       JABON.                CARS.                PLASTICO           5.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       ABRILLANTADOR R       CARS                 PLASTICO           8.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          8.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       JABON.                CARS.                PLASTICO           5.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          5.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       ABRILLANTADOR R       CARS                 PLASTICO           8.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          8.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }

        public void categorias()
        {
            string[] categorias = new string[4];
            categorias[0] = "1- Jugetes ";
            categorias[1] = "2- Lociones ";
            categorias[2] = "3- Comida ";

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);
            }

            Console.WriteLine("Escoje una categoria para continuar ");
            rCat1 = Console.ReadLine();
            Console.Clear();
            if (rCat1 == "1")
            {
                productosJ();
            }
            if (rCat1 == "2")
            {
                productosL();
            }
            if (rCat1 == "3") ;
            {
                productosC();
            }

        }
        public void productosJ()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         Retro Escabadora.     CAT                  PLASTICO           75.00      ";
            productosj[1] = "2-         Bolqueta.             CAT                  PLASTICO           65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender. ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       Retro Escabadora.     CAT                  PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       Bolqueta              CAT                  PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       Retro Escabadora.     CAT                  PLASTICO           75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       Bolqueta              CAT                  PLASTICO           75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }

        public void productosL()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         SPARTANO.             AVG                  VIDRIO             75.00      ";
            productosj[1] = "2-         PRINCESS.             AVG                  VIDRIO             65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       SPARTANO.             AVG                  VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       PRINCESS              AVG                  VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       SPARTANO.             AVG                  VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       PRINCESS              AVG                  VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }

        }
        public void productosC()
        {
            string[] productosj = new string[4];
            Console.WriteLine("ID         NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
            productosj[0] = "1-         GERBERT.              GERBERT INC.         VIDRIO             75.00      ";
            productosj[1] = "2-         AVENA.                QUAKERS              PLASTICO           65.00      ";
            for (int i = 0; i < productosj.Length; i++)
            {
                Console.WriteLine(productosj[i]);
            }
            Console.WriteLine("Escoje un producto para vender. ");
            rProd1 = Console.ReadLine();
            Console.Clear();
            if (rProd1 == "1")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("1-       GERBERT.              GERBERT INC.         VIDRIO             75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "2")
            {
                Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                Console.WriteLine("2-       AVENA                 QUAKERS              PLASTICO           75.00     ");
                Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
            }
            if (rProd1 == "/prod")
            {
                Console.WriteLine("Escribe el nombre del producto a añadir. ");
                Nombren1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el proveedor. ");
                Proveedn1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita los detalles (Se brebe) ");
                Detallen1 = Console.ReadLine();
                Console.WriteLine("Gracias, Ahora digita el precio. ");
                Precion1 = Console.ReadLine();
                Console.WriteLine("Perfecto, producto añadido con exito. ");
                Console.Clear();
                for (int j = 0; j < productosj.Length; j++)
                {
                    productosj[3] = "3-         " + Nombren1 + "                 " + Proveedn1 + "                  " + Detallen1 + "             " + Precion1 + " ";
                }
                Console.WriteLine("Presiona cualquier tecla para continuar. ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("ID        NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                for (int i = 0; i < productosj.Length; i++)
                {
                    Console.WriteLine(productosj[i]);
                }
                Console.WriteLine("Escoje una producto para continuar la venta ");
                rProd21 = Console.ReadLine();
                Console.Clear();
                if (rProd21 == "1")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("1-       GERBERT.              GERBERT INC.         VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          75.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "2")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       AVENA                 QUAKERS              VIDRIO             75.00     ");
                    Console.WriteLine("TOTAL A PAGAR                                                          65.00     ");
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
                if (rProd21 == "3")
                {
                    Console.WriteLine("-----------------------------------RESUMEN----------------------------------------");
                    Console.WriteLine("ID       NOMBRE                PROVEEDOR            DETALLES           PRECIO     ");
                    Console.WriteLine("2-       " + Nombren1 + "           " + Proveedn1 + "         " + Detallen1 + "       " + Precion1);
                    Console.WriteLine("TOTAL A PAGAR                                                          " + Precion1);
                    Console.WriteLine("-------------------------------FIN RESUMEN----------------------------------------");
                }
            }
        }
        



    }


}
