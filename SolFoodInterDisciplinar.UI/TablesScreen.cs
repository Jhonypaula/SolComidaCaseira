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
    public partial class TablesScreen : Form
    {
        bool sidebarExpand;
        bool estoqueCollapse;

        public TablesScreen()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void estoqueTimer_Tick(object sender, EventArgs e)
        {
            if (estoqueCollapse)
            {
                EstoqueContainer.Height += 10; // Aumenta a altura para expandir
                if (EstoqueContainer.Height >= EstoqueContainer.MaximumSize.Height)
                {
                    estoqueCollapse = false;
                    estoqueTimer.Stop();
                }
            }
            else
            {
                EstoqueContainer.Height -= 10; // Reduz a altura para recolher
                if (EstoqueContainer.Height <= EstoqueContainer.MinimumSize.Height)
                {
                    estoqueCollapse = true;
                    estoqueTimer.Stop();
                }
            }
        }

        private void EstoqueButton_Click(object sender, EventArgs e)
        {
            estoqueTimer.Start();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}