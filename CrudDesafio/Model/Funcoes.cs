using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.View;
using System.Windows.Forms;

namespace CrudDesafio.Model
{
    public static class Funcoes
    {
        public static  string ObterSomenteNumeros(string valor)
        {
            var valor2 = new string((from c in valor where char.IsDigit(c) select c).ToArray());
            return valor2;

        }

        //public static void LimparTextBoxes(Control.ControlCollection controles)
        //{
        //    //Faz um laço para todos os controles passados no parâmetro
        //    foreach (Control ctrl in controles)
        //    {
        //        //Se o contorle for um TextBox...
        //        if (ctrl is TextBox)
        //        {
        //            ((TextBox)(ctrl)).Text = String.Empty;
                   

        //        }
        //    }
            
            
        //}
    }
}
