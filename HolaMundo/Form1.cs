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
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z\d]).*$";

            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula, " +
                    "una letra minúscula, un número y un símbolo.",
                    "Contraseña inválida"
                );

                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error"
                );

                return;
            }

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
