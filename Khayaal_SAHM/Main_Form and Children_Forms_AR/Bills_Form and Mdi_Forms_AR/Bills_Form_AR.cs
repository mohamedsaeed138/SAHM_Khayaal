﻿using Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print_Form;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Bills_Form_and_Mdi_Forms_AR
{
    public partial class Bills_Form_AR : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Bills_Form_AR()
        {
            Reload();
        }
        void Reload()
        {
            InitializeComponent();
            Fill_Table($"select Serial_Number, Cashier_User_Name, Total,[Total_With_Tax], Date from CR.Bills;");
            if (To_Date_Picker.Value < new DateTime(2022, 1, 1))
                To_Date_Picker.Value = DateTime.Now;
            From_Date_Picker.Value = new DateTime(2022, 1, 1);
            To_Date_Picker.Value = DateTime.Now;
        }


        void Fill_Table(string Query)
        {
            if (ConnectionState.Open == conn.State)
                conn.Close();
            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Bills_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {


                Bills_Table.Rows.Add((int)row[0], (string)row[1], (double)row[2], (double)row[3], (DateTime)row[4]);


            }
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Bills_Table.Rows.Count}";
            Sum_Without_Tax_Value_Label.Text = Formatter.Float($"{Bills_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[2].Value))}") + " $";
            Sum_Total_Value_Label.Text = Formatter.Float($"{Bills_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[3].Value))}") + " $";


        }
        void Choose_Query()
        {
            if (!(Khayaal_SAHM.Formatter.Check_Payment_Date_Range(From_Date_Picker.Value, To_Date_Picker.Value)))
            {
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                From_Date_Picker.Value = To_Date_Picker.Value;


            }
            else
            {
                string Total = Formatter.String(Total_Search_Text_Box.Text);
                string Serial = Formatter.String(Search_Serial_Number_Text_Box.Text);
                string From = Khayaal_SAHM.Formatter.Date_Formating(From_Date_Picker.Value, "From_Payment"), To = Khayaal_SAHM.Formatter.Date_Formating(To_Date_Picker.Value, "To_Payment");
                if (Total_Search_Text_Box.Text == "" && Search_Serial_Number_Text_Box.Text == "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total,[Total_With_Tax], Date FROM CR.Bills WHERE Date BETWEEN '{From}' and '{To}' ;");
                else if (Total_Search_Text_Box.Text == "" && Search_Serial_Number_Text_Box.Text != "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total,[Total_With_Tax], Date FROM CR.Bills WHERE [Serial_Number] LIKE '{Serial}%' AND Date BETWEEN '{From}' and '{To}' ;");
                else if (Total_Search_Text_Box.Text != "" && Search_Serial_Number_Text_Box.Text == "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total,[Total_With_Tax], Date FROM CR.Bills WHERE [Total] <= {Total}  AND Date BETWEEN '{From}' and '{To}' ;");
                else
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total,[Total_With_Tax], Date FROM CR.Bills WHERE [Total] <= {Total} AND [Serial_Number] LIKE '{Serial}%' AND Date BETWEEN '{From}' and '{To}' ;");
            }
        }











        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8))

            {
                e.Handled = true;
            }
        }

        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;

                Bills_Table.FirstDisplayedScrollingRowIndex = Bills_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Total_Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8))

            {
                e.Handled = true;
            }
        }

        private void Total_Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void From_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void To_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Bills_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Bills_Table.Rows[e.RowIndex];
                if (Bills_Table.Columns[e.ColumnIndex].Name == "Print")
                {
                    Print_Form Form = new Print_Form((int)row.Cells[0].Value);
                    Form.Show();
                }
                else if (Bills_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    Formatter.Check_Connection(conn);
                    SqlCommand Delete = new SqlCommand($"DELETE CR.Bills_Details Where Serial_No={(int)row.Cells[0].Value};\nDELETE CR.Bills WHERE Serial_Number={(int)row.Cells[0].Value};", conn);
                    conn.Open();
                    Delete.ExecuteNonQuery();

                    conn.Close();
                    Choose_Query();
                    MessageBox.Show("Successfully Done!");
                }
            }
            catch { }


        }
    }
}