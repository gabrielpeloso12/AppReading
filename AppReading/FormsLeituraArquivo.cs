using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AppReading
{
    public partial class LeituraArquivo : Form
    {
        private app _FormsPrincipal;

        public LeituraArquivo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void LoadLogsGrid()
        //{
        //    DataGridView dgv = _FormsPrincipal.gridCaminho();

        //   DataTable table = new DataTable();

        //   table.Columns.Add("data", typeof(string));
        //   table.Columns.Add("hora", typeof(string));
        //   table.Columns.Add("idLog", typeof(string));
        //   table.Columns.Add("guid", typeof(string));
        //   table.Columns.Add("infComplementar_1", typeof(string));
        //   table.Columns.Add("infComplementar_2", typeof(string));
        //   table.Columns.Add("infoErro", typeof(string));
        //   table.Columns.Add("conteudo", typeof(string));

        //   // Obtém a coleção de todas as linhas do DataGridView
        //   DataGridViewRowCollection rows = dgv.Rows;

        //   // Inicializa o contador para a primeira linha
        //   int rowIndex = 0;

        //   // Loop while para percorrer todas as linhas
        //   while (rowIndex < rows.Count)
        //   {
        //       // Obtém a linha atual
        //       DataGridViewRow row = rows[rowIndex];

        //string descricao = dgv.Rows[rowIndex].Cells["DESCRICAO"].Value?.ToString() ?? string.Empty;
        //bool kubectlChecked = Convert.ToBoolean(dgv.Rows[rowIndex].Cells["KUBECTL"].Value);
        //bool grafanaChecked = Convert.ToBoolean(dgv.Rows[rowIndex].Cells["GRAFANA"].Value);

        //string sourceFilePath = _FormsPrincipal.patTextBox + "\\" + descricao;

        //string[] lines = File.ReadAllLines(sourceFilePath);

        //foreach (string line in lines)
        //{

        //    //if (kubectlChecked)
        //    //{
        //        var copyLine = line.Substring(31, 137);
        //var conteudo = line.Substring(137);
        //line.Remove(1, 30);


        //        string[] fields = copyLine.Split(' ');
        //string data = fields[0];
        //string horas = fields[1];
        //string idlog = fields[2];
        //string guid = fields[3];
        //string infcomplementar1 = fields[4];
        //string infcomplementar2 = fields[5];
        //string infoerro = fields[6];

        //table.Rows.Add(data, horas, idlog, guid, infcomplementar1, infcomplementar2, infoerro, conteudo);
            //}
       // }
    //       // Incrementa o contador para passar para a próxima linha
    //       rowIndex++;
    //   }
    //}

    //private void button1_Click(object sender, EventArgs e)
    //{
    //    LoadLogsGrid();
    //}
}
}
