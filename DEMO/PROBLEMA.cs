using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    class PROBLEMA
    {
        public void saludar()
        {
            MessageBox.Show("HOLA");
        }
        public void verFrutas(ListBox lst)
        {
            string[] frutas = { "uva", "pera", "limon","sandia", "manzana" };
            lst.Items.Clear();
            foreach (string fruta in frutas)
            {
                lst.Items.Add(fruta);
            }
        }

    }
}
