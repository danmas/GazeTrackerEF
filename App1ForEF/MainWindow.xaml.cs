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

namespace App1ForEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button cur_button = null;    //-- current button we are enter in
        long ticks_enter_on_button;  //-- ticks on enter
        long CLICK_TIME = 20000000;  //-- delay before click  2 sec 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            long cur_ticks = DateTime.Now.Ticks;

            if (ticks_enter_on_button!=0 
                && cur_ticks - ticks_enter_on_button > CLICK_TIME)
            {
                MessageBox.Show("The button " + ((Button)sender).Name + " pressed.");
                //Console.WriteLine(" !!!!!!!!!!!!!!!! CLICK BUTTON btn:" + ((Button)sender).Name);
                ticks_enter_on_button = 0; // DateTime.Now.Ticks;
                if (cur_button == B01)
                {
                    System.Diagnostics.Process.Start("E:/EYE/GazeTrackerEF/App1ForEF/mama.mp3");
                }
                if (cur_button == B10)
                {
                    String fileToOpen = "C:/test.avi";
                    System.Diagnostics.ProcessStartInfo ps =
                        new System.Diagnostics.ProcessStartInfo("C:/Program Files/Windows Media Player/wmplayer.exe"
                            , fileToOpen);
                    System.Diagnostics.Process.Start(ps);
                }
                {
                }
                {/*
                    Microsoft.DirectX.AudioVideoPlayback.Video video 
                        = new Microsoft.DirectX.AudioVideoPlayback.Video("fileName");
                    //set the System.Windows.Forms.Control to play it in (e.g a panel)
                    video.Owner = panel1;
                    //Play the video (put this in a buttons click event)
                    video.Play();
                    //Pause the video (put this in a buttons click event)
                    video.Pause();
                    //Stop the video (put this in a buttons click event)
                    video.Stop();
                */}

            }
            /*
            Point pt = e.GetPosition(this);
            if (sender is Button)
            {
                if (B00.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B00 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                } else if (B01.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B01 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                }
                else if (B10.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B10 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                } else if (B11.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B11 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                }
            }*/
        }
        
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            cur_button = (Button)sender;
            ticks_enter_on_button = DateTime.Now.Ticks;
            //Console.WriteLine(" Enter button " + cur_button.Name + "  ticks_enter_on_button:" + ticks_enter_on_button);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            cur_button = (Button)sender;
            ticks_enter_on_button = 0;
            //Console.WriteLine(" Leave button " + cur_button.Name);
        }
    
    }
}
