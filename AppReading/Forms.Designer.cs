namespace AppReading
{
    partial class app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelTop = new Panel();
            textBox1 = new TextBox();
            lblPesq = new Label();
            btnLogs = new Button();
            loadingGrid = new Button();
            selectArq = new Button();
            textPath = new TextBox();
            panelGrid = new Panel();
            gridLogs = new DataGridView();
            Teste = new DataGridViewTextBoxColumn();
            grid = new DataGridView();
            openDlg = new OpenFileDialog();
            DESCRICAO = new DataGridViewTextBoxColumn();
            KUBECTL = new DataGridViewCheckBoxColumn();
            GRAFANA = new DataGridViewCheckBoxColumn();
            panelTop.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1480, 0);
            panel1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.Highlight;
            panelTop.Controls.Add(textBox1);
            panelTop.Controls.Add(lblPesq);
            panelTop.Controls.Add(btnLogs);
            panelTop.Controls.Add(loadingGrid);
            panelTop.Controls.Add(selectArq);
            panelTop.Controls.Add(textPath);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1480, 63);
            panelTop.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(965, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 23);
            textBox1.TabIndex = 9;
            // 
            // lblPesq
            // 
            lblPesq.AutoSize = true;
            lblPesq.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPesq.Location = new Point(881, 17);
            lblPesq.Name = "lblPesq";
            lblPesq.Size = new Size(78, 20);
            lblPesq.TabIndex = 8;
            lblPesq.Text = "Pesquisa: ";
            // 
            // btnLogs
            // 
            btnLogs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogs.Location = new Point(719, 14);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(89, 29);
            btnLogs.TabIndex = 7;
            btnLogs.Text = "Abrir logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // loadingGrid
            // 
            loadingGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loadingGrid.Location = new Point(596, 14);
            loadingGrid.Name = "loadingGrid";
            loadingGrid.Size = new Size(117, 29);
            loadingGrid.TabIndex = 6;
            loadingGrid.Text = "Carregar na Grid";
            loadingGrid.UseVisualStyleBackColor = true;
            loadingGrid.Click += loadingGrid_Click;
            // 
            // selectArq
            // 
            selectArq.FlatAppearance.BorderColor = Color.Blue;
            selectArq.FlatAppearance.BorderSize = 0;
            selectArq.FlatStyle = FlatStyle.System;
            selectArq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectArq.ForeColor = SystemColors.ButtonFace;
            selectArq.Location = new Point(39, 14);
            selectArq.Name = "selectArq";
            selectArq.Size = new Size(114, 29);
            selectArq.TabIndex = 2;
            selectArq.Text = "Seleciona a pasta";
            selectArq.UseVisualStyleBackColor = true;
            selectArq.Click += selectArq_Click;
            // 
            // textPath
            // 
            textPath.Location = new Point(163, 17);
            textPath.Name = "textPath";
            textPath.Size = new Size(427, 23);
            textPath.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = SystemColors.ButtonFace;
            panelGrid.Controls.Add(gridLogs);
            panelGrid.Controls.Add(grid);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 63);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1480, 628);
            panelGrid.TabIndex = 2;
            // 
            // gridLogs
            // 
            gridLogs.AllowUserToOrderColumns = true;
            gridLogs.BackgroundColor = SystemColors.ButtonHighlight;
            gridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLogs.Columns.AddRange(new DataGridViewColumn[] { Teste });
            gridLogs.GridColor = SystemColors.ButtonHighlight;
            gridLogs.Location = new Point(733, 24);
            gridLogs.Name = "gridLogs";
            gridLogs.Size = new Size(699, 460);
            gridLogs.TabIndex = 1;
            gridLogs.Visible = false;
            // 
            // Teste
            // 
            Teste.HeaderText = "Teste";
            Teste.Name = "Teste";
            // 
            // grid
            // 
            grid.BackgroundColor = SystemColors.ButtonFace;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.Columns.AddRange(new DataGridViewColumn[] { DESCRICAO, KUBECTL, GRAFANA });
            grid.Location = new Point(39, 24);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.Size = new Size(636, 460);
            grid.TabIndex = 0;
            grid.Visible = false;
            grid.CellContentClick += grid_CellContentClick;
            // 
            // openDlg
            // 
            openDlg.FileName = "openDlg";
            // 
            // DESCRICAO
            // 
            DESCRICAO.HeaderText = "Descricao";
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.ReadOnly = true;
            DESCRICAO.Resizable = DataGridViewTriState.True;
            // 
            // KUBECTL
            // 
            KUBECTL.HeaderText = "Kubectl";
            KUBECTL.Name = "KUBECTL";
            KUBECTL.ReadOnly = true;
            KUBECTL.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // GRAFANA
            // 
            GRAFANA.HeaderText = "Grafana";
            GRAFANA.Name = "GRAFANA";
            GRAFANA.ReadOnly = true;
            // 
            // app
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1480, 691);
            Controls.Add(panelGrid);
            Controls.Add(panelTop);
            Controls.Add(panel1);
            Name = "app";
            Text = "AppReading";
            WindowState = FormWindowState.Maximized;
            Load += app_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelTop;
        private Panel panelGrid;
        private DataGridView grid;
        private Button selectArq;
        private TextBox textPath;
        private ContextMenuStrip contextMenuStrip1;
        private Button loadingGrid;
        private OpenFileDialog openDlg;
        private Button btnLogs;
        private DataGridView gridLogs;
        private DataGridViewTextBoxColumn Teste;
        private TextBox textBox1;
        private Label lblPesq;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewCheckBoxColumn KUBECTL;
        private DataGridViewCheckBoxColumn GRAFANA;
    }
}
