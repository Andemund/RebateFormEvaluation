namespace assignment3
{
    partial class EvaluationForm
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
            this.DataFilePathBox = new System.Windows.Forms.TextBox();
            this.DataFilePath = new System.Windows.Forms.Label();
            this.OpenDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenDataFileButton = new System.Windows.Forms.Button();
            this.EvaluationFilePath = new System.Windows.Forms.Label();
            this.EvaluationFilePathBox = new System.Windows.Forms.TextBox();
            this.EvaluationFileNameBox = new System.Windows.Forms.TextBox();
            this.EvaluationFileName = new System.Windows.Forms.Label();
            this.OpenEvaluationFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartEvaluateButton = new System.Windows.Forms.Button();
            this.EvaluationLabel = new System.Windows.Forms.Label();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.NumberOfRecordsBox = new System.Windows.Forms.TextBox();
            this.MinimumEntryTime = new System.Windows.Forms.Label();
            this.MaximumEntryTime = new System.Windows.Forms.Label();
            this.AverageEntryTime = new System.Windows.Forms.Label();
            this.MinimumIntervalTime = new System.Windows.Forms.Label();
            this.MaximumIntervalTime = new System.Windows.Forms.Label();
            this.AverageIntervalTime = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.BackspaceCount = new System.Windows.Forms.Label();
            this.MinimumEntryTimeBox = new System.Windows.Forms.TextBox();
            this.MaximumEntryTimeBox = new System.Windows.Forms.TextBox();
            this.AverageEntryTimeBox = new System.Windows.Forms.TextBox();
            this.MinimumIntervalTimeBox = new System.Windows.Forms.TextBox();
            this.MaximumIntervalTimeBox = new System.Windows.Forms.TextBox();
            this.AverageIntervalTimeBox = new System.Windows.Forms.TextBox();
            this.TotalTimeBox = new System.Windows.Forms.TextBox();
            this.BackspaceCountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataFilePathBox
            // 
            this.DataFilePathBox.Location = new System.Drawing.Point(38, 45);
            this.DataFilePathBox.Name = "DataFilePathBox";
            this.DataFilePathBox.ReadOnly = true;
            this.DataFilePathBox.Size = new System.Drawing.Size(319, 20);
            this.DataFilePathBox.TabIndex = 0;
            // 
            // DataFilePath
            // 
            this.DataFilePath.AutoSize = true;
            this.DataFilePath.Location = new System.Drawing.Point(35, 29);
            this.DataFilePath.Name = "DataFilePath";
            this.DataFilePath.Size = new System.Drawing.Size(74, 13);
            this.DataFilePath.TabIndex = 1;
            this.DataFilePath.Text = "Data File Path";
            // 
            // OpenDataFileDialog
            // 
            this.OpenDataFileDialog.FileName = "openFileDialog1";
            this.OpenDataFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDataFileDialog_FileOk);
            // 
            // OpenDataFileButton
            // 
            this.OpenDataFileButton.Location = new System.Drawing.Point(372, 45);
            this.OpenDataFileButton.Name = "OpenDataFileButton";
            this.OpenDataFileButton.Size = new System.Drawing.Size(142, 23);
            this.OpenDataFileButton.TabIndex = 2;
            this.OpenDataFileButton.Text = "ChooseDataFile";
            this.OpenDataFileButton.UseVisualStyleBackColor = true;
            this.OpenDataFileButton.Click += new System.EventHandler(this.OpenDataFileButton_Click);
            // 
            // EvaluationFilePath
            // 
            this.EvaluationFilePath.AutoSize = true;
            this.EvaluationFilePath.Location = new System.Drawing.Point(35, 145);
            this.EvaluationFilePath.Name = "EvaluationFilePath";
            this.EvaluationFilePath.Size = new System.Drawing.Size(101, 13);
            this.EvaluationFilePath.TabIndex = 3;
            this.EvaluationFilePath.Text = "Evaluation File Path";
            // 
            // EvaluationFilePathBox
            // 
            this.EvaluationFilePathBox.Location = new System.Drawing.Point(38, 161);
            this.EvaluationFilePathBox.Name = "EvaluationFilePathBox";
            this.EvaluationFilePathBox.ReadOnly = true;
            this.EvaluationFilePathBox.Size = new System.Drawing.Size(319, 20);
            this.EvaluationFilePathBox.TabIndex = 4;
            // 
            // EvaluationFileNameBox
            // 
            this.EvaluationFileNameBox.Location = new System.Drawing.Point(38, 103);
            this.EvaluationFileNameBox.Name = "EvaluationFileNameBox";
            this.EvaluationFileNameBox.Size = new System.Drawing.Size(155, 20);
            this.EvaluationFileNameBox.TabIndex = 5;
            // 
            // EvaluationFileName
            // 
            this.EvaluationFileName.AutoSize = true;
            this.EvaluationFileName.Location = new System.Drawing.Point(35, 87);
            this.EvaluationFileName.Name = "EvaluationFileName";
            this.EvaluationFileName.Size = new System.Drawing.Size(107, 13);
            this.EvaluationFileName.TabIndex = 6;
            this.EvaluationFileName.Text = "Evaluation File Name";
            // 
            // OpenEvaluationFileButton
            // 
            this.OpenEvaluationFileButton.Location = new System.Drawing.Point(372, 161);
            this.OpenEvaluationFileButton.Name = "OpenEvaluationFileButton";
            this.OpenEvaluationFileButton.Size = new System.Drawing.Size(142, 23);
            this.OpenEvaluationFileButton.TabIndex = 7;
            this.OpenEvaluationFileButton.Text = "ChooseTargetFolder";
            this.OpenEvaluationFileButton.UseVisualStyleBackColor = true;
            this.OpenEvaluationFileButton.Click += new System.EventHandler(this.OpenEvaluationFileButton_Click);
            // 
            // StartEvaluateButton
            // 
            this.StartEvaluateButton.Location = new System.Drawing.Point(554, 103);
            this.StartEvaluateButton.Name = "StartEvaluateButton";
            this.StartEvaluateButton.Size = new System.Drawing.Size(93, 23);
            this.StartEvaluateButton.TabIndex = 8;
            this.StartEvaluateButton.Text = "StartEvaluate";
            this.StartEvaluateButton.UseVisualStyleBackColor = true;
            this.StartEvaluateButton.Click += new System.EventHandler(this.StartEvaluateButton_Click);
            // 
            // EvaluationLabel
            // 
            this.EvaluationLabel.AutoSize = true;
            this.EvaluationLabel.Location = new System.Drawing.Point(35, 209);
            this.EvaluationLabel.Name = "EvaluationLabel";
            this.EvaluationLabel.Size = new System.Drawing.Size(93, 13);
            this.EvaluationLabel.TabIndex = 9;
            this.EvaluationLabel.Text = "Evaluation Result:";
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Location = new System.Drawing.Point(35, 240);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(101, 13);
            this.NumberOfRecords.TabIndex = 10;
            this.NumberOfRecords.Text = "Number Of Records";
            // 
            // NumberOfRecordsBox
            // 
            this.NumberOfRecordsBox.Location = new System.Drawing.Point(245, 237);
            this.NumberOfRecordsBox.Name = "NumberOfRecordsBox";
            this.NumberOfRecordsBox.ReadOnly = true;
            this.NumberOfRecordsBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfRecordsBox.TabIndex = 11;
            // 
            // MinimumEntryTime
            // 
            this.MinimumEntryTime.AutoSize = true;
            this.MinimumEntryTime.Location = new System.Drawing.Point(35, 267);
            this.MinimumEntryTime.Name = "MinimumEntryTime";
            this.MinimumEntryTime.Size = new System.Drawing.Size(101, 13);
            this.MinimumEntryTime.TabIndex = 12;
            this.MinimumEntryTime.Text = "Minimum Entry Time";
            // 
            // MaximumEntryTime
            // 
            this.MaximumEntryTime.AutoSize = true;
            this.MaximumEntryTime.Location = new System.Drawing.Point(35, 295);
            this.MaximumEntryTime.Name = "MaximumEntryTime";
            this.MaximumEntryTime.Size = new System.Drawing.Size(104, 13);
            this.MaximumEntryTime.TabIndex = 13;
            this.MaximumEntryTime.Text = "Maximum Entry Time";
            // 
            // AverageEntryTime
            // 
            this.AverageEntryTime.AutoSize = true;
            this.AverageEntryTime.Location = new System.Drawing.Point(35, 323);
            this.AverageEntryTime.Name = "AverageEntryTime";
            this.AverageEntryTime.Size = new System.Drawing.Size(100, 13);
            this.AverageEntryTime.TabIndex = 14;
            this.AverageEntryTime.Text = "Average Entry Time";
            // 
            // MinimumIntervalTime
            // 
            this.MinimumIntervalTime.AutoSize = true;
            this.MinimumIntervalTime.Location = new System.Drawing.Point(35, 355);
            this.MinimumIntervalTime.Name = "MinimumIntervalTime";
            this.MinimumIntervalTime.Size = new System.Drawing.Size(131, 13);
            this.MinimumIntervalTime.TabIndex = 15;
            this.MinimumIntervalTime.Text = "Minimum Inter-record Time";
            // 
            // MaximumIntervalTime
            // 
            this.MaximumIntervalTime.AutoSize = true;
            this.MaximumIntervalTime.Location = new System.Drawing.Point(35, 382);
            this.MaximumIntervalTime.Name = "MaximumIntervalTime";
            this.MaximumIntervalTime.Size = new System.Drawing.Size(134, 13);
            this.MaximumIntervalTime.TabIndex = 16;
            this.MaximumIntervalTime.Text = "Maximum Inter-record Time";
            // 
            // AverageIntervalTime
            // 
            this.AverageIntervalTime.AutoSize = true;
            this.AverageIntervalTime.Location = new System.Drawing.Point(35, 409);
            this.AverageIntervalTime.Name = "AverageIntervalTime";
            this.AverageIntervalTime.Size = new System.Drawing.Size(130, 13);
            this.AverageIntervalTime.TabIndex = 17;
            this.AverageIntervalTime.Text = "Average Inter-record Time";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(35, 440);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(57, 13);
            this.TotalTime.TabIndex = 18;
            this.TotalTime.Text = "Total Time";
            // 
            // BackspaceCount
            // 
            this.BackspaceCount.AutoSize = true;
            this.BackspaceCount.Location = new System.Drawing.Point(35, 467);
            this.BackspaceCount.Name = "BackspaceCount";
            this.BackspaceCount.Size = new System.Drawing.Size(85, 13);
            this.BackspaceCount.TabIndex = 19;
            this.BackspaceCount.Text = "Backspace ount";
            // 
            // MinimumEntryTimeBox
            // 
            this.MinimumEntryTimeBox.Location = new System.Drawing.Point(245, 267);
            this.MinimumEntryTimeBox.Name = "MinimumEntryTimeBox";
            this.MinimumEntryTimeBox.ReadOnly = true;
            this.MinimumEntryTimeBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumEntryTimeBox.TabIndex = 20;
            // 
            // MaximumEntryTimeBox
            // 
            this.MaximumEntryTimeBox.Location = new System.Drawing.Point(245, 295);
            this.MaximumEntryTimeBox.Name = "MaximumEntryTimeBox";
            this.MaximumEntryTimeBox.ReadOnly = true;
            this.MaximumEntryTimeBox.Size = new System.Drawing.Size(100, 20);
            this.MaximumEntryTimeBox.TabIndex = 21;
            // 
            // AverageEntryTimeBox
            // 
            this.AverageEntryTimeBox.Location = new System.Drawing.Point(245, 323);
            this.AverageEntryTimeBox.Name = "AverageEntryTimeBox";
            this.AverageEntryTimeBox.ReadOnly = true;
            this.AverageEntryTimeBox.Size = new System.Drawing.Size(100, 20);
            this.AverageEntryTimeBox.TabIndex = 22;
            // 
            // MinimumIntervalTimeBox
            // 
            this.MinimumIntervalTimeBox.Location = new System.Drawing.Point(245, 355);
            this.MinimumIntervalTimeBox.Name = "MinimumIntervalTimeBox";
            this.MinimumIntervalTimeBox.ReadOnly = true;
            this.MinimumIntervalTimeBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumIntervalTimeBox.TabIndex = 23;
            // 
            // MaximumIntervalTimeBox
            // 
            this.MaximumIntervalTimeBox.Location = new System.Drawing.Point(245, 382);
            this.MaximumIntervalTimeBox.Name = "MaximumIntervalTimeBox";
            this.MaximumIntervalTimeBox.ReadOnly = true;
            this.MaximumIntervalTimeBox.Size = new System.Drawing.Size(100, 20);
            this.MaximumIntervalTimeBox.TabIndex = 24;
            // 
            // AverageIntervalTimeBox
            // 
            this.AverageIntervalTimeBox.Location = new System.Drawing.Point(245, 409);
            this.AverageIntervalTimeBox.Name = "AverageIntervalTimeBox";
            this.AverageIntervalTimeBox.ReadOnly = true;
            this.AverageIntervalTimeBox.Size = new System.Drawing.Size(100, 20);
            this.AverageIntervalTimeBox.TabIndex = 25;
            // 
            // TotalTimeBox
            // 
            this.TotalTimeBox.Location = new System.Drawing.Point(245, 440);
            this.TotalTimeBox.Name = "TotalTimeBox";
            this.TotalTimeBox.ReadOnly = true;
            this.TotalTimeBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTimeBox.TabIndex = 26;
            // 
            // BackspaceCountBox
            // 
            this.BackspaceCountBox.Location = new System.Drawing.Point(245, 467);
            this.BackspaceCountBox.Name = "BackspaceCountBox";
            this.BackspaceCountBox.ReadOnly = true;
            this.BackspaceCountBox.Size = new System.Drawing.Size(100, 20);
            this.BackspaceCountBox.TabIndex = 27;
            // 
            // EvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 531);
            this.Controls.Add(this.BackspaceCountBox);
            this.Controls.Add(this.TotalTimeBox);
            this.Controls.Add(this.AverageIntervalTimeBox);
            this.Controls.Add(this.MaximumIntervalTimeBox);
            this.Controls.Add(this.MinimumIntervalTimeBox);
            this.Controls.Add(this.AverageEntryTimeBox);
            this.Controls.Add(this.MaximumEntryTimeBox);
            this.Controls.Add(this.MinimumEntryTimeBox);
            this.Controls.Add(this.BackspaceCount);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.AverageIntervalTime);
            this.Controls.Add(this.MaximumIntervalTime);
            this.Controls.Add(this.MinimumIntervalTime);
            this.Controls.Add(this.AverageEntryTime);
            this.Controls.Add(this.MaximumEntryTime);
            this.Controls.Add(this.MinimumEntryTime);
            this.Controls.Add(this.NumberOfRecordsBox);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.EvaluationLabel);
            this.Controls.Add(this.StartEvaluateButton);
            this.Controls.Add(this.OpenEvaluationFileButton);
            this.Controls.Add(this.EvaluationFileName);
            this.Controls.Add(this.EvaluationFileNameBox);
            this.Controls.Add(this.EvaluationFilePathBox);
            this.Controls.Add(this.EvaluationFilePath);
            this.Controls.Add(this.OpenDataFileButton);
            this.Controls.Add(this.DataFilePath);
            this.Controls.Add(this.DataFilePathBox);
            this.Name = "EvaluationForm";
            this.Text = "EvaluationForm";
            this.Load += new System.EventHandler(this.EvaluationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataFilePathBox;
        private System.Windows.Forms.Label DataFilePath;
        private System.Windows.Forms.OpenFileDialog OpenDataFileDialog;
        private System.Windows.Forms.Button OpenDataFileButton;
        private System.Windows.Forms.Label EvaluationFilePath;
        private System.Windows.Forms.TextBox EvaluationFilePathBox;
        private System.Windows.Forms.TextBox EvaluationFileNameBox;
        private System.Windows.Forms.Label EvaluationFileName;
        private System.Windows.Forms.Button OpenEvaluationFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button StartEvaluateButton;
        private System.Windows.Forms.Label EvaluationLabel;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.TextBox NumberOfRecordsBox;
        private System.Windows.Forms.Label MinimumEntryTime;
        private System.Windows.Forms.Label MaximumEntryTime;
        private System.Windows.Forms.Label AverageEntryTime;
        private System.Windows.Forms.Label MinimumIntervalTime;
        private System.Windows.Forms.Label MaximumIntervalTime;
        private System.Windows.Forms.Label AverageIntervalTime;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label BackspaceCount;
        private System.Windows.Forms.TextBox MinimumEntryTimeBox;
        private System.Windows.Forms.TextBox MaximumEntryTimeBox;
        private System.Windows.Forms.TextBox AverageEntryTimeBox;
        private System.Windows.Forms.TextBox MinimumIntervalTimeBox;
        private System.Windows.Forms.TextBox MaximumIntervalTimeBox;
        private System.Windows.Forms.TextBox AverageIntervalTimeBox;
        private System.Windows.Forms.TextBox TotalTimeBox;
        private System.Windows.Forms.TextBox BackspaceCountBox;
    }
}

