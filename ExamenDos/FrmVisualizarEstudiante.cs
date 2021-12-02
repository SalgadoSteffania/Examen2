using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDos
{
    public partial class FrmVisualizar : Form
    {
        public List<Nota> notas { get; set; }
        public FrmVisualizar()
        {
            InitializeComponent();
        }

        private void FrmVisualizar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = notas;
        }
    }
}
