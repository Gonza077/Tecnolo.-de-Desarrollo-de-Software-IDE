using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.XML;
using System.Xml;
using System.Windows.Markup;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();
            Console.ReadKey();
            */
            escribir();
            leer();
            Console.ReadKey();
        }

        private static void escribirXML() 
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");
            StreamReader lector = new StreamReader("agenda.txt");
            string linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores= linea.Split(';');
                    escritorXML.WriteStartElement("Contactos");
                    escritorXML.WriteStartElement("Nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();
                    Console.WriteLine();
                }

            } while (linea != null);
        }
        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");
            string rta = "S";
            while (rta=="S")
            {
                Console.Write("Ingrese nuevo nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese apellido");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese Email");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese numero de telefono");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
                Console.WriteLine("¿Desea ingresar otro contacto? S/N");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre \t Apellido \t E-Mail \t\t\t Telfono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t {1}\t{2}\t\t\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            }
            while (linea != null);
            lector.Close();
        }
    }
}
