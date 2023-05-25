using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGasto
{
    public class Gasto
    {


        int id = 0;
        DateTime fecha;
        string[] categoria = new string[] { "Salud", "Alimentacion", "Transporte", "Entretenimiento", "Varios" };

        double monto;
        string descripcion;
        //Protected funciona en la misma biblioteca de clases
        public Gasto()
        {
            //En teoría se debe de incrementar al crear un objeto nuevo.
            id = ++id;
        }
        public Gasto(DateTime fecha, string[] categoria, double monto, string descripcion)
        {
            //Cada vez que se cree un objeto se incrementara automaticamente el id
            id = ++id;
            this.fecha = fecha;
            this.categoria = categoria;
            this.monto = monto;
            this.descripcion = descripcion;
        }
        //Encapsulando datos?
        public int ID { get { return this.id; } set { id = value; } }

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

        public double Monto { get { return monto; } set { monto = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public string[] Categoria { get { return categoria; } set { categoria = value; } }

    }
}  



