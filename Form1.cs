using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class EvaluationForm : Form
    {
        public string Data_File_Path { get; set; }
        public string Evaluation_File_Path { get; set; }
        public string Evaluation_Info { get; set; }
        public EvaluationForm()
        {
            InitializeComponent();
        }

        private void OpenDataFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenDataFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDataFileDialog = new OpenFileDialog();

            if (OpenDataFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string DataFilePath = OpenDataFileDialog.FileName;
                DataFilePathBox.Text = DataFilePath;
            }
        }

        private void OpenEvaluationFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenEvaluationFileDialog = new FolderBrowserDialog();

            if (OpenEvaluationFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string EvaluationFilePath = OpenEvaluationFileDialog.SelectedPath;
                EvaluationFilePathBox.Text = EvaluationFilePath;
            }
        }

        public void Generate_Evaluation_Info()
        {
            Evaluation_Info = Evaluation_Info + "Number of records: " + NumberOfRecordsBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Minimum entry time: " + MinimumEntryTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Maximum entry time: " + MaximumEntryTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Average entry time: " + AverageEntryTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Minimum inter-record time: " + MinimumIntervalTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Maximum inter-record time: " + MaximumIntervalTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Average inter-record time: " + AverageIntervalTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Total time: " + TotalTimeBox.Text + "\n";
            Evaluation_Info = Evaluation_Info + "Backspace count: " + BackspaceCountBox.Text + "\n";
        }

        private void StartEvaluateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EvaluationFilePathBox.Text))
            {
                MessageBox.Show("The data file has not been selected.");
            }
            else if (String.IsNullOrEmpty(EvaluationFileNameBox.Text))
            {
                MessageBox.Show("The evaluation file's name is invalid.");
            }
            else if (String.IsNullOrEmpty(DataFilePathBox.Text))
            {
                MessageBox.Show("The evaluation file has not been selected.");
            }
            else
            {
                Evaluation_File_Path = EvaluationFilePathBox.Text + "\\" + EvaluationFileNameBox.Text + ".txt";
                Data_File_Path = DataFilePathBox.Text;
                MessageBox.Show("The evaluate result will be wrote in: " + Evaluation_File_Path);

                //start calculate 
                ResultFile rf = new ResultFile();
                EvaluationFile ef = new EvaluationFile();
                ef.Evaluation_File_Path = Evaluation_File_Path;
                rf.Result_File_Path = Data_File_Path;
                MessageBox.Show(rf.Result_File_Path);
                rf.Get_One_Record_Data();
                rf.Get_Interval_Time();
                rf.Get_Total_Entry_Time();
                rf.Get_Average_Interval_Time();
                rf.Get_Average_Record_Time();
                rf.Get_Max_Interval_Time();
                rf.Get_Max_Record_Time();
                rf.Get_Min_Interval_Time();
                rf.Get_Min_Record_Time();
                NumberOfRecordsBox.Text = rf.Total_Record_Number.ToString();
                MinimumEntryTimeBox.Text = rf.Minimun_Recode_Time.ToString("mm':'ss");
                MaximumEntryTimeBox.Text = rf.Maximum_Recode_Time.ToString("mm':'ss");
                AverageEntryTimeBox.Text = rf.Average_Recode_Time.ToString("mm':'ss");
                MinimumIntervalTimeBox.Text = rf.Minimun_Interval_Time.ToString("mm':'ss");
                MaximumIntervalTimeBox.Text = rf.Maximum_Interval_Time.ToString("mm':'ss");
                AverageIntervalTimeBox.Text = rf.Average_Interval_Time.ToString("mm':'ss");
                TotalTimeBox.Text = rf.Total_Entering_Time.ToString("mm':'ss");
                BackspaceCountBox.Text = rf.Total_Back_Number.ToString();
                Generate_Evaluation_Info();
                ef.Write_Evaluation(Evaluation_Info);
            }
                
        }

        private void EvaluationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
