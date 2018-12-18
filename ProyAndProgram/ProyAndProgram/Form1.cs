using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;   // Project>add Reference>COM>Microsoft excel



namespace ProyAndProgram
{
    public partial class Form1 : Form
    {
        Broker b = new Broker();    // se me olvido que es el bloker
        
        // Lista que contienen los datos de tipo...
        List<Profesor> ListaProfesores = new List<Profesor>();
        List<Estudiantes> ListaEstudiantes = new List<Estudiantes>();
        List<Libro> ListaLibros = new List<Libro>();
        List<Personal> ListaEmpleados = new List<Personal>();
        List<Visitante> ListaDeVisitantes = new List<Visitante>();
        List<Persona> ListaPersonas = new List<Persona>();
        List<Prestamos> ListaDePrestamos = new List<Prestamos>();

        public Form1()
        {
            //con excel
                          if (System.IO.File.Exists("C:\\Users\\user\\Desktop\\Excel.xls"))
                       {
                           Microsoft.Office.Interop.Excel.Application excelAppPre = new Microsoft.Office.Interop.Excel.Application();

                           Workbook excelPreGuardado = excelAppPre.Workbooks.Open("C:\\Users\\user\\Desktop\\Excel.xls",
                           Type.Missing, false, Type.Missing, Type.Missing, Type.Missing,
                           Type.Missing, Type.Missing, Type.Missing, true, Type.Missing,
                           Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                           //foreach (Worksheet hojaactual in excelAppPre.Worksheets)
                          //     MessageBox.Show(hojaactual.Index.GetType().ToString());
                           foreach (Worksheet hojaactual in excelAppPre.Worksheets)
                           {

                           int i = 0, j = 1;
                               //MessageBox.Show(hojaactual.Cells[i++, j].value);  // muchos errores por pensar que i++ contaba desde la inicializada + 1(sumaba 1 antes de ejecutar)



                               while (null != Convert.ToString(hojaactual.Cells[i++ + 1 , j].value))
                               //while (~string.Equals(string.Empty, Convert.ToString(hojaactual.Cells[i++, j].value )))
                               {
                                   switch (hojaactual.Index)
                                   {
                                       case 1:
                                           //MessageBox.Show((short)hojaactual.Cells[i, j + 2].value);
                                           ListaEstudiantes.Add(new Estudiantes(hojaactual.Cells[i, j].value, hojaactual.Cells[i, j + 1].value, (short)hojaactual.Cells[i, j + 2].value, true,
                                           hojaactual.Cells[i, j + 4].value.ToString(), hojaactual.Cells[i, j + 7].value, hojaactual.Cells[i, j + 8].value.ToString(), hojaactual.Cells[i, j + 9].value, hojaactual.Cells[i, j + 10].value, Convert.ToInt32(hojaactual.Cells[i, j + 5].value)));
                                           ListaEstudiantes[ListaEstudiantes.Count - 1].setClave(ListaEstudiantes[ListaEstudiantes.Count - 1].getNombre() + "123");
                                           // si hoja, cells i,j es A entonces equivaler con el A de Docentes

                                           break;
                                       case 2:  
                                          ListaProfesores.Add(new Profesor(hojaactual.Cells[i, j].value, hojaactual.Cells[i, j + 1].value, (short)hojaactual.Cells[i, j + 2].value, hojaactual.Cells[i, j + 3].value,
                                           hojaactual.Cells[i, j + 4].value.ToString(), hojaactual.Cells[i, j + 9].value, hojaactual.Cells[i, j + 10].value.ToString(), hojaactual.Cells[i, j + 11].value, hojaactual.Cells[i, j + 12].value, "asd"
                                           , 14, true));
                                           ListaProfesores[ListaProfesores.Count - 1].setClave(ListaProfesores[ListaProfesores.Count - 1].getNombre() + "123");
                                           ListaProfesores[ListaProfesores.Count - 1].setGrupo(hojaactual.Cells[i,j+5].value);

                                           break;
                                       case 3:
                                           ListaEmpleados.Add(new Personal(hojaactual.Cells[i, j].value, hojaactual.Cells[i, j + 1].value, hojaactual.Cells[i, j + 2].value.ToString(), hojaactual.Cells[i, j + 3].value,
                                           hojaactual.Cells[i, j + 4].value.ToString()));
                                           break;
                                       case 4:
                                           ListaDeVisitantes.Add(new Visitante(hojaactual.Cells[i, j].value, hojaactual.Cells[i, j + 1].value,"123123123", hojaactual.Cells[i, j + 2].value, hojaactual.Cells[i, j + 4].value, hojaactual.Cells[i, j + 3].value));
                                           break;
                                       case 5:
                                           ListaLibros.Add(new Libro(hojaactual.Cells[i, j].value, hojaactual.Cells[i, j + 2].value, hojaactual.Cells[i, j + 1].value, hojaactual.Cells[i, j + 3].value, Convert.ToInt32(hojaactual.Cells[i, j + 4].value), hojaactual.Cells[i, j + 5].value, (Int32)hojaactual.Cells[i, j + 6].value, hojaactual.Cells[i, j + 7].value, hojaactual.Cells[i, j + 8].value));
                                           break;
                                       default:
                                           break;
                                   }
                                   //Marshal.ReleaseComObject(hojaactual);
                               }

                           }
                               excelPreGuardado.Close(true, Type.Missing, Type.Missing);
                               excelAppPre.Quit();     //Excel database




                       }
                       else
                       {

                                  Random rnd = new Random();
                                  int count = 0;
                                  while (count++ < 60)
                                  {
                                      ListaEstudiantes.Add(new Estudiantes("Nombre" + count, "Apellido", Convert.ToInt16(rnd.Next(5, 19)), true, Convert.ToString(rnd.Next(1000, 10000)), "##123123", "123123", "A+", "jaimitogmail", rnd.Next(6,12)));
                                      ListaEstudiantes[ListaEstudiantes.Count - 1].setClave(ListaEstudiantes[ListaEstudiantes.Count - 1].getNombre() + "123");
                                  }
                                  count = 0;
                                  while (count++ < 5)
                                  {
                                      ListaProfesores.Add(new Profesor("Nombrep" + count, "Apellido", Convert.ToInt16(rnd.Next(5, 19)), true, Convert.ToString(rnd.Next(1000, 10000)), "##123123", "123123", "A+", "jaimitogmail", "mates", 14, true));
                                      ListaProfesores[ListaProfesores.Count - 1].setClave(ListaProfesores[ListaProfesores.Count - 1].getNombre() + "123");
                                  }
                                  for (int i = 0; i < 3; i++)
                                  {
                                      ListaEmpleados.Add(new Personal("Nombrev" + i, "Apellido" + i, Convert.ToString(rnd.Next(5, 19)), true,"aseo"));
                                  }
                                  for (int i = 0; i < 3; i++)
                                  {
                                      ListaDeVisitantes.Add(new Visitante("Nombrev" + i , "Apellido" + i, Convert.ToString(rnd.Next(5, 19)), true, "Padrede " + i , "escusa" + i));

                                  }
                                  for (int i = 0; i < 10; i++)
                                  {
                                      ListaLibros.Add(new Libro("codgo" + i,true, "titulo" + i , "autor", i, "editorial1" + i, 6 + i, "mates", DateTime.Today));
                                  }       //Lenar Datos   
                       } 

         //   if (false)  // es para tomar los valores de las listas, que asu ves toman los valores de excel
        //    {
     //       foreach (Estudiantes x in ListaEstudiantes)
       //         {
         //           b.InsertarEstudiante(x);
           //     }
//
 //               foreach (Profesor x in ListaProfesores) { b.InsertarProfesor(x); }
  //              foreach (Visitante x in ListaDeVisitantes) { b.InsertarVisitante(x); }
   //             foreach (Libro x in ListaLibros) { b.InsertarLibro(x); }
    //            foreach (Personal x in ListaEmpleados) { b.InsertarPersonal(x); }
      //      }
            
          //  MessageBox.Show(b.AccederEstudiante());

          //  ListaEstudiantes.Add(b.AccederEstudiante());
            

            InitializeComponent();
            actualizarInfo();
        }

        private void actualizarInfo()
        {

            listBox1.Items[0] = ("Estudiantes: " + ListaEstudiantes.Count);
            listBox1.Items[1] = ("Profesores: " + ListaProfesores.Count);
            listBox1.Items[2] = ("Empleados: " + ListaEmpleados.Count);
            listBox1.Items[3] = ("Visitantes: " + ListaDeVisitantes.Count);
            listBox2.Items[0] = ("Libros: " + ListaLibros.Count);
            
        }   //Actualiza la cantidad de personas comunidad academica

        private void Mostrar()
        {
            dataGridView1.RowCount = ListaEstudiantes.Count + 1;

            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {

                dataGridView1.Rows[i].Cells[0].Value = ListaEstudiantes[i].getNombre();
                dataGridView1.Rows[i].Cells[1].Value = ListaEstudiantes[i].getApellido();
                dataGridView1.Rows[i].Cells[2].Value = ListaEstudiantes[i].getEdad();
                dataGridView1.Rows[i].Cells[3].Value = ListaEstudiantes[i].getSexo();
                dataGridView1.Rows[i].Cells[4].Value = ListaEstudiantes[i].getDocumento();
                dataGridView1.Rows[i].Cells[5].Value = ListaEstudiantes[i].getCursoGrado();
                if (ListaEstudiantes[i].getMiProfesorEs() != null)
                    dataGridView1.Rows[i].Cells[6].Value = ListaEstudiantes[i].getMiProfesorEs().getGrupo();
                dataGridView1.Rows[i].Cells[7].Value = ListaEstudiantes[i].getDireccion();
                dataGridView1.Rows[i].Cells[8].Value = ListaEstudiantes[i].getTelefono();
                dataGridView1.Rows[i].Cells[9].Value = ListaEstudiantes[i].getrh();
                dataGridView1.Rows[i].Cells[10].Value = ListaEstudiantes[i].getEmail();
                dataGridView1.Rows[i].Cells[11].Value = ListaEstudiantes[i].getFechaIngreso();
            }
            dataGridView2.RowCount = ListaProfesores.Count + 1;
            for (int i = 0; i < ListaProfesores.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = ListaProfesores[i].getNombre();
                dataGridView2.Rows[i].Cells[1].Value = ListaProfesores[i].getApellido();
                dataGridView2.Rows[i].Cells[2].Value = ListaProfesores[i].getEdad();
                dataGridView2.Rows[i].Cells[3].Value = ListaProfesores[i].getSexo();
                dataGridView2.Rows[i].Cells[4].Value = ListaProfesores[i].getDocumento();
                dataGridView2.Rows[i].Cells[5].Value = ListaProfesores[i].getGrupo();
                dataGridView2.Rows[i].Cells[6].Value = ListaProfesores[i].getTitulo();
                dataGridView2.Rows[i].Cells[7].Value = ListaProfesores[i].getEscalafon();
                dataGridView2.Rows[i].Cells[8].Value = ListaProfesores[i].getJornada();
                dataGridView2.Rows[i].Cells[9].Value = ListaProfesores[i].getDireccion();
                dataGridView2.Rows[i].Cells[10].Value = ListaProfesores[i].getTelefono();
                dataGridView2.Rows[i].Cells[11].Value = ListaProfesores[i].getrh();
                dataGridView2.Rows[i].Cells[12].Value = ListaProfesores[i].getEmail();
                dataGridView2.Rows[i].Cells[13].Value = ListaProfesores[i].getFechaIngreso();
            }
            dataGridView4.RowCount = ListaEmpleados.Count + 1;
            for (int i = 0; i < ListaEmpleados.Count; i++)
            {
                dataGridView4.Rows[i].Cells[0].Value = ListaEmpleados[i].getNombre();
                dataGridView4.Rows[i].Cells[1].Value = ListaEmpleados[i].getApellido();
                dataGridView4.Rows[i].Cells[2].Value = ListaEmpleados[i].getEdad();
                dataGridView4.Rows[i].Cells[3].Value = ListaEmpleados[i].getSexo();
                dataGridView4.Rows[i].Cells[4].Value = ListaEmpleados[i].getDocumento();
                dataGridView4.Rows[i].Cells[5].Value = ListaEmpleados[i].getTrabajo();
            }
            dataGridView5.RowCount = ListaDeVisitantes.Count + 1;
            for (int i = 0; i < ListaDeVisitantes.Count; i++)
            {
                dataGridView5.Rows[i].Cells[0].Value = ListaDeVisitantes[i].getNombre();
                dataGridView5.Rows[i].Cells[1].Value = ListaDeVisitantes[i].getApellido();
                dataGridView5.Rows[i].Cells[2].Value = ListaDeVisitantes[i].getSexo();
                dataGridView5.Rows[i].Cells[3].Value = ListaDeVisitantes[i].getAsunto();
                dataGridView5.Rows[i].Cells[4].Value = ListaDeVisitantes[i].getRelacion();
            }
            actualizarInfo();
        }    //funcion Mostrar en Datagrid>Administrador>Ver

        private void CambiarInterfaz(string interfaz)
        {
            switch (interfaz)
            {
                case "Administrador":
                    Bibliotecario.Visible = false;
                    Estudiante.Visible = false;
                    Profesor.Visible = false;
                    //Administrador.Width = 453;
                    //Administrador.Height = 349;
                    Administrador.Dock = DockStyle.Fill;  
                    Aleatorios.Visible = true;
                    Administrador.Visible = true;

                    break;
                case "Bibliotecario":
                    Administrador.Visible = false;
                    Estudiante.Visible = false;
                    Profesor.Visible = false;
                    //Bibliotecario.Width = 453;
                    //Bibliotecario.Height = 349;
                    Bibliotecario.Dock = DockStyle.Fill;
                    Aleatorios.Visible = false;
                    Bibliotecario.Visible = true;
                    break;
                case "Estudiante":
                    label19.Visible = false;
                    label21.Visible = false;
                    textBox18.Visible = false;
                    textBox19.Visible = false;
                    buttonIngresar.Visible = false;
                    //
                    //Estudiante.Width = 453;
                    //Estudiante.Height = 349;
                    Estudiante.Dock = DockStyle.Fill;
                    Estudiante.Visible = true;
                    Aleatorios.Visible = false;
                    break;
                case "Profesor":
                    label19.Visible = false;
                    label21.Visible = false;
                    textBox18.Visible = false;
                    textBox19.Visible = false;
                    buttonIngresar.Visible = false;
                    Aleatorios.Visible = false;
                    //
                   // labelEstNombre.Text 
                    //
                    //Profesor.Width = 453;
                    //Profesor.Height = 349;
                    Profesor.Dock = DockStyle.Fill;
                    Profesor.Visible = true;
                    break;
                default:
                    break;
            }
        }   // ocultar TabControl# y mostrar Tabcontrol(Deseado)

        public void prestarLibro()
        {
            txtPrestHasta.Text = dtpPrestHasta.Value.ToString();
            Prestamos prestamo = new Prestamos(txtPrestador.Text, int.Parse(txtCodPrestador.Text), txtCodLibro.Text, txtLibro.Text, DateTime.Today, txtPrestHasta.Text);
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = ListaLibros;
            dgvLibros.Rows.Add();
        }   //Presta libros segun el codigo

        public void guardarLibro()
        {
            ListaLibros.Add(new Libro(txtCodigo.Text.ToLower(),true, txtTitulo.Text.ToLower(), txtAutor.Text.ToLower(), int.Parse(txtEdicion.Text), txtEditorial.Text.ToLower(), int.Parse(txtEjemplares.Text), cmbMateria.Text, DateTime.Today));
            b.InsertarLibro(new Libro(txtCodigo.Text.ToLower(), true, txtTitulo.Text.ToLower(), txtAutor.Text.ToLower(), int.Parse(txtEdicion.Text), txtEditorial.Text.ToLower(), int.Parse(txtEjemplares.Text), cmbMateria.Text, DateTime.Today));
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = ListaLibros;
            dgvLibros.Rows.Add();
        }           //Guarda libros

        public void ordenarLibroPor(string pOpcion)
        {
            if (pOpcion == "Autor")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.Autor).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
            else if (pOpcion == "Codigo")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.CodLibro).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
            else if (pOpcion == "Editorial")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.Editorial).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
            else if (pOpcion == "Materia")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.Materia).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
            else if (pOpcion == "Titulo")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.Titulo).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
            else if (pOpcion == "FechaIngreso")
            {
                List<Libro> listaOrdenada = ListaLibros.OrderBy(objeto => objeto.FechaIngreso).ToList();
                dgvOrden.DataSource = null;
                dgvOrden.DataSource = listaOrdenada;
            }
        }

        //Limpiar campos de textbox's
        public void limpiarCamposPrestamo()
        {
            txtCodPrestador.Text = null;
            txtPrestador.Text = string.Empty;
            txtCodLibro.Text = string.Empty;
            txtLibro.Text = string.Empty;
        }
        public void limpiarCamposRegistro()
        {
            txtCodigo.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtEdicion.Text = null;
            txtEditorial.Text = string.Empty;
            txtEjemplares.Text = null;
            cmbMateria.Text = string.Empty;
            txtNoPaginas.Text = null;
            txtFechaIngreso.Text = string.Empty;
        }
        public void limpiarCamposRegistroEstudiante()
        {
            textNombre.Text = string.Empty;
            comboEdad.Text = null;
            textDocumento.Text = string.Empty;
            textTelefono.Text = string.Empty;
            textEmail.Text = string.Empty;
            textApellido.Text = string.Empty;
            radioM.Text = null;
            radioF.Text = null;
            textDireccion.Text = string.Empty;
            comboRh.Text = null;
        }
        public void limpiarCamposRegistroDocente()
        {
            textNombreDoc.Text = string.Empty;
            comboEdadDoc.Text = null;
            textDocumentoDoc.Text = string.Empty;
            textTelefonoDoc.Text = string.Empty;
            textEmailDoc.Text = string.Empty;
            textAsignaturaDoc.Text = string.Empty;
            textApellidoDoc.Text = string.Empty;
            radioMDoc.Text = null;
            radioFDoc.Text = null;
            textDireccionDoc.Text = string.Empty;
            comboRhDoc.Text = null;
            textEscalafonDoc.Text = string.Empty;
            textTituloDoc.Text = string.Empty;
            comboJornada.Text = null;
        }
        public void limpiarCamposRegistroPersonal()
        {
            textAdmPerNombre.Text = string.Empty;
            comboAdmPerEdad.Text = null;
            textAdmPerDocumento.Text = string.Empty;
            textAdmPerApellido.Text = string.Empty;
            radioAdmPerM.Text = null;
            radioAdmPerF.Text = null;
            comboAdmPerTrabajo.Text = string.Empty;
        }
        public void limpiarCamposRegistroVisitas()
        {
            textAdmVisitNombre.Text = string.Empty;
            comboAdmVisitRelacion.Text = null;
            textAdmVisitAsunto.Text = string.Empty;
            textAdmVisitApellido.Text = string.Empty;
            radioAdmVisitM.Text = null;
            radioAdmVisitF.Text = null;
        }
        public void limpiarCamposBusqueda()
        {
            comboAdminBusquedad.Text = null;
            textAdmBusquedad.Text = string.Empty;
        }

        // eventos del stripMenu
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.ActiveForm.Close();
        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarInterfaz("Administrador");
        }
        private void bibliotecarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarInterfaz("Bibliotecario");
        }
        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Administrador.Visible = false;
            Bibliotecario.Visible = false;
            Profesor.Visible = false;
            label19.Visible = true;
            label21.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            buttonIngresar.Visible = true;
        }
        private void profesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Administrador.Visible = false;
            Bibliotecario.Visible = false;
            Estudiante.Visible = false;
            label19.Visible = true;
            label21.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            buttonIngresar.Visible = true;
            //MessageBox.Show("Buen dia, ¿cual es tu nombre?: ");
        
        }



        private void button9_Click(object sender, EventArgs e)
        {
            Estudiantes usuarioE = ListaEstudiantes.Find(x => x.getNombre().Contains(textBox18.Text));
            if (usuarioE == null)
            {
                Profesor usuarioP = ListaProfesores.Find(x => x.getNombre().Contains(textBox18.Text));
                MessageBox.Show(usuarioP.getClave());
                if (usuarioP == null)
                    MessageBox.Show("Error #54645\t Datos incorrectos");
                else if (textBox19.Text == usuarioP.getClave())
                {
                    CambiarInterfaz("Profesor");
                    labelProfInfoNombre.Text = usuarioP.getNombre();
                    labelProfInfoApellido.Text = usuarioP.getApellido();
                    labelProfInfoEdad.Text = usuarioP.getEdad().ToString();
                    labelProfInfoGenero.Text = Convert.ToString(usuarioP.getSexo());
                    labelProfInfoDocu.Text = usuarioP.getDocumento();
                    labelProfInfoDireccion.Text = usuarioP.getDireccion();
                    labelProfInfoGrupo.Text = usuarioP.getGrupo();
                    labelProfInfoTelefono.Text = usuarioP.getTelefono();
                    labelProfInfoRh.Text = usuarioP.getrh();
                    labelProfInfoEmail.Text = usuarioP.getEmail();
                    labelProfInfoFechaIngreso.Text = Convert.ToString(usuarioP.getFechaIngreso());
                    for (int i = 0; i < usuarioP.getMisEstudiantesCount(); i++)
                    {
                    listBox4.Items.Add(usuarioP.getMisEstudiantes(i).ToString() + "Grupo:\t" + usuarioP.getMisEstudiantes(i).getCursoGrado() + "/" + usuarioP.getMisEstudiantes(i).getMiProfesorEs().getGrupo());
                    }
                }
                else
                    MessageBox.Show("Datos incorrectos");
            }
            else
                if (textBox19.Text == usuarioE.getClave())
            {
                CambiarInterfaz("Estudiante");
                labelEstNombre.Text = usuarioE.getNombre();
                labelEstApellido.Text = usuarioE.getApellido();
                labelEstEdad.Text = usuarioE.getEdad().ToString();
                labelEstGenero.Text = Convert.ToString(usuarioE.getSexo());
                labelEstDocumento.Text = usuarioE.getDocumento();
                labelEstDireccion.Text = usuarioE.getDireccion();
                labelEstTelefono.Text = usuarioE.getTelefono();
                labelEstRh.Text = usuarioE.getrh();
                labelEstEmail.Text = usuarioE.getEmail();
                labelEstFechaIngreso.Text = Convert.ToString(usuarioE.getFechaIngreso());
                if ((usuarioE.getMiProfesorEs()) != null)
                {

                    labelEstPerGrupo.Text = (usuarioE.getMiProfesorEs()).getGrupo();
                    for (int i = 0; i < usuarioE.getMiProfesorEs().tamannoMisEstudiantes(); i++)
                    {
                        listBox3.Items.Add(usuarioE.getMiProfesorEs().getMisEstudiantes(i).ToString());
                        if (usuarioE.getMiProfesorEs().getMisEstudiantes(i) == usuarioE)
                        {
                            listBox3.Items[i] += "   Yo*";
                        }
                    }
                }

            }
                else
                    MessageBox.Show("la Clave no coincide con el usuario");
                textBox18.Text = string.Empty;
                textBox19.Text = string.Empty;
        }   //Ingreso de usuario-clave

        private void button4_Click(object sender, EventArgs e)
        {
           ListaEstudiantes.Add(new Estudiantes(textNombre.Text, textApellido.Text, Convert.ToInt16(comboEdad.Text), radioM.Checked == true ? true : radioF.Checked == true ? false : false , textDocumento.Text, textDireccion.Text, textTelefono.Text, comboRh.Text, textEmail.Text, Convert.ToInt32(textAdmEstCurso.Text)));
            b.InsertarEstudiante(new Estudiantes(textNombre.Text, textApellido.Text, Convert.ToInt16(comboEdad.Text), radioM.Checked == true ? true : radioF.Checked == true ? false : false, textDocumento.Text, textDireccion.Text, textTelefono.Text, comboRh.Text, textEmail.Text, Convert.ToInt32(textAdmEstCurso.Text)));
            actualizarInfo();
           limpiarCamposRegistroEstudiante();
        }   //ingresar estudiantes

        private void button7_Click(object sender, EventArgs e)
        {
           ListaProfesores.Add(new Profesor(textNombreDoc.Text, textApellidoDoc.Text, Convert.ToInt16(comboEdadDoc.Text), radioMDoc.Checked == true ? true : radioFDoc.Checked == true ? false : false, textDocumentoDoc.Text, textDireccionDoc.Text, textTelefonoDoc.Text, comboRhDoc.Text, textEmailDoc.Text,textTituloDoc.Text,Convert.ToInt16(textEscalafonDoc.Text),Convert.ToBoolean(comboJornada.Text)));
            b.InsertarProfesor(new Profesor(textNombreDoc.Text, textApellidoDoc.Text, Convert.ToInt16(comboEdadDoc.Text), radioMDoc.Checked == true ? true : radioFDoc.Checked == true ? false : false, textDocumentoDoc.Text, textDireccionDoc.Text, textTelefonoDoc.Text, comboRhDoc.Text, textEmailDoc.Text, textTituloDoc.Text, Convert.ToInt16(textEscalafonDoc.Text), Convert.ToBoolean(comboJornada.Text)));
            actualizarInfo();
            limpiarCamposRegistroDocente();
        }   //ingresar profesor


        private void button6_Click(object sender, EventArgs e)
        {
            string caso = comboAdminBusquedad.Text;
            string buscarPalabra = textAdmBusquedad.Text;
           // Estudiantes encontrado = ListaEstudiantes.Find(x => x.getNombre().Contains(buscarPalabra));
            switch (caso)
            {
                case "Nombre":
                    //encontrado =  ListaEstudiantes.Find(x => x.getNombre().Contains(buscarPalabra));
                    MessageBox.Show(ListaEstudiantes.Find(x => x.getNombre().Contains(buscarPalabra)).ToString());
                    break;
                case "Apellido":
                    //encontrado =  ListaEstudiantes.Find(x => x.getApellido().Contains(buscarPalabra));
                    MessageBox.Show(ListaEstudiantes.Find(x => x.getApellido().Contains(buscarPalabra)).ToString());
                    break;
                case "Documento":
                    //encontrado = ListaEstudiantes.Find(x => x.getDocumento().Contains(buscarPalabra));
                    MessageBox.Show(ListaEstudiantes.Find(x => x.getDocumento().Contains(buscarPalabra)).ToString());
                    break;
                 //    default:
            }
            if (ListaEstudiantes.Find(x => x.getDocumento().Contains(buscarPalabra)) == null)
                MessageBox.Show("No encontrado");
            limpiarCamposBusqueda();
        }   //Busquedad de estudiantes en Administrador

        private void comboEdad_MouseClick(object sender, MouseEventArgs e)
        {
            comboEdad.DroppedDown = true;
        }

        private int numGrupos()
        {
            int numgrupos=0;
            foreach (Profesor i in ListaProfesores)
            {
                if (i.getGrupo() != null)
                    numgrupos++; 
            }
            return numgrupos;
        }   //Cantidad de grupos en el colegio

        //lo malo de esta es que si organizas el datagrib, 
        private void atribuirRelaciones()
        {
            int cursoDeEstudiantes;
            int selectedRowCount2 = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);  //obtiene la cantidad de filas seleccionadas
            if (selectedRowCount2 == 1 && ListaProfesores[dataGridView2.SelectedRows[0].Index].getGrupo() == null)
            {
                int selectedRowCount1 = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);  //obtiene la cantidad de filas seleccionadas
                if (selectedRowCount1 > 1)
                {
                    cursoDeEstudiantes = ListaEstudiantes[dataGridView1.SelectedRows[0].Index].getCursoGrado();
                    if (cursoDeEstudiantes == ListaEstudiantes[dataGridView1.SelectedRows[1].Index].getCursoGrado())
                        for (int i = 0; i < selectedRowCount1; i++)
                            {
                                if ((ListaEstudiantes[dataGridView1.SelectedRows[i].Index].getCursoGrado() == cursoDeEstudiantes))
                                     {
                                         ListaEstudiantes[dataGridView1.SelectedRows[i].Index].setMiProfesorEs(ListaProfesores[dataGridView2.SelectedRows[0].Index]);
                                         ListaProfesores[dataGridView2.SelectedRows[0].Index].setMisEstudiantes(ListaEstudiantes[dataGridView1.SelectedRows[i].Index]);
                                     }
                          
                        // si quieres imprimir en el mismo orden seleccionados cambias (i) por (selectedRowCount1 - i)
                            }
                    else
                        MessageBox.Show("no son del mismo curso");
                    //la primera vez el grupo es 0 si sobreescribes es 1, entonces dan diferentes
                    if (ListaProfesores[dataGridView2.SelectedRows[0].Index].getMisEstudiantesCount() > 0)
                    {
                       ListaProfesores[dataGridView2.SelectedRows[0].Index].setGrupo(Convert.ToString((char)(65 + numGrupos())));
                    }
                }
                else
                    MessageBox.Show("Seleccione algun estudiante");
            }
            else

                MessageBox.Show("No sele puede asignar mas de un profesor(De momento)");
        }   //liga Estudiantes con un profesor

        private void button2_Click_1(object sender, EventArgs e)
        {
            atribuirRelaciones();
            Mostrar();
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            ListaEmpleados.Add(new Personal(textAdmPerNombre.Text, textAdmPerApellido.Text , textAdmPerDocumento.Text, radioAdmPerM.Checked == true ? true : radioAdmPerF.Checked == true ? false : false, comboAdmPerTrabajo.Text));
            b.InsertarPersonal(new Personal(textAdmPerNombre.Text, textAdmPerApellido.Text, textAdmPerDocumento.Text, radioAdmPerM.Checked == true ? true : radioAdmPerF.Checked == true ? false : false, comboAdmPerTrabajo.Text));
            actualizarInfo();
            limpiarCamposRegistroPersonal();
        } // Inserta personal
        private void button10_Click(object sender, EventArgs e)
        {
            ListaDeVisitantes.Add(new Visitante(textAdmVisitNombre.Text, textAdmVisitApellido.Text, null ,radioAdmVisitM.Checked == true ? true : radioAdmVisitF.Checked == true ? false : false,comboAdmVisitRelacion.Text,textAdmVisitAsunto.Text));
            b.InsertarVisitante(new Visitante(textAdmVisitNombre.Text, textAdmVisitApellido.Text, null, radioAdmVisitM.Checked == true ? true : radioAdmVisitF.Checked == true ? false : false, comboAdmVisitRelacion.Text, textAdmVisitAsunto.Text));
            actualizarInfo();
            limpiarCamposRegistroVisitas();
        } //Inserta una nueva visita

        private void Administrador_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (Administrador.SelectedTab == Administrador.TabPages[5])
            {
                Mostrar();
               
            }
        }   //Mostar si está en tab"Ver"

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            Libro encontrado = ListaLibros.Find(x => x.Titulo.Contains(txtLibro.Text));
            if (encontrado != null)
            {
                prestarLibro();
                ListaLibros.Find(x => x.Titulo.Contains(txtLibro.Text)).Dispinibilidad1 = false;
                limpiarCamposPrestamo();
                MessageBox.Show("Libro prestado");
            }
            else
                MessageBox.Show("Libro no encontrado");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarLibro();
            limpiarCamposRegistro();
            MessageBox.Show("Libro guardado");
        }

        private void GuerdadExcel(DataGridView datagridx)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            int hoja;
            switch (datagridx.Name)
            {
                case "dgvLibros":
                    MessageBox.Show("Exporando Libros");
                    hoja = 5;
                    break;
                case "dataGridView1":
                    MessageBox.Show("Exporando Estudiantes");
                    hoja = 1;
                    break;
                case "dataGridView2":
                    MessageBox.Show("Exporando Profesores");
                    hoja = 2;
                    break;
               /* case "dataGridView3":
                    MessageBox.Show("Exporando Grupo");
                    hoja = 3;
                    break;
              */    case "dataGridView4":
                    MessageBox.Show("Exporando Personal");
                    hoja = 3;
                    break;
                case "dataGridView5":
                    MessageBox.Show("Exporando Visitantes");
                    hoja = 4;
                    break;
                default:
                    hoja = 1;
                    MessageBox.Show("Nunca");
                    break;
            }
            object misValue = System.Reflection.Missing.Value;

            Workbook excelLibro;
            if (System.IO.File.Exists("C:\\Users\\user\\Desktop\\Excel.xls"))
            {
                excelLibro = excelApp.Workbooks.Open("C:\\Users\\user\\Desktop\\Excel.xls",
      Type.Missing, false, Type.Missing, Type.Missing, Type.Missing,
      Type.Missing, Type.Missing, Type.Missing, true, Type.Missing,
      Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            else
            {
                excelLibro = excelApp.Workbooks.Add();
            Worksheet excelHoja1 = (Worksheet)excelLibro.Worksheets.get_Item(1);
            excelHoja1.Name = "Libros";
            Worksheet excelHoja2 = (Worksheet)excelLibro.Worksheets.Add();
            excelHoja2.Name = "Visitantes";
            Worksheet excelHoja3 = (Worksheet)excelLibro.Worksheets.Add();
            excelHoja3.Name = "Personal";
            Worksheet excelHoja4 = (Worksheet)excelLibro.Worksheets.Add();
            excelHoja4.Name = "Docentes";
            Worksheet excelHoja5 = (Worksheet)excelLibro.Worksheets.Add();
            excelHoja5.Name = "Estudiantes";
            }

            if (excelApp == null)
            {
                MessageBox.Show("Excel No pudo crearse!!");
                return;
            }
          //  foreach (Worksheet hojaactual in excelLibro.Worksheets)
            {

            for (int i = 0; i < datagridx.RowCount; i++)
            {
                for (int j = 0; j < datagridx.ColumnCount; j++)
                {
                        excelLibro.Worksheets.get_Item(hoja).Cells[i+1, j+1] = datagridx.Rows[i].Cells[j].Value;
                }
            }
            }
            if (System.IO.File.Exists("C:\\Users\\user\\Desktop\\Excel.xls"))  //para que no pregunte sobreescritura
                excelLibro.Save();
            else
                excelLibro.SaveAs("C:\\Users\\a4lfr\\Desktop\\Excel.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, false, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
             releaseObject(excelLibro.Worksheets.get_Item(hoja));

            excelLibro.Close(true, misValue, misValue);
            excelApp.Quit();

            releaseObject(excelLibro);
            releaseObject(excelApp);



            MessageBox.Show("Excel file created , you can find the file jajajajaa d:\\csharp-Excel.xls");

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void Bibliotecario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bibliotecario.SelectedTab == Bibliotecario.TabPages[3])
            {
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = ListaLibros;
                //

                GuerdadExcel(dgvLibros);

            }


        }   //mostrar si tab ver

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenarLibroPor(cmbOrdenar.Text);
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void btnBusqLibro_Click(object sender, EventArgs e)
        {
            string caso = cmbBusqLibro.Text;
            string buscarPalabra = txtBusqLibro.Text;
            // Estudiantes encontrado = ListaEstudiantes.Find(x => x.getNombre().Contains(buscarPalabra));
            switch (caso)
            {
                case "Autor":
                    //encontrado =  ListaEstudiantes.Find(x => x.getNombre().Contains(buscarPalabra));
                    MessageBox.Show(ListaLibros.Find(x => x.Autor.Contains(buscarPalabra)).ToString());
                    break;
                case "Codigo":
                    //encontrado =  ListaEstudiantes.Find(x => x.getApellido().Contains(buscarPalabra));
                    MessageBox.Show(ListaLibros.Find(x => x.CodLibro.Contains(buscarPalabra)).ToString());
                    break;
                case "Editorial":
                    //encontrado = ListaEstudiantes.Find(x => x.getDocumento().Contains(buscarPalabra));
                    MessageBox.Show(ListaLibros.Find(x => x.Editorial.Contains(buscarPalabra)).ToString());
                    break;
                case "Materia":
                    MessageBox.Show(ListaLibros.Find(x => x.Materia.Contains(buscarPalabra)).ToString());
                    break;
                case "Titulo":
                    MessageBox.Show(ListaLibros.Find(x => x.Titulo.Contains(buscarPalabra)).ToString());
                    break;
                    //    default:
            }
            if (ListaEstudiantes.Find(x => x.getDocumento().Contains(buscarPalabra)) == null)
                MessageBox.Show("No encontrado");
        }   //Busca libros en Bibliotecario

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                //case tabControl1.TabPages[2].Text:
                case "Alumnos":
                    GuerdadExcel(dataGridView1);
                    GuerdadExcel(dataGridView2); //por si se ha asignado algun grupo
                    break;
                case "Profesores":
                    GuerdadExcel(dataGridView1);
                    GuerdadExcel(dataGridView2);
                    break;
                case "Personal":
                    GuerdadExcel(dataGridView4);
                    break;
                case "Visitas":
                    GuerdadExcel(dataGridView5);
                    break;
                default:
                    break;
            }


        }
    }
        
    }











