namespace oBIXClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.colTime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTim2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHisQuery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHisURI = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(470, 16);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(35, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "label1";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(50, 13);
            this.txtURI.Name = "txtURI";
            this.txtURI.ReadOnly = true;
            this.txtURI.Size = new System.Drawing.Size(312, 20);
            this.txtURI.TabIndex = 4;
            this.txtURI.Text = "https://localhost/obix/config/publicData/Ramp/out/value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URI：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.txtURI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实时数据";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "值：";
            // 
            // timerGetData
            // 
            this.timerGetData.Enabled = true;
            this.timerGetData.Interval = 2000;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstHistory);
            this.groupBox2.Controls.Add(this.btnHisQuery);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHisURI);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 392);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史归纳查询";
            // 
            // lstHistory
            // 
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime1,
            this.colTim2,
            this.colCount,
            this.colMin,
            this.colMax,
            this.colAvg,
            this.colSum});
            this.lstHistory.HideSelection = false;
            this.lstHistory.Location = new System.Drawing.Point(9, 45);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(875, 371);
            this.lstHistory.TabIndex = 6;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            // 
            // colTime1
            // 
            this.colTime1.Text = "开始时间";
            this.colTime1.Width = 148;
            // 
            // colTim2
            // 
            this.colTim2.Text = "结束时间";
            this.colTim2.Width = 206;
            // 
            // colCount
            // 
            this.colCount.Text = "记录数";
            this.colCount.Width = 50;
            // 
            // colMin
            // 
            this.colMin.Text = "最小值";
            this.colMin.Width = 100;
            // 
            // colMax
            // 
            this.colMax.Text = "最大值";
            this.colMax.Width = 100;
            // 
            // colAvg
            // 
            this.colAvg.Text = "平均值";
            this.colAvg.Width = 100;
            // 
            // colSum
            // 
            this.colSum.Text = "累加值";
            this.colSum.Width = 119;
            // 
            // btnHisQuery
            // 
            this.btnHisQuery.Location = new System.Drawing.Point(454, 17);
            this.btnHisQuery.Name = "btnHisQuery";
            this.btnHisQuery.Size = new System.Drawing.Size(75, 23);
            this.btnHisQuery.TabIndex = 5;
            this.btnHisQuery.Text = "查询";
            this.btnHisQuery.UseVisualStyleBackColor = true;
            this.btnHisQuery.Click += new System.EventHandler(this.btnHisQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "URI：";
            // 
            // txtHisURI
            // 
            this.txtHisURI.Location = new System.Drawing.Point(50, 19);
            this.txtHisURI.Name = "txtHisURI";
            this.txtHisURI.ReadOnly = true;
            this.txtHisURI.Size = new System.Drawing.Size(366, 20);
            this.txtHisURI.TabIndex = 4;
            this.txtHisURI.Text = "https://localhost/obix/histories/obixServer/temp/~historyRollup/";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 39);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(875, 63);
            this.txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerGetData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHisURI;
        private System.Windows.Forms.Button btnHisQuery;
        private System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.ColumnHeader colTime1;
        private System.Windows.Forms.ColumnHeader colTim2;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colMin;
        private System.Windows.Forms.ColumnHeader colMax;
        private System.Windows.Forms.ColumnHeader colAvg;
        private System.Windows.Forms.ColumnHeader colSum;
        private System.Windows.Forms.TextBox txtResult;
    }
}

