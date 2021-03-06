﻿namespace Pol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.colCheckbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGuest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblUnavailable = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckbShowOnlyToday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSortByRoom = new System.Windows.Forms.RadioButton();
            this.rdbSortByTime = new System.Windows.Forms.RadioButton();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.ckbShowOnlyFuture = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheckbox,
            this.colWeekday,
            this.colDate,
            this.colRoomNum,
            this.colGuest,
            this.colHour,
            this.colEmployee,
            this.colComments});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 127);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(901, 332);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // colCheckbox
            // 
            this.colCheckbox.Text = "";
            this.colCheckbox.Width = 25;
            // 
            // colWeekday
            // 
            this.colWeekday.Text = "";
            this.colWeekday.Width = 102;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 95;
            // 
            // colRoomNum
            // 
            this.colRoomNum.Text = "Room #";
            this.colRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRoomNum.Width = 70;
            // 
            // colGuest
            // 
            this.colGuest.Text = "Guest";
            this.colGuest.Width = 102;
            // 
            // colHour
            // 
            this.colHour.Text = "Hour";
            this.colHour.Width = 80;
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Employee";
            this.colEmployee.Width = 95;
            // 
            // colComments
            // 
            this.colComments.Text = "Comments";
            this.colComments.Width = 325;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEmployees);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.txtRoomNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGuest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAvailable);
            this.panel1.Controls.Add(this.lblUnavailable);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 99);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(224, 10);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(52, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tomorrow";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(172, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Today";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(294, 53);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(100, 24);
            this.cmbEmployees.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(422, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(175, 25);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(102, 23);
            this.datePicker.TabIndex = 4;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(175, 53);
            this.timePicker.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(102, 23);
            this.timePicker.TabIndex = 5;
            this.timePicker.Value = new System.DateTime(2020, 7, 18, 18, 0, 0, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNum.Location = new System.Drawing.Point(63, 25);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(44, 23);
            this.txtRoomNum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guest";
            // 
            // txtGuest
            // 
            this.txtGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuest.Location = new System.Drawing.Point(63, 54);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(100, 23);
            this.txtGuest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room #";
            // 
            // lblAvailable
            // 
            this.lblAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(205, 78);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(65, 12);
            this.lblAvailable.TabIndex = 14;
            this.lblAvailable.Text = "Available";
            this.lblAvailable.Visible = false;
            // 
            // lblUnavailable
            // 
            this.lblUnavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnavailable.Location = new System.Drawing.Point(205, 79);
            this.lblUnavailable.Name = "lblUnavailable";
            this.lblUnavailable.Size = new System.Drawing.Size(65, 12);
            this.lblUnavailable.TabIndex = 15;
            this.lblUnavailable.Text = "Unavailable";
            this.lblUnavailable.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckbShowOnlyToday
            // 
            this.ckbShowOnlyToday.AutoSize = true;
            this.ckbShowOnlyToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowOnlyToday.Location = new System.Drawing.Point(551, 86);
            this.ckbShowOnlyToday.Name = "ckbShowOnlyToday";
            this.ckbShowOnlyToday.Size = new System.Drawing.Size(136, 22);
            this.ckbShowOnlyToday.TabIndex = 3;
            this.ckbShowOnlyToday.Text = "Show only today";
            this.ckbShowOnlyToday.UseVisualStyleBackColor = true;
            this.ckbShowOnlyToday.CheckedChanged += new System.EventHandler(this.ckbToday_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSortByRoom);
            this.groupBox1.Controls.Add(this.rdbSortByTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            this.groupBox1.Visible = false;
            // 
            // rdbSortByRoom
            // 
            this.rdbSortByRoom.AutoSize = true;
            this.rdbSortByRoom.Enabled = false;
            this.rdbSortByRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSortByRoom.Location = new System.Drawing.Point(6, 42);
            this.rdbSortByRoom.Name = "rdbSortByRoom";
            this.rdbSortByRoom.Size = new System.Drawing.Size(94, 19);
            this.rdbSortByRoom.TabIndex = 1;
            this.rdbSortByRoom.Text = "Sort by room";
            this.rdbSortByRoom.UseVisualStyleBackColor = true;
            this.rdbSortByRoom.Visible = false;
            this.rdbSortByRoom.CheckedChanged += new System.EventHandler(this.rdbSortByRoom_CheckedChanged);
            // 
            // rdbSortByTime
            // 
            this.rdbSortByTime.AutoSize = true;
            this.rdbSortByTime.Checked = true;
            this.rdbSortByTime.Enabled = false;
            this.rdbSortByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSortByTime.Location = new System.Drawing.Point(6, 17);
            this.rdbSortByTime.Name = "rdbSortByTime";
            this.rdbSortByTime.Size = new System.Drawing.Size(101, 21);
            this.rdbSortByTime.TabIndex = 0;
            this.rdbSortByTime.TabStop = true;
            this.rdbSortByTime.Text = "Sort by time";
            this.rdbSortByTime.UseVisualStyleBackColor = true;
            this.rdbSortByTime.Visible = false;
            this.rdbSortByTime.CheckedChanged += new System.EventHandler(this.rdbSortByTime_CheckedChanged);
            // 
            // btnComment
            // 
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(826, 468);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(87, 35);
            this.btnComment.TabIndex = 5;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "manual save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(80, 526);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 37);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "manual load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(816, 526);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(97, 37);
            this.btnManage.TabIndex = 8;
            this.btnManage.Text = "manage employees";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // ckbShowOnlyFuture
            // 
            this.ckbShowOnlyFuture.AutoSize = true;
            this.ckbShowOnlyFuture.Checked = true;
            this.ckbShowOnlyFuture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowOnlyFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowOnlyFuture.Location = new System.Drawing.Point(693, 87);
            this.ckbShowOnlyFuture.Name = "ckbShowOnlyFuture";
            this.ckbShowOnlyFuture.Size = new System.Drawing.Size(137, 22);
            this.ckbShowOnlyFuture.TabIndex = 10;
            this.ckbShowOnlyFuture.Text = "Show only future";
            this.ckbShowOnlyFuture.UseVisualStyleBackColor = true;
            this.ckbShowOnlyFuture.CheckedChanged += new System.EventHandler(this.ckbShowOnlyFuture_CheckedChanged);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(739, 468);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(81, 35);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(109, 468);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(81, 41);
            this.btnMulti.TabIndex = 12;
            this.btnMulti.Text = "Add many days";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(17, 111);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(57, 13);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Showing 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(917, 567);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.ckbShowOnlyFuture);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbShowOnlyToday);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 606);
            this.MinimumSize = new System.Drawing.Size(933, 606);
            this.Name = "Form1";
            this.Text = "Pool Reservations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colRoomNum;
        private System.Windows.Forms.ColumnHeader colGuest;
        private System.Windows.Forms.ColumnHeader colHour;
        private System.Windows.Forms.ColumnHeader colWeekday;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ColumnHeader colComments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader colCheckbox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckbShowOnlyToday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSortByRoom;
        private System.Windows.Forms.RadioButton rdbSortByTime;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.CheckBox ckbShowOnlyFuture;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblUnavailable;
    }
}

