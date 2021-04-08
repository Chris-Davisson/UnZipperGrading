//Christopher Davisson
//Auto UnZipper
//11/2/2020
//No rights reserved

using System;
using System.IO;
using System.IO.Compression;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace UnZipGrading
{
    public partial class MainWindow : Window
    {
        string sourcePath = @"C:\Users\", destPath = @"C:\";
        string[] fileNames = {};
        string[] pathNames = {};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            sourcePath = source_txt.Text;
            destPath = dest_txt.Text;
            bool isValidSource =  IsValidPath(sourcePath);
            bool isValidDest = IsValidPath(destPath);
            if(!isValidSource)
            {
                output_txt.Text = "Invalid Dir \nSource dir: " + sourcePath + "\nDestination dir: " + destPath;
            }
            if (isValidSource)
            {
                try
                {
                    output_txt.Text += "Files in source\n";
                    pathNames = Directory.GetFiles(sourcePath , "*.zip");

                    fileNames = new string[pathNames.Length];
                    for(int i =0; i < pathNames.Length; i++)
                    {
                        fileNames[i] = System.IO.Path.GetFileName(pathNames[i]).Replace(".zip" , "");
                        fileNames[i].Substring(0,fileNames[i].IndexOf("_"));
                    }
                    foreach(string s in fileNames)
                    {
                        output_txt.Text += s + "\n";
                    }
                    output_txt.Text += "There are " + fileNames.Length + "zip files";   
                    unpack();
                }
                catch(Exception)
                {
                    output_txt.Text += "Error:  " + e + "\nCheck for 7zip or someone just renaming a folder with .zip";
                }
            }
        }

        private void unpack()
        {
            for(int i = 0; i < pathNames.Length; i++)
            {
                Directory.CreateDirectory(destPath + "\\" + fileNames[i]);
                ZipFile.ExtractToDirectory(pathNames[i] , destPath + "\\"+ fileNames[i]);
            }
        }

        private void source_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            sourcePath = this.source_txt.Text;
        }

        private void dest_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            destPath = dest_txt.Text;
        }

        private void source_txt_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (this.source_txt.Text.Equals("Enter Absolute Source path..."))
            {
                this.source_txt.Text = "";
            }
        }

        private void txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (source_txt.Text.Length < 1)
                source_txt.Text = "Enter Absolute Source path...";
            if (dest_txt.Text.Length < 1)
                dest_txt.Text = "Enter Absolute Destination path...";
        }

        private void dest_txt_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (this.dest_txt.Text.Equals("Enter Absolute Destination path..."))
            {
                this.dest_txt.Text = "";
            }
        }

        private bool IsValidPath(string path)
        {
            bool isValid = Directory.Exists(path);
            return isValid;
        }
    }
}
