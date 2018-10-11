using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaVista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumnos = new List<Alumno>(); // inicializar la lista 

        public MainWindow()
        {
            InitializeComponent();
            //Añadir elementos con Add
            alumnos.Add( new Alumno("Pedro Del Norte","716835","Lic. en Arreglo Musical"));
            alumnos.Add(new Alumno("Pablo Del Norte", "716831", "Lic. en Canto "));
            alumnos.Add(new Alumno("María Encinas", "167845", "Lic. en tortilleria"));
            alumnos.Add(new Alumno("Ana Guerrero", "787455", "Ing.Civil"));

            foreach (Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem()
                {
                    Content = alumno.Nombre
                }
                );
            }
        }

        private void lstAlumnos_SizeChanged(object sender, SelectionChangedEventArgs e)
        {

            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
                
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
