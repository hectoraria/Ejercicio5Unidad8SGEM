using BibliotecaClases;
using ClasesBBDD;
using System.Collections.ObjectModel;

namespace Ejercicio5Unidad8
{
    public partial class MainPage : ContentPage
    {
        #region atributos
        
        #endregion

        public MainPage()
        {
            InitializeComponent();

           ObservableCollection<ClsPersona> lista = ClsListadoPersonasDAL.getListadoCompletoPersonas();

            listaView.ItemsSource = lista;
       
        }
    }

}
