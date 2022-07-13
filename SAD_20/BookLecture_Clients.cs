using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class BookLecture_Clients : Form
    {

        public BookLecture_Clients(int value)
        {
            InitializeComponent();
            IDLecture.Text = value.ToString();
            //Console.WriteLine(ID);
        }

        private void BookLecture_Clients_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Lecture L = Program.seekLecture(Convert.ToInt32(IDLecture.Text));
            BookingEmail_textBox.Text = Program.user.get_email();
            txtDuration_Update_Lectures.Text = L.Get_duration().ToString();
            comboBoxType.Text = L.Get_lectureType().ToString();
            name_lbl.Text = L.Get_name().ToString();
            description_txtBox.Text = L.Get_descripton().ToString();
            txtPrice.Text = L.Get_price().ToString();
            DatePicker.Text = L.Get_startDate().ToString();
            txtCapacity_Update_Lectures.Text = L.Get_capacity().ToString();
            txtLocation_Update_Lectures.Text = L.Get_location().ToString();
            txtSeats_Update_Lectures.Text = L.Get_seatsLeft().ToString();
            txtEmail_Update_Lectures.Text = L.Get_email();
            
        }

        private void Book_btn_Click(object sender, EventArgs e)
        {
            if (Program.seekBooking(Program.seekLecture(Convert.ToInt32(IDLecture.Text)).Get_activityID(), (Program.seekClient(BookingEmail_textBox.Text))) != null)
            {
                MessageBox.Show("You are already registered for this lecture");
            }
            else
            {
                Lecture l = Program.seekLecture(Convert.ToInt32(IDLecture.Text));
                Client c = Program.seekClient(BookingEmail_textBox.Text);
                var result = MessageBox.Show("Are you sure you want to make this booking?", "Confirm booking",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Booking confirmed!");
                    //update lecture seats left
                    l.updateSeats(-1);
                    //update bookings
                    addBooking(c, l);
                    closeForm();
                }
            }
        }

        private Boolean checkClient(string email)
        {
            if (Program.seekClient(email) == null)
            {
                return false;
            }
            return true;
        }

        private void addBooking(Client c, Lecture l)
        {
            Double price = l.Get_price() * (1 - c.get_discount());
            DateTime dt = DateTime.Now;
            BookingStatus status = (BookingStatus)Enum.Parse(typeof(BookingStatus), "Procces");
            int id = l.Get_activityID();
            string email = c.get_email();
            Random rnd = new Random();
            Booking b = new Booking(rnd.Next(), price, dt, status, id, email);
            b.create_booking();
            Program.Bookings.Add(b);
            c.addLecture();
        }

        private void closeForm()
        {
            ViewLectures_Client c = new ViewLectures_Client();
            this.Close();
            c.Show();
        }

        private void Cancel_Lecture_BTN_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void CancelBooking_btn_Click(object sender, EventArgs e)
        {
            Lecture l = Program.seekLecture((Convert.ToInt32(IDLecture.Text)));
            Client c = Program.seekClient(BookingEmail_textBox.Text);
            if (Program.seekBooking(l.Get_activityID(), c) == null)
            {
                MessageBox.Show("Registration is not found");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to cancel this booking?" , "Confirm Cancelation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Booking canceled");
                    //update lecture seats left
                    l.updateSeats(1);
                    //update bookings
                    deleteBooking(l, c);
                    closeForm();
                }
            }
        }

        private void deleteBooking(Lecture l, Client c)
        {
            Booking b = Program.seekBooking(l.Get_activityID(), c);
            c.removeLecture();
            b.delete_booking();
           // c.removeLecture();
        }
    }
}
 
