using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABU_Apoia
{
    public partial class cadastro : Form
    {
        public cadastro(string texto)
        {
            InitializeComponent();
            textoTeste.Text = texto;
        }
    }
}
