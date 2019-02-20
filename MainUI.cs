/*
 * 
 * 
 * Copyright(c) 2018, 2019, Dewnith Fernando and/or its affiliates.All rights reserved.
 * Dewnith Fernando PROPRIETARY/CONFIDENTIAL.Use is subject to license terms.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO;
using Vision_Core;

namespace MARK
{
    public partial class MainUI : Form
    {

        Vision_Core.Main MK_MAIN = new Vision_Core.Main();
        Vision_Core.IOFile MK_IO = new Vision_Core.IOFile();
        Vision_Core.Update MK_UPDATE = new Vision_Core.Update();

        /////////////////////////////////          Variable Declarions                 /////////////////////////////////////
        /* PROGRAM VARIABLES */
              String PROGRAM_NAME = "Vision"; String PROGARM_VERSION = "Preview  Version 2.8";
             /* PROGRAM VARIABLES */
        int mouseX = 0; int mouseY = 0; bool mouseDown; string line = ""; string error;//Main Variables
        int Tsecond = 00, Tminute = 00, Thour = 00; string StrWTime = "00:00", TxSecond = "00", TxMinute = "00", Txhour = "00";//For Working Time Count
        string mkvol; string user = "Sir"; int volume; string speak; string userdatafile = "User.vidb";//Settings up User Info
        string command; string iscommand; Boolean iscmd;//For Commad Mode
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        Choices list = new Choices();

        public MainUI()
        {
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] { "Hello", "Vision", "hi", "Good", "what is your name", "open chrome", "thank you", "open" });
            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += MK_MAIN.rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch { return; }
            MK_MAIN.s.SelectVoiceByHints(VoiceGender.Male);
            InitializeComponent();
        }

        private void title_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; }
        private void title_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { mouseX = MousePosition.X - 200; mouseY = MousePosition.Y - 40; this.SetDesktopLocation(mouseX, mouseY); } }
        private void title_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        private void clsbtn_Click(object sender, EventArgs e) { exit(); }
        private void clsbtn_MouseMove(object sender, MouseEventArgs e) { clsbtn.BackColor = Color.FromArgb(254, 49, 44); clsbtn.ForeColor = Color.White; }
        private void clsbtn_MouseLeave(object sender, EventArgs e) { clsbtn.BackColor = Color.FromArgb(20,20,20); clsbtn.ForeColor = Color.Gainsboro; }
        private void license_Click(object sender, EventArgs e) { showdat(); }
        private void searchbtn_Click(object sender, EventArgs e) { search(); }
        private void inputTextBox1_Click1(object sender, EventArgs e) { inputTextBox1.Text = ""; }
        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e) { this.Validate(); this.tableBindingSource.EndEdit(); this.tableAdapterManager.UpdateAll(this.databaseDataSet); }
        //************************************************************************************************************************       
        /*                                              *  User Interface Load  *                                                          */
        private void MainUI_Load(object sender, EventArgs e)
        {
            checkprpro();
            show_mainui.Enabled = true;
            mark_start();
            this.tableTableAdapter.Fill(this.databaseDataSet.Table);
        }

        //************************************************************************************************************************       
        /*                                              *  Main Functions  *                                                          */
        public void print(String str) { outputTextBox1.Text = str; MK_MAIN.say(str); }
        public void hide() { MK_MAIN.say("Window minimized."); this.WindowState = FormWindowState.Minimized; }
        public void gettime() { String time = DateTime.Now.ToLongTimeString(); outputTextBox1.Text = outputTextBox1.Text + ">>>" + time + "\n"; }
        public void getdate() { String date = DateTime.Today.ToShortDateString(); outputTextBox1.Text = outputTextBox1.Text + ">>>" + date + "\n"; }
        public void showdat() { details.Text = ""; details.Text += "*****   "+ PROGRAM_NAME + " [2019. 02]   *****\n"; details.Text += "\n";
            details.Text += "Programmer :  Dewnith Fernando.\n"; details.Text += "UI Designer :  Dewnith Fernando.\n";
            details.Text += "\n"; details.Text += "Version :  '"+ PROGRAM_NAME + " Preview' v2.8.4078 [2019.02]\n";
            details.Text += "\n"; details.Text += "Copyright © 2019, Dewnith Fernando and/or its affiliates. ";
            details.Text += "All rights reserved."; }
        public void exit() { outputTextBox1.Text = "Good Bye " + user + ".\n" + " "+ PROGRAM_NAME + " is shutting down.....\n"; MK_MAIN.say("Good bye " + user +". "+ PROGRAM_NAME +" is shutting down."); MK_MAIN.getudata("22898225255643845454545754237372346234645265342558424524543263"); this.Close(); }
        public void checkcwt() { line = File.ReadLines(userdatafile).Skip(1).Take(1).First(); if (line == "1100") { timer1.Enabled = true; udtime.Visible = true; } else { udtime.Visible = false; } }
        public void getuserinfo() { mkvol = File.ReadLines(userdatafile).Skip(3).Take(1).First(); user = File.ReadLines(userdatafile).Skip(4).Take(1).First(); speak = File.ReadLines(userdatafile).Skip(2).Take(1).First(); }
        public void setvol() { if (mkvol == "0100") { volume = 100; } else if (mkvol == "1000") { volume = 75; } else if (mkvol == "0010") { volume = 50; } else if (mkvol == "0001") { volume = 25; } else if (speak == "0010") { volume = 0; } }


        //************************************************************************************************************************

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                              Get Working Time                                             */
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (Tsecond == 60) { Tminute++; Tsecond = 00; }
            else { Tsecond++; }

            if (Tminute == 60) { Thour++; Tminute = 00; }

            if (Tsecond < 10) { TxSecond = "0" + Tsecond.ToString(); } else { TxSecond = Tsecond.ToString(); }
            if (Tminute < 10) { TxMinute = "0" + Tminute.ToString(); } else { TxMinute = Tminute.ToString(); }
            if (Thour < 10) { Txhour = "0" + Thour.ToString(); ; } else { Txhour = Thour.ToString(); }

            //stime = h.ToString() + ":" + m.ToString() + ":" + st.ToString();
            StrWTime = Txhour + ":" + TxMinute + ":" + TxSecond;
            udtime.Text = StrWTime;
        } 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void timer2_Tick(object sender, EventArgs e)
        {
            string pref_done = File.ReadLines(userdatafile).Skip(5).Take(1).First();
            if (pref_done == "10011001043555535555552212")
            {
                timer2.Enabled = false;
                mark_start();
                print(PROGRAM_NAME + " System has been updated!");
                MessageBox.Show("User data has been updated!", "Updated");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void mark_start()
        {
            getuserinfo();
            setvol();
            MK_MAIN.s.Volume = volume;
            MK_MAIN.say("Hi, i am  " + PROGRAM_NAME);
            checkcwt();
            print("Have a nice day " + user);
            version.Text = PROGARM_VERSION;
            showdat();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                           Check programm protection                                                                  */
        public void checkprpro()
        {
            try
            {
                line = File.ReadLines(userdatafile).Skip(0).Take(1).First();
                if (line == "22898225255648845454545456237372346234645265342553424524543253") { outputTextBox1.Text += "/n" + "Program Protection test Successful!"; }
                else
                {
                    MessageBox.Show("Program protection found a error: you run this program without using "+PROGRAM_NAME+" Launcher...Please run again this program using launcher.", "Program Protection Error"); this.Close();
                }
            }
            catch (Exception IOError)
            {
                MessageBox.Show("Couldn't found 'User.vidb' file.Please re'install this program and fix.", "ERROR : Couldn't found 'User Data'");this.Close();
            }
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e){ MK_MAIN.getudata("22898225451643846458545757237772346234671265342558224564543263"); }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                          RunCommand [commands runner]                                                                 */
        public void RunCommand()
        {
            if (iscmd == true)
            {
                switch (iscommand) {
                    case "RUN": try { MK_MAIN.run(command); } catch (Exception IOError) { print(command + " executable not found in your computer."); } break;
                    case "GOOD": if (command == "BYE") { exit(); } break;
                    case "PLAY": if (command == "WARCRAFT") { try { Warcraft3.Start(); exit(); } catch (Exception IOError) { MessageBox.Show("Warcraft III.exe is not found."); } } break;
                    case "UPDATE": if (command == "THIS") { MK_UPDATE.UPDATE(); print(MK_UPDATE.UPDATE()); } break;
                }
            }
            else { search(); }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                         Get Outputs from main.Dll / Database.mdf                                         */
        private void search()
        {
            string uin = inputTextBox1.Text; 
            inputTextBox1.Text = ""; inputtext.Text = uin;

            if (uin == "info") { inputTextBox1.Text = ""; showdat(); }
            else if (uin == "show time") { outputTextBox1.Text = ""; inputtext.Text = "Now Time"; gettime(); }
            else if (uin == "show date") { outputTextBox1.Text = ""; inputtext.Text = "Date"; getdate(); }
            else if (uin == "settings") { hide(); MK_MAIN.run("mark_pref.exe"); timer2.Enabled = true; }
            else if (uin == "hide") { outputTextBox1.Text = "Window minimized"; inputTextBox1.Text = ""; hide(); print(outputTextBox1.Text); }
            else { print(MK_IO.Answer(uin)); }
            try { tableBindingSource.Filter = "input LIKE '" + uin + "%'"; print(outputTextBox1.Text); }
            catch (Exception ex) { outputTextBox1.Text = uin + "is not found in my database.However you can include about " + uin + " in my Database."; print(outputTextBox1.Text);}
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void inputTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void show_mainui_Tick(object sender, EventArgs e)
        {
            string showmainui = File.ReadLines(userdatafile).Skip(6).Take(1).First();
            if (showmainui == "2155sg64g046-8u75uet22a03657j0-27jrw4655254-36s534q636h36-y83528hjnn7142746bhfdf")
            {
                show_mainui.Enabled = false;
                this.Opacity = 99;
            }
        }
        private void inputTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: if (iscmd == true) { iscmd = false; } else { iscmd = true; } break;
                case Keys.A: command += "A"; break;
                case Keys.B: command += "B"; break;
                case Keys.C: command += "C"; break;
                case Keys.D: command += 'D'; break;
                case Keys.E: command += 'E'; break;
                case Keys.F: command += 'F'; break;
                case Keys.G: command += 'G'; break;
                case Keys.H: command += 'H'; break;
                case Keys.I: command += 'I'; break;
                case Keys.J: command += 'J'; break;
                case Keys.K: command += 'K'; break;
                case Keys.L: command += 'L'; break;
                case Keys.M: command += 'M'; break;
                case Keys.N: command += 'N'; break;
                case Keys.O: command += 'O'; break;
                case Keys.P: command += 'P'; break;
                case Keys.Q: command += 'Q'; break;
                case Keys.R: command += 'R'; break;
                case Keys.S: command += 'S'; break;
                case Keys.T: command += 'T'; break;
                case Keys.U: command += 'U'; break;
                case Keys.V: command += 'V'; break;
                case Keys.W: command += 'W'; break;
                case Keys.X: command += 'X'; break;
                case Keys.Y: command += 'Y'; break;
                case Keys.Z: command += 'Z'; break;
                case Keys.Space: iscommand = command; command = ""; break;
                case Keys.Enter: RunCommand(); command = ""; break;
            }
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////