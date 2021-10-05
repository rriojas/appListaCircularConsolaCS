using System;

namespace appListaCircularConsolaCS
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero = 3;
      string nombre = "n1";

      Nodo nuevo = new Nodo(numero, nombre);

      ListaCircular lc = new ListaCircular();
      Console.WriteLine(lc.ToString());

      lc.Agregar(nuevo);
      Console.WriteLine(lc.ToString());

      nuevo = new Nodo(1, "n2");
      lc.Agregar(nuevo);
      Console.WriteLine(lc.ToString());

      nuevo = new Nodo(5, "n3");
      lc.Agregar(nuevo);
      Console.WriteLine(lc.ToString());

      lc.Eliminar(1);
      Console.WriteLine(lc.ToString());

      string fecha =DateTime.Now.ToString("yyyyMMdd_hhmmss");

      lc.Guardar("ListaCircular"+fecha);
      Console.ReadKey();
    }
  }
}
