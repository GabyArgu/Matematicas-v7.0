using System.IO;

namespace Matemáticas_v7._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Botones para cambiar de pantalla en el panel------------------------------------------------------------------------

        private void btn1_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 1 de tabControl
            tabControl1.SelectedIndex = 1;
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 8;

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

        private void btn2_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 2 de tabControl
            tabControl1.SelectedIndex = 2;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 3 de tabControl
            tabControl1.SelectedIndex = 3;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 4 de tabControl
            tabControl1.SelectedIndex = 4;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 5 de tabControl
            tabControl1.SelectedIndex = 5;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 6 de tabControl
            tabControl1.SelectedIndex = 6;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 7 de tabControl
            tabControl1.SelectedIndex = 7;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 8 de tabControl
            tabControl1.SelectedIndex = 9;

            //Poner en regular a todos los demas boton
            btn1.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Bold);
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
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);

        }

        //Fin de Programación del primero programa-----------------------------------------------------------------------------

        //Inicio de Programación del segundo programa-------------------------------------------------------------------------

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {

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
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        //Fin de Programación del segundo programa-----------------------------------------------------------------------------


        //Inicio de Programación del tercer programa-----------------------------------------------------------------------------
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
            txtA.Focus();
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
            btn2.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn5.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn6.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn7.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
            btn8.Font = new System.Drawing.Font(btn1.Font, FontStyle.Regular);
        }

        //Fin de Programación del tercer programa-----------------------------------------------------------------------------

        //Inicio de Programación del quinto programa-----------------------------------------------------------------------------

        private void home6_Click(object sender, EventArgs e)
        {
            // Se muestra el panel 0 de tabControl
            tabControl1.SelectedIndex = 0;

            // Poner en negritar el boton seleccionado


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


        //Fin de Programación del quinto programa-----------------------------------------------------------------------------
    }
}