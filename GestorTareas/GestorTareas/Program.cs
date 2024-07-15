using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestorTareas
{
    // Clase Tarea
    public class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; }

        public Tarea(string descripcion, DateTime fechaVencimiento)
        {
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            Completada = false;
        }

        public void MarcarComoCompletada()
        {
            Completada = true;
        }
    }

    // Clase GestorTareas
    public class GestorTareas
    {
        private List<Tarea> tareas;

        public GestorTareas()
        {
            tareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        public void MarcarTareaComoCompletada(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
            {
                tareas[indice].MarcarComoCompletada();
            }
            else
            {
                Console.WriteLine("Índice de tarea no válido.");
            }
        }

        public void MostrarTareasPendientes()
        {
            var tareasPendientes = tareas.Where(t => !t.Completada);
            Console.WriteLine("Tareas pendientes:");
            foreach (var tarea in tareasPendientes)
            {
                Console.WriteLine($"Descripción: {tarea.Descripcion}, Fecha de Vencimiento: {tarea.FechaVencimiento}");
            }
        }

        public void MostrarTareasCompletadas()
        {
            var tareasCompletadas = tareas.Where(t => t.Completada);
            Console.WriteLine("Tareas completadas:");
            foreach (var tarea in tareasCompletadas)
            {
                Console.WriteLine($"Descripción: {tarea.Descripcion}, Fecha de Vencimiento: {tarea.FechaVencimiento}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de GestorTareas
            GestorTareas gestor = new GestorTareas();

            // Agregar tareas
            gestor.AgregarTarea(new Tarea("Comprar leche", DateTime.Now.AddDays(2)));
            gestor.AgregarTarea(new Tarea("Hacer ejercicio", DateTime.Now.AddDays(5)));
            gestor.AgregarTarea(new Tarea("Estudiar C#", DateTime.Now.AddDays(7)));

            // Marcar una tarea como completada
            gestor.MarcarTareaComoCompletada(1); // Marca la segunda tarea (índice 1) como completada

            // Mostrar tareas pendientes
            gestor.MostrarTareasPendientes();

            // Mostrar tareas completadas
            gestor.MostrarTareasCompletadas();
        }
    }
}

