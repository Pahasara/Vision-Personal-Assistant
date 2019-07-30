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
using Vision.Core;

namespace MARK
{
    public partial class MainUI : Form
    {
        Vision.Core.Main MK_MAIN = new Vision.Core.Main();

        /*                               PROGRAM VARIABLES                                 */
        private bool drag = false; private Point startPoint = new Point(0, 0); string line = ""; bool cmd = false;//Main Variables
        int Tsecond = 00, Tminute = 00, Thour = 00; string StrWTime = "00:00", TxSecond = "00", TxMinute = "00", Txhour = "00";//For Working Time Count
        string mkvol; string user = "Sir"; int Vision_MKVolume; string speak; string userdatafile = "User.vidb";//Settings up User Info
        string command; string iscommand; Boolean iscmd;//For Command Mode 
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

        Choices list = new Choices();
        public SpeechSynthesizer s = new SpeechSynthesizer();
        public MainUI()
        {
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();

            list.Add(new String[] { "Hello", "Vision", "hi", "Good", "what is your name", "open chrome", "thank you", "open" });

            Grammar gr = new Grammar(new GrammarBuilder(list));
            try { rec.RequestRecognizerUpdate(); rec.LoadGrammar(gr); rec.SpeechRecognized += rec_SpeechRecognized;
                  rec.SetInputToDefaultAudioDevice();  rec.RecognizeAsync(RecognizeMode.Multiple); }
            catch { return; }
            s.SelectVoiceByHints(VoiceGender.Male);
            InitializeComponent();

        }

        //************************************************************************************************************************       
        /*                                              *  User Interface Load  *                                                          */
        private void MainUI_Load(object sender, EventArgs e)
        {
            VerifyProtection();            
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //************************************************************************************************************************       
        /*                                              *  Voice Recognition Part  *                                                          */
        public void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String UWord = e.Result.Text;
            if (UWord == "Hello") { Say("Hi  your  welcome"); }
            else if (UWord == "hi") { Say("hi"); }
            else if (UWord == "Good") { Say("Thanks for you"); }
            else if (UWord == "open chrome") { Run("chrome"); Print("Now opening google chrome"); hide(); }
            else if (UWord == "vision") { Say("why"); }
            else if (UWord == "thank you") { Say("your welcome " + user); }
            else if (UWord == "open") { Say("what you want to open."); }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //************************************************************************************************************************       
        /*                                              *  Main Functions  *                                                          */
        public void Print(String str) { outputTextBox1.Text = str; Say(str); }
        public void hide() { Say("Window minimized."); this.WindowState = FormWindowState.Minimized; }
        public void GetTime() { String time = DateTime.Now.ToLongTimeString(); outputTextBox1.Text = outputTextBox1.Text + ">>>" + time + "\n"; }
        public void GetDate() { String date = DateTime.Today.ToShortDateString(); outputTextBox1.Text = outputTextBox1.Text + ">>>" + date + "\n"; }
        public void ShowCredits() { details.Text = ""; details.Text += "*****   "+ MK_MAIN.proName() + " [" + MK_MAIN.setYear() + "]   *****\n"; details.Text += "\n";
            details.Text += "Programmer :  Dewnith Fernando.\n"; details.Text += "UI Designer :  Dewnith Fernando.\n";
            details.Text += "\n"; details.Text += "Version :  " + MK_MAIN.getVersion() + "\n";
            details.Text += "\n"; details.Text += "Copyright © " + MK_MAIN.getYear() +", M.P.Dewnith Fernando and/or its affiliates. ";
            details.Text += "All rights reserved."; }
        public void Exit() { cmd = true; ShowCredits(); outputTextBox1.Text = "Good Bye " + user + "\n";inputtext.Text = ""; outputTextBox1.Text = MK_MAIN.proName() + " is shutting down....."; Say("Good bye " + user +". "+ MK_MAIN.proName() +" is shutting down."); }
        public void CheckCWT() { line = File.ReadLines(userdatafile).Skip(1).Take(1).First(); if (line == "1100") { CountWk_Time.Enabled = true; udtime.Visible = true; } else { udtime.Visible = false; } }
        public void GetUserInfo() { mkvol = File.ReadLines(userdatafile).Skip(3).Take(1).First(); user = File.ReadLines(userdatafile).Skip(4).Take(1).First(); speak = File.ReadLines(userdatafile).Skip(2).Take(1).First(); }
        public void SetMKVolume() { if (mkvol == "0100") { Vision_MKVolume = 100; } else if (mkvol == "1000") { Vision_MKVolume = 75; } else if (mkvol == "0010") { Vision_MKVolume = 50; } else if (mkvol == "0001") { Vision_MKVolume = 25; } else if (speak == "0010") { Vision_MKVolume = 0; } s.Volume = Vision_MKVolume; }
        public void Say(String h) { s.Speak(h); }
        public void Run(String app) { Process.Start(app); }

        //************************************************************************************************************************
        
        /*                                          RunCommand [commands runner]                                                                 */
        public void RunCommand()
        {
            if (iscmd == true)
            {
                switch (iscommand)
                {
                    case "RUN": try { Run(command); } catch (Exception) { Print(command + " executable not found in your computer."); } break;
                    case "GOOD": if (command == "BYE") { Application.Exit(); } break;
                    case "UPDATE": if (command == "THIS") { } break;
                }

                switch (command)
                {
                    case "SETTINGS": { Run("vin_pref.exe"); UserPref_Timing.Enabled = true; } break;
                }
            } else { Search(); }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                         Get Outputs from main.Dll / Database.mdf                                         */
        private void Search()
        {
            string uin = inputTextBox1.Text;
            inputTextBox1.Text = ""; inputtext.Text = uin;

            if (uin == "info") { inputTextBox1.Text = ""; ShowCredits(); }
            else if (uin == "show time") { outputTextBox1.Text = ""; inputtext.Text = "Now Time"; GetTime(); }
            else if (uin == "show date") { outputTextBox1.Text = ""; inputtext.Text = "Date"; GetDate(); }
            else if (uin == "about") { About About = new About(); About.ShowDialog(); }
            else if (uin == "hide") { outputTextBox1.Text = "Window minimized"; inputTextBox1.Text = ""; hide(); Print(outputTextBox1.Text); }
            else { Print(MK_MAIN.Answer(uin)); }
            try { tableBindingSource.Filter = "input LIKE '" + uin + "%'"; Print(outputTextBox1.Text); }
            catch (Exception) { outputTextBox1.Text = uin + "is not found in my database.However you can include about " + uin + " in my Database."; Print(outputTextBox1.Text);}
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Mark_Start()
        {
            GetUserInfo();
            SetMKVolume();
            Say("Hi, i am  " + MK_MAIN.proName());
            CheckCWT();
            Say("Have a nice day " + user);
            outputTextBox1.Text = "Have a nice day " + user + ".\n";
            version.Text = MK_MAIN.setVersion();
            build.Text = MK_MAIN.setBuildNo();
            copyright.Text = "Copyright © " + "2018 - " + MK_MAIN.getYear() + " Dewnith Fernando. All rights reserved.";
            //ShowCredits();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                           Check programm protection                                                                  */
        public void VerifyProtection()
        {
            try
            {
                line = File.ReadLines(userdatafile).Skip(0).Take(1).First();
                if (line == "22898225255648845454545456237372346234645265342553424524543253")
                {
                    Mark_Start();
                    ShowMainUI();
                    outputTextBox1.Text += "\n" + "Program Protection test Successful!\n\n";
                    try
                    {
                        this.tableTableAdapter.Fill(this.databaseDataSet.Table);
                    }
                    catch (Exception)
                    {
                        tableBindingNavigator.Visible = false;
                        MessageBox.Show("Can't login Database.'Database.mdf' file not found or 'SQL Server' is not installed in your system.Please install 'SQL Server 2014 Express or newever' for run this program.", "Database Login Error");
                        details.Text += "ERROR:Vision couldn't login his database file[Database.mdf].It's a very important file for " + MK_MAIN.proName() + ".\n";
                        details.Text += "'Database.mdf' file not found or SQL Server is not installed on your computer.\n";
                        details.Text += "Please install 'SQL Server Express 2014' or newever on your computer.\n";
                        details.Text += "Actually you can report any issue to 'dvnetsoft@gmail.com'.\n";
                    }
                }
                else
                {
                    MessageBox.Show("Vision Program Protection found a error, beacause you execute this program without using " + MK_MAIN.proName() + " Launcher. Please run again this program using launcher.", "Vision Protection Error"); this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't found 'User.vidb' file. Please re'install this program and fix.", "ERROR : Couldn't found 'User Data'"); this.Close();
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ShowMainUI()
        {
            string showmainui = File.ReadLines(userdatafile).Skip(6).Take(1).First();
            if (showmainui == "2155sg64g046-8u75uet22a03657j0-27jrw4655254-36s534q636h36-y83528hjnn7142746bhfdf") { TimingBelt.Start(); }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void TimingBelt_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 90) { this.Opacity += 5; }
            else { TimingBelt.Stop(); }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void WRITEOUT(string gtudat)
        {
            string clock = File.ReadLines(userdatafile).Skip(1).Take(1).First();
            string speak = File.ReadLines(userdatafile).Skip(2).Take(1).First();
            string vol = File.ReadLines(userdatafile).Skip(3).Take(1).First();
            string name = File.ReadLines(userdatafile).Skip(4).Take(1).First();

            string[] lines = { gtudat, clock, speak, vol, name };
            System.IO.File.WriteAllLines(@userdatafile, lines);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                              Get Working Time                                             */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tsecond == 60) { Tminute++; Tsecond = 00; }  else { Tsecond++; }
            if (Tminute == 60) { Thour++; Tminute = 00; }
            if (Tsecond < 10) { TxSecond = "0" + Tsecond.ToString(); } else { TxSecond = Tsecond.ToString(); }
            if (Tminute < 10) { TxMinute = "0" + Tminute.ToString(); } else { TxMinute = Tminute.ToString(); }
            if (Thour < 10) { Txhour = "0" + Thour.ToString(); ; } else { Txhour = Thour.ToString(); }
            StrWTime = Txhour + ":" + TxMinute + ":" + TxSecond;  udtime.Text = StrWTime;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*                                              *  User Settings --Update Timing  *                                                    */
        private void timer2_Tick(object sender, EventArgs e)
        {
            string pref_done = File.ReadLines(userdatafile).Skip(5).Take(1).First();
            if (pref_done == "10011001043555535555552212")
            {
                UserPref_Timing.Enabled = false;
                GetUserInfo();
                SetMKVolume();
                s.Volume = Vision_MKVolume;
                CheckCWT();
                version.Text = MK_MAIN.setVersion();
                ShowCredits();
                Say("User settings has been updated!");
                outputTextBox1.Text = "User settings was updated on " + DateTime.Now.ToLongTimeString();
                MessageBox.Show("User settings has been updated!", "Preferences Updated");
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //**************************************    EVENTS.MAINUI    **********************************************//
        private void title_MouseDown(object sender, MouseEventArgs e) { this.startPoint = e.Location; this.drag = true; }
        private void title_MouseMove(object sender, MouseEventArgs e) { if (this.drag) { Point p1 = new Point(e.X, e.Y); Point p2 = this.PointToScreen(p1); Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y); this.Location = p3; } }
        private void title_MouseUp(object sender, MouseEventArgs e) { this.drag = false; }
        private void Button1_Click_1(object sender, EventArgs e) { Application.Exit(); }
        private void license_Click(object sender, EventArgs e) { ShowCredits(); }
        private void searchbtn_Click(object sender, EventArgs e) { Search(); }
        private void inputTextBox1_Click1(object sender, EventArgs e) { inputTextBox1.Text = ""; }
        private void Button1_Click(object sender, EventArgs e) { About About = new About(); About.Show(); }
        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e) { this.Validate(); this.tableBindingSource.EndEdit(); this.tableAdapterManager.UpdateAll(this.databaseDataSet); }
        private void MainUI_FormClosing(object sender, FormClosingEventArgs e) { if (cmd == false) { Exit(); WRITEOUT("22898225451643846458545757237772346234671265342558224564543263"); } }
        private void InputTextBox1_Enter(object sender, EventArgs e) { TextLine.BackColor = Color.FromArgb(23, 124, 185); }
        private void InputTextBox1_Leave(object sender, EventArgs e) { TextLine.BackColor = Color.FromArgb(64, 64, 64); }
        private void TitleName_MouseDown(object sender, MouseEventArgs e) { this.startPoint = e.Location; this.drag = true; }
        private void TitleName_MouseMove(object sender, MouseEventArgs e) { if (this.drag) { Point p1 = new Point(e.X, e.Y); Point p2 = this.PointToScreen(p1); Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y); this.Location = p3; } }
        private void TitleName_MouseUp(object sender, MouseEventArgs e) { this.drag = false; }
        private void OutputTextBox1_Enter(object sender, EventArgs e) { OutLine.BackColor = Color.FromArgb(23, 124, 185); }
        private void OutputTextBox1_Leave(object sender, EventArgs e) { OutLine.BackColor = Color.FromArgb(64, 64, 64); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void inputTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: if (iscmd == true) { iscmd = false; } else { iscmd = true; } break;
                case Keys.A: command += "A"; break; case Keys.B: command += "B"; break; case Keys.C: command += "C"; break; case Keys.D: command += 'D'; break;
                case Keys.E: command += 'E'; break; case Keys.F: command += 'F'; break; case Keys.G: command += 'G'; break; case Keys.H: command += 'H'; break;
                case Keys.I: command += 'I'; break; case Keys.J: command += 'J'; break; case Keys.K: command += 'K'; break; case Keys.L: command += 'L'; break;
                case Keys.M: command += 'M'; break; case Keys.N: command += 'N'; break; case Keys.O: command += 'O'; break; case Keys.P: command += 'P'; break;
                case Keys.Q: command += 'Q'; break; case Keys.R: command += 'R'; break; case Keys.S: command += 'S'; break; case Keys.T: command += 'T'; break;
                case Keys.U: command += 'U'; break; case Keys.V: command += 'V'; break; case Keys.W: command += 'W'; break; case Keys.X: command += 'X'; break;
                case Keys.Y: command += 'Y'; break; case Keys.Z: command += 'Z'; break; case Keys.Space: iscommand = command; command = ""; break;
                case Keys.Enter: RunCommand(); command = ""; break;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MainUI_Deactivate(object sender, EventArgs e)
        {
            title.BackColor = Color.FromArgb(28, 164, 205); titleX.BackColor = Color.FromArgb(28, 164, 210);
            titleY.BackColor = Color.FromArgb(28, 164, 210); cls_btn.BackColor = Color.FromArgb(28, 164, 210);
            titleName.BackColor = Color.FromArgb(28, 164, 210); this.BackColor = Color.FromArgb(16, 16, 16);
            shine1.Visible = false; shine2.Visible = false; shine3.Visible = false; shine4.Visible = false;
            shine5.Visible = false; shine6.Visible = false; shine7.Visible = false; shine8.Visible = false;
            inputTextBox1.BackColor = Color.FromArgb(24, 24, 24); outputTextBox1.BackColor = Color.FromArgb(22, 22, 22);
            //lineX.Visible = false; lineY.Visible = false; lineZ.Visible = false;
            lineX.BackColor = Color.FromArgb(48,48,48); lineY.BackColor = Color.FromArgb(48, 48, 48); lineZ.BackColor = Color.FromArgb(48, 48, 48);
        }
        private void MainUI_Activated(object sender, EventArgs e)
        {
            title.BackColor = Color.FromArgb(28, 144, 205); titleX.BackColor = Color.FromArgb(28, 144, 200);
            titleY.BackColor = Color.FromArgb(28, 144, 200); cls_btn.BackColor = Color.FromArgb(28, 144, 200);
            titleName.BackColor = Color.FromArgb(28, 144, 200); this.BackColor = Color.FromArgb(12, 12, 12);
            shine1.Visible = true; shine2.Visible = true; shine3.Visible = true; shine4.Visible = true;
            shine5.Visible = true; shine6.Visible = true; shine7.Visible = true; shine8.Visible = true;
            inputTextBox1.BackColor = Color.FromArgb(20, 20, 20); outputTextBox1.BackColor = Color.FromArgb(18, 18, 18);
            //lineX.Visible = true; lineY.Visible = true; lineZ.Visible = true;
            lineX.BackColor = Color.FromArgb(28,144,205); lineY.BackColor = Color.FromArgb(28, 144, 205); lineZ.BackColor = Color.FromArgb(28, 144, 205);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
    
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////