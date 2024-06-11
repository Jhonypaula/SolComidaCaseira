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
    public partial class HomeScreen : Form
    {
        bool sidebarExpand;
        bool estoqueCollapse;
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            const int step = 10; // Define o tamanho do passo para expandir/contrair

            if (sidebarExpand)
            {
                // Se a barra lateral está se contraindo
                if (sidebar.Width - step >= sidebar.MinimumSize.Width)
                {
                    sidebar.Width -= step; // Reduz a largura da barra lateral
                }
                else
                {
                    sidebar.Width = sidebar.MinimumSize.Width; // Define a largura mínima
                    sidebarExpand = false; // Marca que a barra lateral está contraída
                    sidebarTimer.Stop(); // Para o temporizador
                }
            }
            else
            {
                // Se a barra lateral está se expandindo
                if (sidebar.Width + step <= sidebar.MaximumSize.Width)
                {
                    sidebar.Width += step; // Aumenta a largura da barra lateral
                }
                else
                {
                    sidebar.Width = sidebar.MaximumSize.Width; // Define a largura máxima
                    sidebarExpand = true; // Marca que a barra lateral está expandida
                    sidebarTimer.Stop(); // Para o temporizador
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Inicia o temporizador quando o botão de menu é clicado
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void EstoqueTimer_Tick(object sender, EventArgs e)
        {
            if (estoqueCollapse)
            {
                EstoqueContainer.Height += 10; // Aumenta a altura para expandir
                if (EstoqueContainer.Height >= EstoqueContainer.MaximumSize.Height)
                {
                    estoqueCollapse = false;
                    EstoqueTimer.Stop();
                }
            }
            else
            {
                EstoqueContainer.Height -= 10; // Reduz a altura para recolher
                if (EstoqueContainer.Height <= EstoqueContainer.MinimumSize.Height)
                {
                    estoqueCollapse = true;
                    EstoqueTimer.Stop();
                }
            }
        }

        private void EstoqueButton_Click(object sender, EventArgs e)
        {
            EstoqueTimer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableButtton_Click(object sender, EventArgs e)
        {
            TablesScreen tablesScreen = new TablesScreen();
            tablesScreen.Show();
            this.Hide();
        }
    }
}
