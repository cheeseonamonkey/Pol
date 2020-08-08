﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Pol
{
    public partial class Form1 : Form
    {
        

        BinaryFormatter formatter;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formatter = new BinaryFormatter();

            datePicker.Value = DateTime.Today;

            Program.LoadLists();

            cmbEmployees.Items.AddRange(Program.employeeList.ToArray());



            PopulateList();

            timePicker.Text = "9:00:00AM";

        }

        public void PopulateList()
        {

            listView.Items.Clear();

            

            if (rdbSortByTime.Checked)
            {
                SortListByTime();

            }
            else if (rdbSortByRoom.Checked)
            {
                SortListByRoom();
            }


            
            

            if(ckbShowOnlyToday.Checked)
            {
                foreach (Reservation r in Program.reservationList)
                {
                    foreach (ListViewItem lvi in listView.Items)
                    {
                        if (lvi.Tag.Equals(r.GetTag()))
                        {
                            if( !( r.ResTime.Date == DateTime.Today.Date))
                            {
                                lvi.Remove();
                            }
                        }
                    }
                }

            }

            if (ckbShowOnlyFuture.Checked)
            {
                foreach (Reservation r in Program.reservationList)
                {
                    foreach (ListViewItem lvi in listView.Items)
                    {
                        if (lvi.Tag.Equals(r.GetTag()))
                        {
                            if (r.ResTime < DateTime.Now)
                            {
                                lvi.Remove();
                            }
                        }
                    }
                }

            }


        }

        public void AddResToList(Reservation res)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = res.GetTag();
            item.SubItems.Add($"{res.ResTime.DayOfWeek}");
            item.SubItems.Add($"{res.ResTime.Month}/{res.ResTime.Day}/{res.ResTime.Year}");
            item.SubItems.Add($"{res.Room}");
            item.SubItems.Add($"{res.Guest}");
            item.SubItems.Add(string.Format("{0:h:mm tt}", res.ResTime));
            item.SubItems.Add($"{res.Employee}");
            item.SubItems.Add($"{res.Comments}");

            listView.Items.Add(item);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNum.Text.Equals(""))
                {
                    //alert here?
                    throw new Exception("Error - Must include room #");
                }
                int room = int.Parse(txtRoomNum.Text);

                
                
                string guest = txtGuest.Text;

                DateTime dateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
                
                

                string employee = cmbEmployees.Text;

                Program.reservationList.Add(new Reservation(dateTime, room, guest, employee));


                PopulateList();

                Program.SaveLists();


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            txtGuest.Clear();
            txtRoomNum.Clear();
            datePicker.Value = DateTime.Today;
            timePicker.Text = "9:00:00AM";
            cmbEmployees.Text = "";
        }


        public void SortListByRoom()
        {
            listView.Items.Clear();

            var reservationsByTime =
                from r in Program.reservationList
                orderby r.Room
                select r;

            foreach (var v in reservationsByTime)
            {
                Reservation res = v as Reservation;

                AddResToList(res);
            }
        }

        public void SortListByTime()
        {
            listView.Items.Clear();

            var reservationsByTime =
                from r in Program.reservationList
                orderby r.ResTime
                select r;

            foreach(var v in reservationsByTime)
            {
                Reservation res = v as Reservation;

                AddResToList(res);
            }

            
            
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in listView.Items)
            {
                try
                {
                    if (i.Selected)
                    {
                        foreach (Reservation r in Program.reservationList)
                        {
                            if (i.Tag.Equals(r.GetTag()))
                            {
                                
                                listView.Items.Remove(i);
                                Program.reservationList.Remove(r);
                                break;
                            }
                        }
                    }
                }catch(Exception exc)
                {
                    Console.Write($"error - {exc.Message}");
                }
            }

            Program.SaveLists();
        }

        private void rdbSortByTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSortByTime.Checked)
                SortListByTime();
        }

        private void rdbSortByRoom_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSortByRoom.Checked)
                SortListByRoom();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.SaveLists();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Program.LoadLists();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();

            employeesForm.ShowDialog();

            //will hang until closed,

            cmbEmployees.Items.Clear();
            cmbEmployees.Items.AddRange(Program.employeeList.ToArray());
            
        }

        private void ckbToday_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm();

            commentForm.ShowDialog();

            //will hang until closed,
            
            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem v in listView.Items)
            {
                if(v.Selected)
                {
                    Program.selectedListItem = v;
                }
                    
            }
        }

        private void ckbShowOnlyFuture_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
