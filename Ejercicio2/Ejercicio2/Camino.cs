using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Camino
    {
        private int numeroHoja;

        private String tipoDeObjeto;

        private int identificadorTramo;

        private String tipoCamino;

        private int longitud;
        
        public Camino(int numeroHoja, String tipoDeObjeto, int identificadorTramo, String tipoCamino, int longitud)
        {
            this.numeroHoja = numeroHoja;

            this.tipoDeObjeto = tipoDeObjeto;

            this.identificadorTramo = identificadorTramo;

            this.tipoCamino = tipoCamino;

            this.longitud = longitud;
        }

        public int NumeroHoja { get => numeroHoja; set => numeroHoja = value; }
        public string TipoDeObjeto { get => tipoDeObjeto; set => tipoDeObjeto = value; }
        public int IdentificadorTramo { get => identificadorTramo; set => identificadorTramo = value; }
        public string TipoCamino { get => tipoCamino; set => tipoCamino = value; }
        public int Longitud { get => longitud; set => longitud = value; }

        public static void imprimir(List<Camino> listCaminos)
        {
            foreach (Camino camino in listCaminos)
            {
                Console.WriteLine(camino);
            }
            Console.ReadLine();
        }

        public override string ToString()
        {
            return this.numeroHoja + " " + this.tipoDeObjeto + " " + this.identificadorTramo + " " + this.tipoCamino + " " + this.longitud;
        }
    }
}
