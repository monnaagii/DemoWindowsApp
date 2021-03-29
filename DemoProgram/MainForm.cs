using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Ok");
            } else {
                MessageBox.Show("Cancel");
            }
        }
    }
}
