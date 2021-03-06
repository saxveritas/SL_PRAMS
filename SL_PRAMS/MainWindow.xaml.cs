﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using Devart.Data.MySql;
using System.Globalization;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Diagnostics;

namespace _01DUMMY_SL_PRAMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    //public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox tb = (System.Windows.Controls.TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void MainWindow_OnLoad(object sender, RoutedEventArgs e)
        {
            First_name_textbox.Focus();
            First_name_textbox.SelectAll();
        }  

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private string mandatorysource;
        private string requireauthorizations;
        private string basesupply;
        private string tco;
        private string cipswoms;
        private string serviceagreement;
        private string fairandreasonable;
        private string approvedsource;


        private async void Submit_Button_Click(object sender, RoutedEventArgs e)
        {

            if (check01.IsChecked)
            {
                mandatorysource = "YES";
            }
            else
            {
                mandatorysource = "NO";
            }

            if (check02.IsChecked)
            {
                requireauthorizations = "YES";
            }
            else
            {
                requireauthorizations = "NO";

            }

            if (check03.IsChecked)
            {
                basesupply = "YES";
            }
            else
            {
                basesupply = "NO";

            }

            if (check04.IsChecked)
            {
                tco = "YES";
            }
            else
            {
                tco = "NO";

            }

            if (check05.IsChecked)
            {
                cipswoms = "YES";
            }
            else
            {
                cipswoms = "NO";

            }

            if (check06.IsChecked)
            {
                serviceagreement = "YES";
            }
            else
            {
                serviceagreement = "NO";

            }

            if (check07.IsChecked)
            {
                fairandreasonable = "YES";
            }
            else
            {
                fairandreasonable = "NO";

            }

            if (check08.IsChecked)
            {
                approvedsource = "YES";
            }
            else
            {
                approvedsource = "NO";
            }
            
            string constring = "host=192.168.182.128;port=3306;User Id=SL_PRAMS_USER;Password=SLPRAMSpassword2018";
            string Command = "INSERT INTO slprams.impact(firstname,middlename,lastname,officesymbol,squadron,date,mandatorysource,requireauthorizations,basesupply,tco,cipswoms,serviceagreement,fairandreasonable,approvedsource,description,justification,vendor1,contract1,url1,cost1,vendor2,contract2,url2,cost2,vendor3,contract3,url3,cost3)VALUES('" + First_name_textbox.Text + "','" + MI_textbox.Text + "','" + LAST_NAME_textbox.Text + "','" + OFFICE_SYMBOL_textbox.Text + "','" + SQUADRON_textbox.Text + "','" + date_selector.Text + "','" + mandatorysource + "','" + requireauthorizations + "','" + basesupply + "','" + tco + "','" + cipswoms + "','" + serviceagreement + "','" + fairandreasonable + "','" + approvedsource + "','" + this.IMPACT_01.Text + "','" + this.IMPACT_03.Text + "','" + this.IMPACT_05.Text + "','" + this.IMPACT_07.Text + "','" + this.IMPACT_09.Text + "','" + this.IMPACT_11.Text + "','" + this.IMPACT_13.Text + "','" + this.IMPACT_15.Text + "','" + this.IMPACT_17.Text + "','" + this.IMPACT_19.Text + "','" + this.IMPACT_21.Text + "','" + this.IMPACT_23.Text + "','" + this.IMPACT_25.Text + "','" + this.IMPACT_27.Text + "')";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Command, conDataBase);

            MySqlDataReader myReader;

            try
            {
                if (String.IsNullOrWhiteSpace(date_selector.Text) ||
                    String.IsNullOrWhiteSpace(First_name_textbox.Text) ||
                    String.IsNullOrWhiteSpace(MI_textbox.Text) ||
                    String.IsNullOrWhiteSpace(LAST_NAME_textbox.Text) ||
                    String.IsNullOrWhiteSpace(OFFICE_SYMBOL_textbox.Text) ||
                    String.IsNullOrWhiteSpace(SQUADRON_textbox.Text))
                {
                    await this.ShowMessageAsync("You've missed mandatory fields on the main tab",
                        "First name: " + First_name_textbox.Text + "\n" +
                        "MI: " + MI_textbox.Text + "\n" +
                        "Last name: " + LAST_NAME_textbox.Text + "\n" +
                        "Office symbol: " + OFFICE_SYMBOL_textbox.Text + "\n" +
                        "Squadron: " + SQUADRON_textbox.Text + "\n" +
                        "Date: " + date_selector.Text + "\n" +
                        "Please populate all user information fields", MessageDialogStyle.Affirmative);
                    /*System.Windows.Forms.MessageBox.Show("You've missed mandatory fields on the main tab" + "\n" +
                        "First name: " + First_name_textbox.Text + "\n" +
                        "MI: " + MI_textbox.Text + "\n" +
                        "Last name: " + LAST_NAME_textbox.Text + "\n" +
                        "Office symbol: " + OFFICE_SYMBOL_textbox.Text + "\n" +
                        "Squadron: " + SQUADRON_textbox.Text + "\n" +
                        "Date: " + date_selector.Text, "Please populate all user information fields", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }

                if (!String.IsNullOrWhiteSpace(date_selector.Text) || !String.IsNullOrWhiteSpace(First_name_textbox.Text) || !String.IsNullOrWhiteSpace(MI_textbox.Text) || !String.IsNullOrWhiteSpace(LAST_NAME_textbox.Text) || !String.IsNullOrWhiteSpace(OFFICE_SYMBOL_textbox.Text) || !String.IsNullOrWhiteSpace(SQUADRON_textbox.Text))
                {
                    //for debugging
                    //System.Windows.MessageBox.Show(approvedsource);
                    if (!String.IsNullOrWhiteSpace(date_selector.Text) &&
                        !String.IsNullOrWhiteSpace(First_name_textbox.Text) &&
                        !String.IsNullOrWhiteSpace(MI_textbox.Text) &&
                        !String.IsNullOrWhiteSpace(LAST_NAME_textbox.Text) &&
                        !String.IsNullOrWhiteSpace(OFFICE_SYMBOL_textbox.Text) &&
                        !String.IsNullOrWhiteSpace(SQUADRON_textbox.Text))
                    {

                        if (approvedsource == "NO")
                        {
                            if (!String.IsNullOrWhiteSpace(IMPACT_01.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_03.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_05.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_07.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_09.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_11.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_13.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_15.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_17.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_19.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_21.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_23.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_25.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_27.Text))
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();
                                await this.ShowMessageAsync("Purchase Request Submitted", "Your request has been successfully forwarded through SL PRAMS." + "\n" + "Your AO will recieve and email notification of the new request" + "\n" + "You may close the application or submit another request.");
                                //System.Windows.MessageBox.Show("Purchase Request Submitted!");
                                while (myReader.Read())
                                {
                                }
                            }
                            if (String.IsNullOrWhiteSpace(IMPACT_05.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_07.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_09.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_11.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_13.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_15.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_17.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_19.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_21.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_23.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_25.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_27.Text))
                            {
                                await this.ShowMessageAsync("Please check the form and resubmit.", "You must supply all information for 3 vendors if products aren't from an approved source." +
                                    "\n" + "\n" +
                                    "You must also include a Description of the purchase being requested and a justification.");
                                /*System.Windows.MessageBox.Show("You must supply all information for 3 vendors if products aren't from an approved source." +
                                    "\n" + "\n" +
                                    "You must also include a Description of the purchase being requested and a justification.");*/
                            }

                        }
                        //for debugging
                        //System.Windows.MessageBox.Show(approvedsource);
                        if (approvedsource == "YES")
                        {
                            if (String.IsNullOrWhiteSpace(IMPACT_05.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_13.Text) ||
                                !String.IsNullOrWhiteSpace(IMPACT_21.Text))
                            {
                                await this.ShowMessageAsync("Please check the form and resubmit.", "Approved must be in the correct column");
                                System.Windows.MessageBox.Show("Approved must be in the correct column");
                            }
                            if (String.IsNullOrWhiteSpace(IMPACT_01.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_03.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_05.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_07.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_09.Text) ||
                                String.IsNullOrWhiteSpace(IMPACT_11.Text))
                            {
                                await this.ShowMessageAsync("Please check the form and resubmit.", "You have not entered enough information for the approved vendor");
                                //System.Windows.MessageBox.Show("You have not entered enough information for the approved vendor" + "\n" + "Please check the form and resubmit.");
                            }

                            if (!String.IsNullOrWhiteSpace(IMPACT_01.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_03.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_05.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_07.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_09.Text) &&
                                !String.IsNullOrWhiteSpace(IMPACT_11.Text))
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();
                                await this.ShowMessageAsync("Purchase Request Submitted", "Your request has been successfully forwarded through SL PRAMS." + "\n" + "Your AO will recieve and email notification of the new request" + "\n" + "You may close the application or submit another request.");
                                //System.Windows.MessageBox.Show("Purchase Request Submitted!");
                                while (myReader.Read())
                                {
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Oops! something broke!", "Please make a screenshot and record what you were doing." + "\n" + "Then, please contact your SL PRAMS administrator with the details so they can fix this bug!");
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void TextBlock_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}

