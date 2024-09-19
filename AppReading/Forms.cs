using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Text.Json;

namespace AppReading
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void app_Load(object sender, EventArgs e)
        {


        }

        public void ReadFileGrafana()
        {
            string filePath = Path.Combine(textPath.Text, grid.CurrentRow.Cells["Descricao"].Value.ToString());
            string[] lines = File.ReadAllLines(filePath);


            string directoryPath = @"C:\Temp\JsonGrafana";

            // Valida se existe o diretório, caso não cria
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = "GrafanaJson.json";
            string filePathJson = Path.Combine(directoryPath, fileName);

            bool grafanaChecked = Convert.ToBoolean(grid.CurrentRow.Cells["GRAFANA"].Value);           

            List<string> processedLines = new List<string>();

            // Carregar as linhas na gridLogs
            foreach (string line in lines)
            {                               
                if (grafanaChecked)
                {
                    string processedLine = line.Substring(26);
                    processedLines.Add(processedLine);
                }
            }

            string jsonString = JsonSerializer.Serialize(processedLines, new JsonSerializerOptions { WriteIndented = true });

            // Salvar o JSON no arquivo
            File.WriteAllText(filePathJson, jsonString);
        }


        public DataGridView gridCaminho()
        {
            // Pega todos arquivos da pasta(directory)
            string[] files = Directory.GetFiles(textPath.Text);

            // Adiciona arquivos na grid
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                grid.Rows.Add(fileName);
            }
            return grid;
        }

        private void selectArq_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    textPath.Text = folderPath;
                }
            }
        }

        private void loadingGrid_Click(object sender, EventArgs e)
        {
            grid.Visible = true;
            grid.Dock = DockStyle.Fill;
            gridCaminho();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            grid.Visible = false;
            gridLogs.Visible = true;
            gridLogs.Dock = DockStyle.Fill;

            // Ler o caminho do arquivo da coluna "Descricao" da linha selecionada na grid
            string filePath = Path.Combine(textPath.Text, grid.CurrentRow.Cells["Descricao"].Value.ToString());

            DataTable table = new DataTable();

            //gridLogs.Doub = true;
            gridLogs.VirtualMode = true;
            gridLogs.AutoGenerateColumns = false;
            gridLogs.RowHeadersVisible = false;
            gridLogs.EditMode = DataGridViewEditMode.EditOnKeystroke;

            table.Columns.Add("data", typeof(string));
            table.Columns.Add("hora", typeof(string));
            table.Columns.Add("idLog", typeof(string));
            table.Columns.Add("guid", typeof(string));
            table.Columns.Add("infComplementar_1", typeof(string));
            table.Columns.Add("infComplementar_2", typeof(string));
            table.Columns.Add("infoErro", typeof(string));
            table.Columns.Add("conteudo", typeof(string));

            
            table.BeginLoadData();

            // Ler o conteúdo do arquivo linha a linha
            string[] lines = File.ReadAllLines(filePath);

            bool kubectlChecked = Convert.ToBoolean(grid.CurrentRow.Cells["KUBECTL"].Value);
            bool grafanaChecked = Convert.ToBoolean(grid.CurrentRow.Cells["GRAFANA"].Value);

            // Carregar as linhas na gridLogs
            foreach (string line in lines)
            {

                string linha = line.Substring(0, 30);
                char obterUltimoCaracter = linha[linha.Length - 1];

                if (kubectlChecked && obterUltimoCaracter == 'Z')
                {
                    var copyLine = line.Substring(31, 137);
                    line.Remove(0, 30);
                    var conteudo = line.Substring(138);

                    string[] fields = copyLine.Split(' ');
                    string data = fields[0];
                    string horas = fields[1];
                    string idlog = fields[2];
                    string guid = fields[3];
                    string infcomplementar1 = fields[4];
                    string infcomplementar2 = fields[5];
                    string infoerro = fields[6];

                    table.Rows.Add(data, horas, idlog, guid, infcomplementar1, infcomplementar2, infoerro, conteudo);
                }
                else
                {
                    ReadFileGrafana();
                    //var copyLine = line.Substring(0);
                    //string[] fields = copyLine.Split(' ');
                    //string data = fields[0];
                    //string horas = fields[1];
                    //string idlog = fields[2];
                    //string guid = fields[3];
                    //string infcomplementar1 = fields[4];
                    //string infcomplementar2 = fields[5];
                    //string infoerro = fields[6];
                    //var conteudo = line.Substring(138);

                    //table.Rows.Add(data, horas, idlog, guid, infcomplementar1, infcomplementar2, infoerro, conteudo);
                }
            }
            gridLogs.DataSource = table;

            table.EndLoadData();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["kubectl"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == null || (bool)cell.Value == false)
                {
                    cell.Value = true;
                }
                else
                {
                    cell.Value = false;
                }
            }

            if (e.ColumnIndex == grid.Columns["grafana"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == null || (bool)cell.Value == false)
                {
                    cell.Value = true;
                }
                else
                {
                    cell.Value = false;
                }
            }
        }
    }
}
