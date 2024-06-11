
namespace SolFoodInterDisciplinar.UI
{
    partial class TablesScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.estoqueTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.EstoqueContainer = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.EstoqueButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TableButtton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GuiaButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SobreButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.EstoqueContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // estoqueTimer
            // 
            this.estoqueTimer.Interval = 10;
            this.estoqueTimer.Tick += new System.EventHandler(this.estoqueTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(67)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.EstoqueContainer);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.Transparent;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(245, 767);
            this.sidebar.MinimumSize = new System.Drawing.Size(85, 767);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(245, 767);
            this.sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.menu_aberto;
            this.menuButton.Location = new System.Drawing.Point(31, 39);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(40, 36);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 2;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Location = new System.Drawing.Point(3, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 49);
            this.panel2.TabIndex = 5;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Black;
            this.HomeButton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.Home_icon;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(-3, -9);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(266, 70);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.Text = "              Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // EstoqueContainer
            // 
            this.EstoqueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EstoqueContainer.Controls.Add(this.panel9);
            this.EstoqueContainer.Controls.Add(this.panel8);
            this.EstoqueContainer.Controls.Add(this.panel6);
            this.EstoqueContainer.Location = new System.Drawing.Point(3, 182);
            this.EstoqueContainer.MaximumSize = new System.Drawing.Size(242, 147);
            this.EstoqueContainer.MinimumSize = new System.Drawing.Size(242, 47);
            this.EstoqueContainer.Name = "EstoqueContainer";
            this.EstoqueContainer.Size = new System.Drawing.Size(242, 47);
            this.EstoqueContainer.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button7);
            this.panel9.Location = new System.Drawing.Point(0, 96);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(242, 49);
            this.panel9.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.gerenciar;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-3, -9);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(266, 70);
            this.button7.TabIndex = 6;
            this.button7.Text = "              Gerenciar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.EstoqueButton);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 49);
            this.panel8.TabIndex = 8;
            // 
            // EstoqueButton
            // 
            this.EstoqueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(67)))));
            this.EstoqueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EstoqueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstoqueButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstoqueButton.ForeColor = System.Drawing.Color.Black;
            this.EstoqueButton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.estoque;
            this.EstoqueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EstoqueButton.Location = new System.Drawing.Point(-3, -9);
            this.EstoqueButton.Name = "EstoqueButton";
            this.EstoqueButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.EstoqueButton.Size = new System.Drawing.Size(266, 70);
            this.EstoqueButton.TabIndex = 6;
            this.EstoqueButton.Text = "              Estoque";
            this.EstoqueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EstoqueButton.UseVisualStyleBackColor = false;
            this.EstoqueButton.Click += new System.EventHandler(this.EstoqueButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TableButtton);
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 49);
            this.panel6.TabIndex = 7;
            // 
            // TableButtton
            // 
            this.TableButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButtton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableButtton.ForeColor = System.Drawing.Color.Black;
            this.TableButtton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.tabela;
            this.TableButtton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableButtton.Location = new System.Drawing.Point(-3, -9);
            this.TableButtton.Name = "TableButtton";
            this.TableButtton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TableButtton.Size = new System.Drawing.Size(266, 70);
            this.TableButtton.TabIndex = 6;
            this.TableButtton.Text = "              Tabelas";
            this.TableButtton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableButtton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GuiaButton);
            this.panel5.Location = new System.Drawing.Point(3, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 39);
            this.panel5.TabIndex = 7;
            // 
            // GuiaButton
            // 
            this.GuiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuiaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiaButton.ForeColor = System.Drawing.Color.Black;
            this.GuiaButton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.guia;
            this.GuiaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuiaButton.Location = new System.Drawing.Point(-1, -17);
            this.GuiaButton.Name = "GuiaButton";
            this.GuiaButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.GuiaButton.Size = new System.Drawing.Size(266, 70);
            this.GuiaButton.TabIndex = 6;
            this.GuiaButton.Text = "              Guia";
            this.GuiaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuiaButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SobreButton);
            this.panel4.Location = new System.Drawing.Point(3, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 39);
            this.panel4.TabIndex = 7;
            // 
            // SobreButton
            // 
            this.SobreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SobreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SobreButton.ForeColor = System.Drawing.Color.Black;
            this.SobreButton.Image = global::SolFoodInterDisciplinar.UI.Properties.Resources.about;
            this.SobreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SobreButton.Location = new System.Drawing.Point(-1, -17);
            this.SobreButton.Name = "SobreButton";
            this.SobreButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SobreButton.Size = new System.Drawing.Size(266, 70);
            this.SobreButton.TabIndex = 6;
            this.SobreButton.Text = "              Sobre";
            this.SobreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SobreButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabelas";
            // 
            // TablesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 767);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TablesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablesScreen";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.EstoqueContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer estoqueTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel EstoqueContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button EstoqueButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button TableButtton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button GuiaButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SobreButton;
        private System.Windows.Forms.Label label2;
    }
}