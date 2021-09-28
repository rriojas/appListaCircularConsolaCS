using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaCircularConsolaCS
{
  class Nodo
  {
    protected int numero;
    protected string nombre;
    protected Nodo siguiente;

    public Nodo Siguiente
    {
      get
      {
        return siguiente;
      }
      set
      {
        siguiente = value;
      }
    }
    public string Nombre
    {
      get
      {
        return nombre;
      }
      set
      {
        nombre = value;
      }
    }
    public int Numero
    {
      get
      {
        return numero;
      }
      set
      {
        numero = value;
      }
    }
    public Nodo()
    {
      numero = 0;
      nombre = "";
      siguiente = null;
    }
    public Nodo(int num, string nomb)
    {
      numero = num;
      nombre = nomb;
      siguiente = null;
    }

    public override string ToString()
    {
      return numero + " - " + nombre;
    }
  }
}
