using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment3
{
    class ResultFile
    {
        public string Result_File_Path = "";
        
        public List<RecordInfo> Record_Info_List = new List<RecordInfo>();
        public int Total_Record_Number = 0;
        public int Total_Back_Number = 0;
        public TimeSpan Minimun_Recode_Time = new TimeSpan(11, 59, 59);
        public TimeSpan Maximum_Recode_Time = new TimeSpan(0, 0, 0);
        public TimeSpan Average_Recode_Time;
        public TimeSpan Minimun_Interval_Time = new TimeSpan(11, 59, 59);
        public TimeSpan Maximum_Interval_Time = new TimeSpan(0, 0, 0);
        public TimeSpan Average_Interval_Time;
        public TimeSpan Total_Entering_Time;

        public void Get_Interval_Time()
        {
            int i = 0;
            while(i < Record_Info_List.Count)
            {
                if (i == 0)
                {
                    TimeSpan t = new TimeSpan(0, 0, 0);
                    Record_Info_List[i].IntervalTime = t;
                    //return t;
                }
                else
                {
                    TimeSpan diff = Record_Info_List[i].StartTime - Record_Info_List[i - 1].FinishTime;
                    Record_Info_List[i].IntervalTime = diff;
                    //return diff;
                }
                i = i + 1;
            }
           
        }

        public void Get_One_Record_Data()
        {
            if (File.Exists(Result_File_Path))
            {
                StreamReader resultfile = new StreamReader(Result_File_Path);
                List<String> lines = File.ReadAllLines(Result_File_Path).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split('\t');
                    RecordInfo new_record = new RecordInfo
                    {
                        InfoID = entries[0],
                        StartTime = TimeSpan.Parse(entries[14].Split(' ')[0]),
                        FinishTime = TimeSpan.Parse(entries[15].Split(' ')[0]),
                        BackNum = entries[16]
                    };
                    Total_Back_Number = Total_Back_Number + int.Parse(new_record.BackNum);
                    new_record.TotalTime = new_record.Get_Total_Time();
                    Record_Info_List.Add(new_record);
                    Record_Info_List[Record_Info_List.Count - 1].IntervalTime = new_record.IntervalTime;
                    //Record_Info_List.Add(new_record);
                    Total_Record_Number += 1;
                }
                resultfile.Close();
            }
        }

        public void Get_Max_Record_Time()
        {
            int r = 0;
            while ( r < Record_Info_List.Count)
            {
                if (TimeSpan.Compare(Record_Info_List[r].TotalTime, Maximum_Recode_Time) != -1) 
                {
                    Maximum_Recode_Time = Record_Info_List[r].TotalTime;
                }
                r = r + 1;
            }
        }

        public void Get_Min_Record_Time()
        {
            int r = 0;
            while (r < Record_Info_List.Count)
            {
                if (TimeSpan.Compare(Record_Info_List[r].TotalTime, Minimun_Recode_Time) == -1)
                {
                    Minimun_Recode_Time = Record_Info_List[r].TotalTime;
                }
                r = r + 1;
            }
        }

        public void Get_Total_Entry_Time()
        {
            Total_Entering_Time = (Record_Info_List[Record_Info_List.Count - 1].FinishTime - Record_Info_List[0].StartTime);
        }

        public void Get_Average_Record_Time()
        {
            TimeSpan t = new TimeSpan(0, 0, 0);
            int r = 0;
            while (r < Record_Info_List.Count)
            {
                t = t + Record_Info_List[r].TotalTime;
                r = r + 1;
            }
            //TimeSpan t = Total_Entering_Time - TimeSpan.Parse("00:00:00");
            Average_Recode_Time = TimeSpan.FromMilliseconds(t.TotalMilliseconds / Total_Record_Number);
        }

        public void Get_Average_Interval_Time()
        {
            TimeSpan t = new TimeSpan(0, 0, 0);
            int r = 0;
            while (r < Record_Info_List.Count)
            {
                t = t + Record_Info_List[r].IntervalTime;
                r = r + 1;
            }
            //TimeSpan t = Total_Entering_Time - TimeSpan.Parse("00:00:00");
            Average_Interval_Time = TimeSpan.FromMilliseconds(t.TotalMilliseconds / Total_Record_Number);
        }
        public void Get_Max_Interval_Time()
        {
            int r = 0;
            while (r < Record_Info_List.Count)
            {
                if (TimeSpan.Compare(Record_Info_List[r].IntervalTime, Maximum_Interval_Time) != -1)
                {
                    Maximum_Interval_Time = Record_Info_List[r].IntervalTime;
                }
                r = r + 1;
            }
        }

        public void Get_Min_Interval_Time()
        {
            int r = 0;
            while (r < Record_Info_List.Count)
            {
                if (TimeSpan.Compare(Record_Info_List[r].IntervalTime, Minimun_Interval_Time) == -1)
                {
                    Minimun_Interval_Time = Record_Info_List[r].IntervalTime;
                }
                r = r + 1;
            }
        }

    }
}
