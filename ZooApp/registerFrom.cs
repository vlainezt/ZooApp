using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class registerFrom : Form
    {
        Zoologico zooConfig = new Zoologico();
        public registerFrom()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if(validate_userName() && validate_Email() && validate_pass() && validate_passRepeat() && validate_Roll())
            {
                string User = txtUserNameRegister.Text.Trim(),
                Password = txtUserPassword.Text.Trim(),
                RepeatPassword = txtRepeatPassword.Text.Trim(),
                Email = txtEmailUser.Text.Trim(),
                Access = txtUserRoll.Text.Trim();

                bool result = zooConfig.Register(User, Password, Email);

                string message = result ? "Usuario Registrado" : "No se pudo registrar el usuario, favor intentelo nuevamente";

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Datos incompletos, asegurese de llenar el formulario", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //if (result)
            //{
            //    MessageBox.Show("Usuario registrado");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo registrar el usuario, favor intentelo nuevamente");
            //}
        }

        private void txtUserNameRegister_Validating(object sender, CancelEventArgs e)
        {
            validate_userName();
        }

        private bool validate_userName()
        {
            if(txtUserNameRegister.Text.Trim() == "")
            {
                erPUsers.SetError(txtUserNameRegister, "Ingrese un nombre de usuario Valido");
                return false;
            }
            else
            {
                erPUsers.SetError(txtUserNameRegister, "");
                return true;
            }
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {
            validate_pass();
        }

        private bool validate_pass()
        {
            if(!Regex.IsMatch(txtUserPassword.Text.Trim(), @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"))
            {
                erPUsers.SetError(txtUserPassword, "Contrase no es segura");
                return false;
            }
            else
            {
                erPUsers.SetError(txtUserPassword, "");
                return true;
            }
        }

        private void txtRepeatPassword_Validating(object sender, CancelEventArgs e)
        {
            validate_passRepeat();
        }

        private bool validate_passRepeat()
        {
            if (txtRepeatPassword.Text.Trim() == "" || txtRepeatPassword.Text != txtUserPassword.Text)
            {
                erPUsers.SetError(txtRepeatPassword, "Contraseñas no coinciden");
                return false;
            }
            else
            {
                erPUsers.SetError(txtRepeatPassword, "");
                return true;
            }
        }

        private void txtEmailUser_Validating(object sender, CancelEventArgs e)
        {
            validate_Email();
        }

        private bool validate_Email()
        {
            if(!Regex.IsMatch(txtEmailUser.Text.Trim(), @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"))
            {
                erPUsers.SetError(txtEmailUser, "Ingrese un email que sea valido");
                return false;
            }
            else
            {
                erPUsers.SetError(txtEmailUser, "");
                return true;
            }
        }

        private void txtUserRoll_Validating(object sender, CancelEventArgs e)
        {
            validate_Roll();
        }

        private bool validate_Roll()
        {
            if (txtUserRoll.Text.Trim() == "")
            {
                erPUsers.SetError(txtUserRoll, "Asigne un rol al usuario");
                return false;
            }
            else
            {
                erPUsers.SetError(txtUserRoll, "");
                return true;
            }
        }
    }
}
