using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtiene el texto del txtBox introducido wn la contraseña
            string password = txtPassword.Text;

            // Obtiene el texto del txtBox en la confirmación de contraseña
            string confirmPassword = txtConfirmPassword.Text;

            // Expresión regular (Regex) la cual valida los requisitos de la contraseña
            // donde se tiene que:
            // (?=.*[A-Z])          Indica que se debe contener al menos una letra de la A-Z mayuscula
            // (?=.*[a-z])          Indica que se debe contener al menos una letra minúscula de la a-z
            // (?=.*\d)             Indica que se debe contener al menos un número del 0-9
            // (?=.*[^a-zA-Z\d])    Indica que se debe contener algo que no sea una letra en el rango a-z, A-Z o un numero,
            //                      por lo que se validaria si hay un simbolo 
            // .*                   Indica que se puede tener cualquier cantidad de cualquier caracter en la expresion


            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z\d]).*$";
            // Las cuatro condiciones anteriores deben cumplirse al mismo tiempo
            // donde el orden de los requisitos es indistinto por los lookaheads (?=...)
            // al buscar en cualquier posición de la cadena 
            // Finalmente, .* permite que la extension de la validacion se realize por toda la cadena
            // en cualquier cantidad de caracteres hasta el final


            // Comprueba si la contraseña cumple con la expresión regular previa
            // Si no se cumple 
            if (!Regex.IsMatch(password, pattern))
            {
                // Muestra un mensaje indicando los requisitos que debe cumplir
  
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula, " +
                    "una letra minúscula, un número y un símbolo.",
                    "Contraseña inválida"
                );

                // Regresa de la ejecución del método para no continuar
    
                return;
            }

            // Comprueba que la contraseña y su confirmación sean las mismas
            if (password != confirmPassword)
            {
                // Si las contraseñas son diferentes se muestra un mensaje de error
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error"
                );

                // Se detiene la ejecución del metodo
                return;
            }

            // Si la contraseña cumple todos los requisitos de la Regex
            // y ademas coinciden, se muestra el mensaje de validacion
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Éxito"
            );
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
