using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"F:\Programacion\Visual Studio C#\Repos\Manejo_CSV\vial.csv"))
            {

                List<int> numerosHoja = new List<int>();

                List<string> tiposDeObjeto = new List<string>();

                List<int> identificadoresTramo = new List<int>();

                List<string> tiposCamino = new List<string>();

                List<int> longitud = new List<int>();

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();

                    var values = line.Split(',');

                    numerosHoja.Add(int.Parse(values[0]));

                    tiposDeObjeto.Add(values[1]);

                    identificadoresTramo.Add(int.Parse(values[2]));

                    tiposCamino.Add(values[3]);

                    longitud.Add(int.Parse(values[4]));

                }

                List<Camino> listCaminos = new List<Camino>();

                for (int i = 0; i < numerosHoja.Count; i++ )
                {
                    Camino c = new Camino(numerosHoja[i], tiposDeObjeto[i], identificadoresTramo[i], tiposCamino[i], longitud[i]);
                    listCaminos.Add(c);
                }

                Camino.imprimir(listCaminos);
            }
        }
    }
}
