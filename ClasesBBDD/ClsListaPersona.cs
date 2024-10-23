using BibliotecaClases;
using System.Collections;
using System.Collections.ObjectModel;

namespace ClasesBBDD
{

    public static class ClsListadoPersonasDAL
    {

        /// <summary>
        /// Función que nos devuelve un listado de todas las personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static ObservableCollection<ClsPersona> getListadoCompletoPersonas()
        {
            ObservableCollection<ClsPersona> lista = new ObservableCollection<ClsPersona>();

            ClsPersona p1 = new ClsPersona("Pablo", "Chileno", 34);
            ClsPersona p2 = new ClsPersona("Jesus Lorenzo", "Extremoduro", 11);
            ClsPersona p3 = new ClsPersona("Jorge", "Arias", 23);
            ClsPersona p4 = new ClsPersona("Marta", "Guerrero", 54);
            ClsPersona p5 = new ClsPersona("Marcos", "Holguín Cascajado", 32);
            ClsPersona p6 = new ClsPersona("Hector", "Campana", 22);
            ClsPersona p7 = new ClsPersona("Raúl", "Pajarito", 32);
            ClsPersona p8 = new ClsPersona("Pepelu", "Jerga", 43);
            ClsPersona p9 = new ClsPersona("Elena", "Java", 99);


            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(p9);
            
            

            return lista;
            
           

        
        }




    }


}


