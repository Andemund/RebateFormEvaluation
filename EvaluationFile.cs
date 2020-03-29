using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class EvaluationFile
    {
        public string Evaluation_File_Path = "";

        public void Write_Evaluation(string info)
        {
            System.IO.File.WriteAllText(Evaluation_File_Path, string.Empty);
            System.IO.StreamWriter file_write = new System.IO.StreamWriter(Evaluation_File_Path, true);
            file_write.WriteLine(info);
            file_write.Close();
        }
    }
}
