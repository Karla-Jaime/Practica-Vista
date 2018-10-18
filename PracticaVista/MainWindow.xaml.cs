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

            Materia historia = new Materia("HST123", "Historia");
            Materia matematicas = new Materia("MT456", "Matematicas");
            Materia civismo = new Materia("CV789", "Civismo");
            Materia espanol = new Materia("EP321", "Español");
            Materia artistica = new Materia("AT654", "Artistica");
            Materia aleman = new Materia("AM987", "Aleman");
           

            //Añadir elementos con Add
            alumnos.Add(new Alumno("Pedro Del Norte", "716835", "Lic. en Arreglo Musical"));
            alumnos.Add(new Alumno("Pablo Del Norte", "716831", "Lic. en Canto "));
            alumnos.Add(new Alumno("María Encinas", "167845", "Lic. en tortilleria"));
            alumnos.Add(new Alumno("Ana Guerrero", "787455", "Ing.Civil"));
            //Añadir materias Primer Alumno
            alumnos[0].Materias.Add(historia);
            alumnos[0].Materias.Add(matematicas);
            //Segundo Alumno
            alumnos[1].Materias.Add(civismo);
            alumnos[1].Materias.Add(espanol);
            //Tercer Alumno
            alumnos[2].Materias.Add(artistica);
            alumnos[2].Materias.Add(aleman);
            //Cuarto Alumno
            alumnos[3].Materias.Add(historia);
            alumnos[3].Materias.Add(aleman);

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
            //Clear para borrar los items a las materias
            lstMaterias.Items.Clear();

            foreach (Materia materia in alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(new ListBoxItem() { Content = materia.Nombre });

            }
        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblClaveMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
            lblNombreMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
        }
    }
}

