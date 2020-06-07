using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Impacta.Alunos
{
    public static class MetodosDeExtensao
    {
        //Definir o método ValidarVazio() aqui ...
        public static string ValidarVazio(this TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception(
                "Preencha o campo " + txt.AccessibleName.ToUpper());
            }
            return txt.Text;
        }
        //Definir o método ValidarCombo() aqui ...
        public static string ValidarCombo(this ComboBox cbo)
        {
            if (cbo.SelectedIndex == -1)
            {
                cbo.Focus();
                throw new Exception(
                "Selecione um item de " + cbo.AccessibleName.ToUpper());
            }
            return cbo.Text;
        }
        //Definir o método ValidarComboEnum() aqui ...
        public static Int32 ValidarComboEnum(this ComboBox cbo)
        {
            if (cbo.SelectedIndex == -1)
            {
                cbo.Focus();
                throw new Exception(
                "Selecione um item de " + cbo.AccessibleName.ToUpper());
            }
            return cbo.SelectedIndex;
        }
        //Definir o método ValidarInt16() aqui ...
        public static short ValidarInt16(this TextBox txt)
        {
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Ano deve ser numérico");
            }
        }

        //Definir o método ValidarAno() aqui ...
        public static short ValidarAno(this short ano)
        {
            if (ano < 1950 || ano > DateTime.Now.Year + 1)
            {
                throw new Exception(
                "Ano deve estar entre 1950 e " +
                (DateTime.Now.Year + 1).ToString());
            }
            return ano;
        }
        //Definir o método ValidarPlaca() aqui ...
        public static string ValidarPlaca(this string placa)
        {
            if (!Regex.IsMatch(placa, "^[a-zA-Z]{3,3}[0-9]{4,4}$"))
            {
                throw new Exception("Informe uma placa válida");
            }
            return placa;
        }
        //Definir o método LimparTela() aqui ...
        public static void LimparTela(this Form formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is ComboBox)
                {
                    (ctl as ComboBox).SelectedIndex = -1;
                }
            }
        }
    }
}
