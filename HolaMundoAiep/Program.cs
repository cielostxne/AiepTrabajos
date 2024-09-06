using HolaMundo;

namespace HolaMundo
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Creamos un objeto o instanciamos
            //un objeto de la clase Saludo
            saludo objetoSaludo = new saludo();
            //Creamos una variable tipo string
            string mensaje;
            //le asignamos a la variable mensaje
            //el valor que retorna el metodo
            //HolaMundo() de la clase Saludo
            mensaje = objetoSaludo.HolaMundo();
            //Ahora imprimiremos el valor de la variable mensaje
            //Utilizamos la instrucción Console.WriteLine
            //y Console.Read() para generar una pausa
            Console.WriteLine(mensaje);
            Console.Read();
        }
    }
}