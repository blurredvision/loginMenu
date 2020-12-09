using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Scheduler : Form
    {

        IDictionary<int, string> RoomA = new Dictionary<int, string>();
        IDictionary<int, string> RoomB = new Dictionary<int, string>();
        IDictionary<int, string> RoomC = new Dictionary<int, string>();
        IDictionary<int, string> RoomD = new Dictionary<int, string>();


        public Scheduler()
        {
            InitializeComponent();
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            ArrayList Attendee = new ArrayList();
            Attendee.Add("Niche");
            Attendee.Add("Adam");
            Attendee.Add("Nathan");
            Attendee.Add("Joe");

            ArrayList Room = new ArrayList();
            Room.Add('A');
            Room.Add('B');
            Room.Add('C');
            Room.Add('D');

            ArrayList Time = new ArrayList();
            Time.Add(1);
            Time.Add(2);
            Time.Add(3);
            Time.Add(4);
            Time.Add(5);

            foreach (var item in Attendee)
            {
                PersonBox1.Items.Add(item);
                PersonBox2.Items.Add(item);
                PersonBox3.Items.Add(item);
                PersonBox4.Items.Add(item);
                PersonBox5.Items.Add(item);
            }

            foreach (var item in Room)
            {
                RoomBox.Items.Add(item);
            }

            foreach (var item in Time)
            {
                TimeBox.Items.Add(item);
            }

        }

        private void timeChecker(char r, int t, string n)
        {
            switch (r)
            {
                case 'A':
                    if(RoomA.ContainsKey(t) == true)
                    {
                        MessageBox.Show("The slot is invalid!", "Error");
                    }
                    else
                    {
                        RoomA.Add(t, n);
                    }
                    break;
                case 'B':
                    if (RoomB.ContainsKey(t) == true)
                    {
                        MessageBox.Show("The slot is invalid!", "Error");
                    }
                    else
                    {
                        RoomB.Add(t, n);
                    }
                    break;
                case 'C':
                    if (RoomC.ContainsKey(t) == true)
                    {
                        MessageBox.Show("The slot is invalid!", "Error");
                    }
                    else
                    {
                        RoomC.Add(t, n);
                    }
                    break;
                case 'D':
                    if (RoomD.ContainsKey(t) == true)
                    {
                        MessageBox.Show("The slot is invalid!", "Error");
                    }
                    else
                    {
                        RoomD.Add(t, n);
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PersonBox1.Text == "Attendee")
            {
                PersonBox1.Text = "EMPTY SPACE"; 

            }else if(PersonBox2.Text == "Attendee")
            {
                PersonBox2.Text = "EMPTY SPACE";
            }
            else if(PersonBox3.Text == "Attendee")
            {
                PersonBox3.Text = "EMPTY SPACE";
            }
            else if (PersonBox4.Text == "Attendee")
            {
                PersonBox4.Text = "EMPTY SPACE";
            }
            else if (PersonBox5.Text == "Attendee")
            {
                PersonBox5.Text = "EMPTY SPACE";
            }

            char r = char.Parse(RoomBox.Text);
            int t = Int32.Parse(TimeBox.Text);
            string[] names = { PersonBox1.Text, PersonBox2.Text, PersonBox3.Text, PersonBox4.Text, PersonBox5.Text };

            string n = string.Join(", ", names);

            timeChecker(r, t, n);

            foreach (KeyValuePair<int, string> item in RoomA)
            {
                label2.Text = string.Format("Room A, Time = {0}, People = {1}", item.Key, item.Value);
            }

            foreach (KeyValuePair<int, string> item in RoomB)
            {
                label2.Text = string.Format("Room B, Time = {0}, People = {1}", item.Key, item.Value);
            }

            foreach (KeyValuePair<int, string> item in RoomC)
            {
                label2.Text = string.Format("Room C, Time = {0}, People = {1}", item.Key, item.Value);
            }

            foreach (KeyValuePair<int, string> item in RoomD)
            {
                label2.Text = string.Format("Room D, Time = {0}, People = {1}", item.Key, item.Value);
            }
        }
    }
}
