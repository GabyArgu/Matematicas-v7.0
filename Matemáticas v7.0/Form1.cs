using System.IO;
using WMPLib;

namespace Matemáticas_v7._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Botones para cambiar de pantalla en el panel------------------------------------------------------------------------
        private void Limpiar()
        {
            //Limpiar Programa 1
            //Se limpian todos los campos
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtA.Focus();

            //Limpiar Programa 2
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtAnguB.Text = "";
            txtAnguC.Text = "";
            txtLadoA.Focus();


            //Limpiar Programa 3
            txtboxA.Text = "";
            txtboxB.Text = "";
            txtboxC.Text = "";
            txtboxD.Text = "";
            txtboxE.Text = "";
            txtboxF.Text = "";
            txtboxX.Text = "";
            txtboxY.Text = "";
            txtboxA.Focus();

            //Limpiar Programa 4
            txtDin1.Text = "";
            txtDin2.Text = "";
            txtDin3.Text = "";
            txtDin4.Text = "";
            txtDin5.Text = "";
            txtDin6.Text = "";
            txtDinero.Text = "";
            txtDinero.Focus();

            //Limpiar  Programa 5
            //Se limpian todos los campos
            txtboxHerencia.Text = "";
            txtboxHijo1.Text = "";
            txtboxHijo2.Text = "";
            txtboxHijo3.Text = "";
            txtboxAbogado.Text = "";
            txtboxHerencia.Focus();


            //Programa 6
            txtDiasT.Text = "";
            txtMesA.Text = "";
            txtDiasT.Focus();

            //Limpiar programa 7
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtMcm.Text = "";
            txtNumero1.Focus();

            //Programa 8 el ultimo
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtMayor.Text = "";
            txtMedio.Text = "";
            txtMenor.Text = "";
            txtNum1.Focus();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 1 de tabControl
            tabControl1.SelectedIndex = 1;
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);

            //Poner en regular a todos los demas boton
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wplayer;
            wplayer = new WindowsMediaPlayer();
            wplayer.URL = @"spato.mp3"; //Ubicacion del archivo
            wplayer.controls.play();

            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 8;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 2 de tabControl
            tabControl1.SelectedIndex = 2;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Bold);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 3 de tabControl
            tabControl1.SelectedIndex = 3;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Bold);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 4 de tabControl
            tabControl1.SelectedIndex = 4;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Bold);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 5 de tabControl
            tabControl1.SelectedIndex = 5;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Bold);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 6 de tabControl
            tabControl1.SelectedIndex = 6;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Bold);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 8 de tabControl
            tabControl1.SelectedIndex = 9;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 7 de tabControl
            tabControl1.SelectedIndex = 7;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Bold);

            //Limpiar todos los campos de todo
            Limpiar();
        }

        //Fin de Botones para cambiar de pantalla en el panel-------------------------------------------------------------------



        //Inicio de Programación del primer programa----------------------------------------------------------------------------
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validacion de no dejar espacios
            if (txtA.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de A ", "Error");
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de B ", "Error");
                txtB.Focus();
                return;
            }
            if (txtC.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de C ", "Error");
                txtC.Focus();
                return;
            }

            //Se programa la ecuación

            //declaración de variables de tipo Double
            double a, b, c, deter, x1, x2, deterc1, deterc2;
            //obtenemos las variables a, b y c de losTextBox txta,txtb y txtc
            //para poder usarlas las convertimos a tipo Double
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            //realizamos la operación de la fórmulageneral, para obtener los dos valores de x
            //Math.sqrt determina la raíz cuadrada
            deter = (Math.Pow(b, 2)) - 4 * a * c;

            if (deter < 0)
            {
                //Al no tener solución en los reales, se resolvera como numero imaginario
                deter = -deter;
                deterc1 = -b / (2 * a);
                deterc2 = Math.Sqrt(deter) / (2 * a);

                //Se imprimen los valores tanto positivo como negativo concatenando el simbolo de imaginario i
                txtX1.Text = Math.Round(deterc1, 2).ToString() + " + " + Math.Round(deterc2, 2).ToString() + " i";
                txtX2.Text = Math.Round(deterc1, 2).ToString() + " - " + Math.Round(deterc2, 2).ToString() + " i";
            }
            else if (a == 0)
            {
                txtX1.Text = "No es ecuación de segundo grado";
                txtX2.Text = "No es ecuación de segundo grado";
            }
            else
            {
                x1 = (-b + Math.Sqrt(deter)) / (2 * a);
                x2 = (-b - Math.Sqrt(deter)) / (2 * a);
                //se imprimen los resultados de las x en susrespectivas etiquetas
                txtX1.Text = (Math.Round(x1, 2)).ToString();
                txtX2.Text = (Math.Round(x2, 2)).ToString();
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo se aceptan valores numericos", "Alerta");
                e.Handled = true;
                return;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo se aceptan valores numericos", "Alerta");
                e.Handled = true;
                return;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo se aceptan valores numericos", "Alerta");
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpian todos los campos
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtA.Focus();
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                //Validacion para que no escriban nada
                e.Handled = true;
                return;
            }
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                //Validacion para que no escriban nada
                e.Handled = true;
                return;
            }
        }

        private void btnCalcular_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento Leave se cambia la imagen de la tiza para cuando el mouse este fuera del btn
            btnCalcular.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen del borrador
            btnLimpiar.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia el fondo de pato
            btnpato.BackgroundImage = global::Matemáticas_v7._0.Properties.Resources.probar;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnpato.BackgroundImage = global::Matemáticas_v7._0.Properties.Resources.pato;
        }

        private void home_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Quieres salir del programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (cerrar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);


        }

        private void home9_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);

        }

        //Fin de Programación del primero programa-----------------------------------------------------------------------------


        //Inicio de Programación del segundo programa-------------------------------------------------------------------------

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            //Calcular por bobaaaaaaaaaaaaa
        }

        private void btnLimpiar2_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen del borrador
            btnLimpiar2.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnLimpiar2_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar2.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            //Limpiar ahora

            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtAnguB.Text = "";
            txtAnguC.Text = "";
            txtLadoA.Focus();
        }

        private void btnCalcular2_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular2.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnCalcular2_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento Leave se cambia la imagen de la tiza para cuando el mouse este fuera del btn
            btnCalcular2.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void home2_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        //Fin de Programación del segundo programa-----------------------------------------------------------------------------


        //Inicio de Programación del tercer programa y demas cosas de Elmer -----------------------------------------------------------------------------
        private void btnLimpiar3_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen del borrador
            btnLimpiar3.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnLimpiar3_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar3.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            //Validacion de no dejar espacios
            if (txtboxA.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de A ", "Error");
                txtboxA.Focus();
                return;
            }
            if (txtboxB.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de B ", "Error");
                txtboxB.Focus();
                return;
            }
            if (txtboxC.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de C ", "Error");
                txtboxC.Focus();
                return;
            }
            if (txtboxD.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de D ", "Error");
                txtboxD.Focus();
                return;
            }
            if (txtboxE.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de E ", "Error");
                txtboxE.Focus();
                return;
            }
            if (txtboxF.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de F ", "Error");
                txtboxF.Focus();
                return;
            }

            //Se programa la ecuación

            // Declaracion de variables
            double da, db, dc, dd, de, df, deterg, deterx, detery, rx, ry;
            // Entrada de datos
            da = Double.Parse(txtboxA.Text);
            db = Double.Parse(txtboxB.Text);
            dc = Double.Parse(txtboxC.Text);
            dd = Double.Parse(txtboxD.Text);
            de = Double.Parse(txtboxE.Text);
            df = Double.Parse(txtboxF.Text);
            Console.Write("\n");
            // Proceso de los datos
            deterg = (da * dd) - (db * dc);
            deterx = (de * dd) - (db * df);
            detery = (da * df) - (de * dc);
            rx = deterx / deterg;
            ry = detery / deterg;

            // Salida de los datos
            txtboxX.Text = (Math.Round(rx, 2)).ToString();
            txtboxY.Text = (Math.Round(ry, 2)).ToString();
        }

        private void btnCalcular3_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular3.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnCalcular3_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento Leave se cambia la imagen de la tiza para cuando el mouse este fuera del btn
            btnCalcular3.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            //Se limpian todos los campos
            txtboxA.Text = "";
            txtboxB.Text = "";
            txtboxC.Text = "";
            txtboxD.Text = "";
            txtboxE.Text = "";
            txtboxF.Text = "";
            txtboxX.Text = "";
            txtboxY.Text = "";
            txtboxA.Focus();
        }

        private void txtboxDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo se aceptan valores numericos", "Alerta");
                e.Handled = true;
                return;
            }
        }

        private void txtboxResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                //Validacion para que no escriban nada
                e.Handled = true;
                return;
            }
        }

        private void home3_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        //Fin de Programación del tercer programa-----------------------------------------------------------------------------

        //Inicio de Programación del cuarto programa-------------------------------------------------

        private void btnLimpiar4_Click(object sender, EventArgs e)
        {
            txtDin1.Text = " ";
            txtDin2.Text = " ";
            txtDin3.Text = " ";
            txtDin4.Text = " ";
            txtDin5.Text = " ";
            txtDin6.Text = " ";
            txtDinero.Text = " ";
            txtDinero.Focus();
        }

        private void btnLimpiar4_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar4.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar4_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento Leave se cambia la imagen de la tiza para cuando el mouse este fuera del btn
            btnLimpiar4.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnCalcular4_Click(object sender, EventArgs e)
        {
            int txtD1, txtD2, txtD3, txtD4, txtD5, txtD6, denom, residuo, d;

            d = int.Parse(txtDinero.Text);

            //Programción para $100
            denom = 100;
            txtD1 = d / denom;
            residuo = d % denom;

            if (txtD1 > 0)
            {
                txtDin6.Text = txtD1.ToString();
                txtDin6.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin6.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin6.Text = txtD1.ToString();
            }


            //Para $50...
            d = residuo;
            denom = 50;
            txtD2 = d / denom;
            residuo = d % denom;

            if (txtD2 > 0)
            {
                txtDin5.Text = txtD2.ToString();
                txtDin5.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin5.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin5.Text = txtD2.ToString();
            }

            //Programación para $20-----
            d = residuo;
            denom = 20;
            txtD3 = d / denom;
            residuo = d % denom;

            if (txtD3 > 0)
            {
                txtDin4.Text = txtD3.ToString();
                txtDin4.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin4.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin4.Text = txtD3.ToString();
            }

            //Programación para $10

            d = residuo;
            denom = 10;
            txtD4 = d / denom;
            residuo = d % denom;

            if (txtD4 > 0)
            {
                txtDin3.Text = txtD4.ToString();
                txtDin3.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin3.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin3.Text = txtD4.ToString();
            }

            //Para $5------

            d = residuo;
            denom = 5;
            txtD5 = d / denom;
            residuo = d % denom;

            if (txtD5 > 0)
            {
                txtDin2.Text = txtD5.ToString();
                txtDin2.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin2.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin2.Text = txtD5.ToString();
            }

            //Para $1-----
            d = residuo;
            denom = 1;
            txtD6 = d / denom;

            if (txtD6 > 0)
            {
                txtDin1.Text = txtD6.ToString();
                txtDin1.Font = new Font("KG Ten Thousand Reasons", 18F, FontStyle.Bold, GraphicsUnit.Point);
                txtDin1.ForeColor = Color.FromArgb(241, 237, 146);
            }
            else
            {
                txtDin1.Text = txtD6.ToString();
            }

        }

        private void btnCalcular4_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular4.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular4_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular4.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        //Fin de Programación del cuarto programa------------------------------------------------

        //Inicio de Programación del quinto programa-----------------------------------------------------------------------------

        private void home5_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        private void btnCalcular5_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular5.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular5_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular5.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnLimpiar5_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar5.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar5_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar5.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnCalcular5_Click(object sender, EventArgs e)
        {
            //Validacion de no dejar espacios
            if (txtboxHerencia.Text == "")
            {
                MessageBox.Show(" Favor ingresar el valor de A ", "Error");
                txtboxHerencia.Focus();
                return;
            }

            // Declaracion de variables
            double x, primerh, segundoh, tercerh, abogado1, abogado2, abogado3, abogadoT, terceraparte;

            //Inicializacion de variables
            abogado1 = 0;
            abogado2 = 0;
            abogado3 = 0;
            abogadoT = 0;
            terceraparte = 0;

            // Entrada de datos
            x = Double.Parse(txtboxHerencia.Text);

            // Proceso de los datos
            terceraparte = x / 3;
            primerh = x / 3;
            if (primerh < terceraparte)
            {
                abogado1 = primerh * 0.03;
            }
            else
            {
                abogado1 = primerh * 0.05;
            }
            segundoh = (4 * x) / 9;
            if (segundoh < terceraparte)
            {
                abogado2 = segundoh * 0.03;
            }
            else
            {
                abogado2 = segundoh * 0.05;
            }
            tercerh = (2 * x) / 9;
            if (tercerh < terceraparte)
            {
                abogado3 = tercerh * 0.03;
            }
            else
            {
                abogado3 = tercerh * 0.05;
            }

            abogadoT = abogado1 + abogado2 + abogado3;

            // Salida de los datos
            txtboxHijo1.Text = " $ " + (Math.Round(primerh, 2)).ToString();
            txtboxHijo2.Text = " $ " + (Math.Round(segundoh, 2)).ToString();
            txtboxHijo3.Text = " $ " + (Math.Round(tercerh, 2)).ToString();
            txtboxAbogado.Text = " $ " + (Math.Round(abogadoT, 2)).ToString();

        }

        private void btnLimpiar5_Click(object sender, EventArgs e)
        {
            //Se limpian todos los campos
            txtboxHerencia.Text = "";
            txtboxHijo1.Text = "";
            txtboxHijo2.Text = "";
            txtboxHijo3.Text = "";
            txtboxAbogado.Text = "";
            txtboxHerencia.Focus();
        }

        //Fin de Programación del quinto programa------------------------------------------------------------------------


        //Inicio de Programación del septimo programa--------------------------------------------
        private void home7_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        private void btnCalcular7_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular7.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular7_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular7.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnCalcular7_Click(object sender, EventArgs e)
        {
            int dia;
            dia = int.Parse(txtDiasT.Text);

            //Validacion de cantidad de dias
            if (dia < 1 || dia > 366)
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo numeros del 1 al 366", "Alerta");
                return;
            }
            else
            {
                //Programación del programa

                if (dia >= 1 && dia <= 31)
                {
                    //Enero
                    txtMesA.Text = "Enero";
                }
                else if (dia >= 32 && dia <= 60)
                {
                    //Febrero
                    txtMesA.Text = "Febrero";
                }
                else if (dia >= 61 && dia <= 91)
                {
                    //Marzo
                    txtMesA.Text = "Marzo";
                }
                else if (dia >= 92 && dia <= 121)
                {
                    //Abril
                    txtMesA.Text = "Abril";
                }
                else if (dia >= 122 && dia <= 152)
                {
                    //Mayo
                    txtMesA.Text = "Mayo";
                }
                else if (dia >= 153 && dia <= 182)
                {
                    //Junio
                    txtMesA.Text = "Junio";
                }
                else if (dia >= 183 && dia <= 213)
                {
                    //Julio
                    txtMesA.Text = "Julio";
                }
                else if (dia >= 214 && dia <= 244)
                {
                    //Agosto
                    txtMesA.Text = "Agosto";
                }
                else if (dia >= 245 && dia <= 274)
                {
                    //Septiembre
                    txtMesA.Text = "Septiembre";
                }
                else if (dia >= 275 && dia <= 305)
                {
                    //Octubre
                    txtMesA.Text = "Octubre";
                }
                else if (dia >= 306 && dia <= 335)
                {
                    //Noviembre
                    txtMesA.Text = "Noviembre";
                }
                else if (dia >= 336 && dia <= 366)
                {
                    //Diciembre
                    txtMesA.Text = "Diciembre";
                }
            }

        }

        private void btnLimpiar7_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar7.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar7_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar7.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnLimpiar7_Click(object sender, EventArgs e)
        {
            txtDiasT.Text = "";
            txtMesA.Text = "";
            txtDiasT.Focus();
        }

        private void txtDiasT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Validacion de solo teclas numericas
                MessageBox.Show("Solo se aceptan valores numericos", "Alerta");
                e.Handled = true;
                return;
            }
        }

        //Fin de programacion del quinto programa------------------------------------------------


        //Inicio de Programación del sexto programa--------------------------------------------
        private void btnCalcular6_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular6.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular6_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular6.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnLimpiar6_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar6.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar6_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar6.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnLimpiar6_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtMcm.Text = "";
            txtNumero1.Focus();
        }

        private void btnCalcular6_Click(object sender, EventArgs e)
        {
            int numero1, numero2, minimo, mcm, mcd;

            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            minimo = Math.Min(numero1, numero2); //Seleccionamos el menor
            mcm = 0; //Variable para el resultado
            for (int i = 1; i <= minimo; i++) //Ciclo para las iteraciones
            {
                //Condicion que comprobara si el numero corresponde
                //a la iteracion es el mcd

                if (numero1 % i == 0 && numero2 % i == 0)
                {
                    mcd = i; //Asignamos el mcd
                    mcm = (numero1 * numero2) / mcd; //Calculamos el mcm
                }
            }
            txtMcm.Text = mcm.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        //fin de Programación del sexto programa--------------------------------------------


        //Inicio de Programación del ultimo programa--------------------------------------------

        private void home8_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn2.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn3.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn4.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn5.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn6.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn7.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn8.Font, FontStyle.Regular);
        }

        private void btnLimpiar8_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar8.Image = global::Matemáticas_v7._0.Properties.Resources.borrador2;
        }

        private void btnLimpiar8_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar8.Image = global::Matemáticas_v7._0.Properties.Resources.borrador;
        }

        private void btnLimpiar8_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtMayor.Text = "";
            txtMedio.Text = "";
            txtMenor.Text = "";
            txtNum1.Focus();
        }

        private void btnCalcular8_MouseHover(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular8.Image = global::Matemáticas_v7._0.Properties.Resources.tiza2;
        }

        private void btnCalcular8_MouseLeave(object sender, EventArgs e)
        {
            //Mediante el evento hover se cambia la imagen de la tiza
            btnCalcular8.Image = global::Matemáticas_v7._0.Properties.Resources.tizas;
        }

        private void btnCalcular8_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = int.Parse(txtNum3.Text);

            if (num1 >= 0)
            {
                if (num1 > num2 && num1 > num3)
                {
                    txtMayor.Text = num1.ToString();
                }
                else if (num1 < num2 && num1 < num3)
                {
                    txtMenor.Text = num1.ToString();
                }
                else
                {
                    txtMedio.Text = num1.ToString();
                }
            }
            if (num2 >= 0)
            {
                if (num2 > num1 && num2 > num3)
                {
                    txtMayor.Text = num2.ToString();
                }
                else if (num2 < num1 && num2 < num3)
                {
                    txtMenor.Text = num2.ToString();
                }
                else
                {
                    txtMedio.Text = num2.ToString();
                }
            }
            if (num3 >= 0)
            {
                if (num3 > num2 && num3 > num1)
                {
                    txtMayor.Text = num3.ToString();
                }
                else if (num3 < num2 && num3 < num1)
                {
                    txtMenor.Text = num3.ToString();
                }
                else
                {
                    txtMedio.Text = num3.ToString();
                }
            }
        }


        //fin de Programación del ultimo programa--------------------------------------------

    }
}