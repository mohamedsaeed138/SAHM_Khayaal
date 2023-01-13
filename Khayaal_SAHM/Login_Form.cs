﻿using Khayaal_SAHM.Main_Form_and_Children_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
enum Cases
{
    Log_In, Change_Password, Users
}

namespace Khayaal_SAHM
{

    public partial class Login_Form : Form
    {
        readonly SqlConnection LoginCon = new SqlConnection(Connection_String.Value);

        public Login_Form()
        {
            InitializeComponent();
            Language_Combo_Box.SelectedIndex = 0;
        }








        private void Input_Process(Cases Case)
        {
            string Username, Password;
            Username = Username_Text_Box.Text;
            Password = Password_Text_Box.Text;
            try
            {
                SqlDataAdapter loginQ_adapter = new SqlDataAdapter($"Select * From CR.Users WHERE Username =N'{Username}' COLLATE SQL_Latin1_General_CP1_CS_AS AND Password=N'{Password}' COLLATE SQL_Latin1_General_CP1_CS_AS;", LoginCon);
                DataTable loginQ_DT = new DataTable();
                LoginCon.Open();
                loginQ_adapter.Fill(loginQ_DT);
                LoginCon.Close();
                if (loginQ_DT.Rows.Count > 0)
                {
                    string Type = (string)loginQ_DT.Rows[0][2];
                    bool Normal_user = Type == "Cashier كاشير" ? true : false;
                    bool Owner_or_Developer = Type == "Owner مالك" || Type == "Developer مطور" ? true : false;
                    if (Case == Cases.Log_In)
                    {
                        Thread Mainformthread;
                        SqlCommand loginCOM = new SqlCommand($"TRUNCATE TABLE CR.Users_Login_History;\nINSERT INTO CR.Users_Login_History(Name, Date)VALUES(N'{Username}', GETDATE());\nDELETE CR.Tables_Booking_Details WHERE [TO]<GETDATE();\r\n", LoginCon);
                        LoginCon.Open();
                        loginCOM.ExecuteNonQuery();
                        LoginCon.Close();
                        if (Language_Combo_Box.SelectedIndex == 0)
                            Mainformthread = new Thread(() => Application.Run(new Main_Form_AR()));
                        else
                            Mainformthread = new Thread(() => Application.Run(new Main_Form()));

                        this.Close();
                        Mainformthread.SetApartmentState(ApartmentState.STA);
                        Mainformthread.Start();
                    }
                    else if (Case == Cases.Change_Password)
                    {
                        Change_Password_Mdi_Form form = new Change_Password_Mdi_Form(Username);
                        form.MdiParent = this.Owner;

                        form.ShowDialog();
                    }
                    else
                    {

                    }


                }
                else
                {
                    MessageBox.Show("Wrong Username or Password! اسم المستخدم او الرقم السري خاطئ", "Error  خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                LoginCon.Close();
            }
        }

        private void Username_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
                e.Handled = true;
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Input_Process(Cases.Log_In);
            else if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
                e.Handled = true;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Input_Process(Cases.Log_In);
        }

        private void Change_Password_Label_Click(object sender, EventArgs e)
        {
            Input_Process(Cases.Change_Password);
        }
    }
}
