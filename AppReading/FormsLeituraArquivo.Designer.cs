namespace AppReading
{
    partial class LeituraArquivo
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
            panel1 = new Panel();
            button1 = new Button();
            lblPesquisa = new Label();
            textPesquisa = new TextBox();
            gridLogs = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLogs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblPesquisa);
            panel1.Controls.Add(textPesquisa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 69);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1065, 23);
            button1.Name = "button1";
            button1.Size = new Size(194, 30);
            button1.TabIndex = 2;
            button1.Text = "Carregar Log No Grid";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPesquisa.Location = new Point(121, 23);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(93, 25);
            lblPesquisa.TabIndex = 1;
            lblPesquisa.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(220, 23);
            textPesquisa.Multiline = true;
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(780, 30);
            textPesquisa.TabIndex = 0;
            textPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // gridLogs
            // 
            gridLogs.BackgroundColor = SystemColors.ButtonFace;
            gridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLogs.Dock = DockStyle.Fill;
            gridLogs.Location = new Point(0, 69);
            gridLogs.Name = "gridLogs";
            gridLogs.Size = new Size(1341, 582);
            gridLogs.TabIndex = 1;
            // 
            // LeituraArquivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1341, 651);
            Controls.Add(gridLogs);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "LeituraArquivo";
            Text = "Leitura Logs";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textPesquisa;
        private Label lblPesquisa;
        private DataGridView gridLogs;
        private Button button1;
    }
}