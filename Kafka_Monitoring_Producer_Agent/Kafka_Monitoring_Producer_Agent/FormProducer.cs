using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kafka_Monitoring_Producer_Agent
{
    public partial class FormProducer : Form
    {
        #region Global Variable
        Stopwatch SW;
        Class_Kafka_Producer Producer = new Class_Kafka_Producer();

        string message;
        string FileDir;
        string SendData;
        #endregion

        public FormProducer()
        {
            InitializeComponent();
        }

        #region Function
        async void Send_Data(string Address, string Topic, string Data, int Timeout)
        {
            SW = Stopwatch.StartNew();
            await Producer.Send_Async(Address, Topic, Data, Timeout);
            SW.Stop();
            LogToTextBox("Time Elapsed : " + SW.ElapsedMilliseconds + ", Response : " + ProducerResponse.Message, 
                "Data : " + Data);
        }
        #endregion

        #region Misc
        int LogLength = 0;
        public void LogToTextBox(string DataResponse, string DataEntry)
        {
            if (LogLength > 46)
            {
                Invoke(new MethodInvoker(() =>
                {
                    RTB_Log_Response.Clear();
                    RTB_Log_Data.Clear();
                }));
                LogLength = 0;
            }
            Invoke(new MethodInvoker(() =>
            {
                RTB_Log_Response.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " + DataResponse + Environment.NewLine);
                RTB_Log_Response.ScrollToCaret();

                RTB_Log_Data.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " + DataEntry + Environment.NewLine);
                RTB_Log_Data.ScrollToCaret();
            }));

            LogLength++;
        }

        public void BrowseFileDirectory(ref string FileDirectory, ref string FileName)
        {
            var FileDialog = new OpenFileDialog
            {
                Multiselect = false
            };
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileDirectory = FileDialog.FileName;

                FileInfo FI = new FileInfo(FileDialog.FileName);
                FileName = FI.Name;
            }
        }

        public bool ReadFile(string directory, ref string data, ref string message)
        {
            try
            {
                using (StreamReader file = new StreamReader(directory))
                {
                    string buf_data = string.Empty;
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        buf_data += ln;
                        counter++;
                    }
                    file.Close();
                    data = buf_data.Replace(" ", "");
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        #endregion

        #region UI
        private void BTN_Send_Click(object sender, EventArgs e)
        {
            bool IsFileRead = true;
            if (!CHK_DataFromDirectory.Checked)
            {
                SendData = TB_Send_Data.Text;
            }
            else
            {
                IsFileRead = ReadFile(FileDir, ref SendData, ref message);
            }

            if (IsFileRead)
            {
                Send_Data(TB_Send_Address.Text, TB_Send_TopicName.Text, SendData, int.Parse(TB_Send_Timeout.Text));
            }
        }

        private void LBL_Log_ClearLogData_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                RTB_Log_Data.Clear();
            }));
        }

        private void LBL_Log_ClearLogResponse_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                RTB_Log_Response.Clear();
            }));
        }

        private void CHK_DataFromDirectory_CheckedChanged(object sender, EventArgs e)
        {
            switch (CHK_DataFromDirectory.Checked)
            {
                case true:
                    {
                        TB_Send_Data.ReadOnly = true;
                        TB_Send_Data.Text = "Double Click to Browse";
                    }
                    break;
                default:
                    {
                        TB_Send_Data.ReadOnly = false;
                        TB_Send_Data.Text = string.Empty;
                    }
                    break;
            }
        }

        private void TB_Send_Data_DoubleClick(object sender, EventArgs e)
        {
            string FileName = "";
            BrowseFileDirectory(ref FileDir, ref FileName);
            TB_Send_Data.Text = FileDir;
        }
        #endregion
    }
}
