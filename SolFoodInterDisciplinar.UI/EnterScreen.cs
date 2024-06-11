using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolFoodInterDisciplinar.UI
{
    public partial class EnterScreen : Form
    {
        public EnterScreen()
        {
            InitializeComponent();
        }

        private void EnterPB_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
