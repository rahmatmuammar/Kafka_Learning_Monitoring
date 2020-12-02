namespace Kafka_Monitoring_Producer_Agent
{
    partial class FormProducer
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CHK_DataFromDirectory = new System.Windows.Forms.CheckBox();
            this.TB_Send_Timeout = new System.Windows.Forms.TextBox();
            this.TB_Send_TopicName = new System.Windows.Forms.TextBox();
            this.TB_Send_Address = new System.Windows.Forms.TextBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.TB_Send_Data = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_Log_ClearLogData = new System.Windows.Forms.Label();
            this.RTB_Log_Data = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_Log_ClearLogResponse = new System.Windows.Forms.Label();
            this.RTB_Log_Response = new System.Windows.Forms.RichTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CHK_DataFromDirectory);
            this.groupBox4.Controls.Add(this.TB_Send_Timeout);
            this.groupBox4.Controls.Add(this.TB_Send_TopicName);
            this.groupBox4.Controls.Add(this.TB_Send_Address);
            this.groupBox4.Controls.Add(this.BTN_Send);
            this.groupBox4.Controls.Add(this.TB_Send_Data);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 248);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producer Data";
            // 
            // CHK_DataFromDirectory
            // 
            this.CHK_DataFromDirectory.AutoSize = true;
            this.CHK_DataFromDirectory.Location = new System.Drawing.Point(319, 96);
            this.CHK_DataFromDirectory.Name = "CHK_DataFromDirectory";
            this.CHK_DataFromDirectory.Size = new System.Drawing.Size(127, 21);
            this.CHK_DataFromDirectory.TabIndex = 14;
            this.CHK_DataFromDirectory.Text = "Data From Text";
            this.CHK_DataFromDirectory.UseVisualStyleBackColor = true;
            this.CHK_DataFromDirectory.CheckedChanged += new System.EventHandler(this.CHK_DataFromDirectory_CheckedChanged);
            // 
            // TB_Send_Timeout
            // 
            this.TB_Send_Timeout.Location = new System.Drawing.Point(9, 136);
            this.TB_Send_Timeout.Name = "TB_Send_Timeout";
            this.TB_Send_Timeout.Size = new System.Drawing.Size(435, 22);
            this.TB_Send_Timeout.TabIndex = 13;
            this.TB_Send_Timeout.Text = "Timeout (milisecond)";
            // 
            // TB_Send_TopicName
            // 
            this.TB_Send_TopicName.Location = new System.Drawing.Point(9, 54);
            this.TB_Send_TopicName.Name = "TB_Send_TopicName";
            this.TB_Send_TopicName.Size = new System.Drawing.Size(435, 22);
            this.TB_Send_TopicName.TabIndex = 12;
            this.TB_Send_TopicName.Text = "Topic Name";
            // 
            // TB_Send_Address
            // 
            this.TB_Send_Address.Location = new System.Drawing.Point(9, 26);
            this.TB_Send_Address.Name = "TB_Send_Address";
            this.TB_Send_Address.Size = new System.Drawing.Size(435, 22);
            this.TB_Send_Address.TabIndex = 11;
            this.TB_Send_Address.Text = "Bootstrap Server (ex: localhost:9092)";
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(6, 164);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(438, 78);
            this.BTN_Send.TabIndex = 10;
            this.BTN_Send.Text = "Send Data to Kafka";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // TB_Send_Data
            // 
            this.TB_Send_Data.Location = new System.Drawing.Point(9, 82);
            this.TB_Send_Data.Multiline = true;
            this.TB_Send_Data.Name = "TB_Send_Data";
            this.TB_Send_Data.Size = new System.Drawing.Size(304, 48);
            this.TB_Send_Data.TabIndex = 10;
            this.TB_Send_Data.Text = "Data to Send";
            this.TB_Send_Data.DoubleClick += new System.EventHandler(this.TB_Send_Data_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LBL_Log_ClearLogData);
            this.groupBox3.Controls.Add(this.RTB_Log_Data);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 332);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log Data";
            // 
            // LBL_Log_ClearLogData
            // 
            this.LBL_Log_ClearLogData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Log_ClearLogData.AutoSize = true;
            this.LBL_Log_ClearLogData.Location = new System.Drawing.Point(859, 312);
            this.LBL_Log_ClearLogData.Name = "LBL_Log_ClearLogData";
            this.LBL_Log_ClearLogData.Size = new System.Drawing.Size(69, 17);
            this.LBL_Log_ClearLogData.TabIndex = 11;
            this.LBL_Log_ClearLogData.Text = "Clear Log";
            this.LBL_Log_ClearLogData.Click += new System.EventHandler(this.LBL_Log_ClearLogData_Click);
            // 
            // RTB_Log_Data
            // 
            this.RTB_Log_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Log_Data.Location = new System.Drawing.Point(6, 21);
            this.RTB_Log_Data.Name = "RTB_Log_Data";
            this.RTB_Log_Data.Size = new System.Drawing.Size(919, 286);
            this.RTB_Log_Data.TabIndex = 10;
            this.RTB_Log_Data.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LBL_Log_ClearLogResponse);
            this.groupBox1.Controls.Add(this.RTB_Log_Response);
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 248);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Response";
            // 
            // LBL_Log_ClearLogResponse
            // 
            this.LBL_Log_ClearLogResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Log_ClearLogResponse.AutoSize = true;
            this.LBL_Log_ClearLogResponse.Location = new System.Drawing.Point(403, 228);
            this.LBL_Log_ClearLogResponse.Name = "LBL_Log_ClearLogResponse";
            this.LBL_Log_ClearLogResponse.Size = new System.Drawing.Size(69, 17);
            this.LBL_Log_ClearLogResponse.TabIndex = 11;
            this.LBL_Log_ClearLogResponse.Text = "Clear Log";
            this.LBL_Log_ClearLogResponse.Click += new System.EventHandler(this.LBL_Log_ClearLogResponse_Click);
            // 
            // RTB_Log_Response
            // 
            this.RTB_Log_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Log_Response.Location = new System.Drawing.Point(6, 21);
            this.RTB_Log_Response.Name = "RTB_Log_Response";
            this.RTB_Log_Response.Size = new System.Drawing.Size(463, 202);
            this.RTB_Log_Response.TabIndex = 10;
            this.RTB_Log_Response.Text = "";
            // 
            // FormProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 604);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormProducer";
            this.Text = "Kafka Monitoring Producer (Agent)";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.TextBox TB_Send_Data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LBL_Log_ClearLogData;
        private System.Windows.Forms.RichTextBox RTB_Log_Data;
        private System.Windows.Forms.TextBox TB_Send_TopicName;
        private System.Windows.Forms.TextBox TB_Send_Address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Log_ClearLogResponse;
        private System.Windows.Forms.RichTextBox RTB_Log_Response;
        private System.Windows.Forms.TextBox TB_Send_Timeout;
        private System.Windows.Forms.CheckBox CHK_DataFromDirectory;
    }
}

