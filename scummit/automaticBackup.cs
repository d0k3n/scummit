using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scummit
{
    public partial class automaticBackup : Form
    {
        private bool started = false;
        public automaticBackup()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {

            if (started)
            {
                // stop
                timer1.Stop();
                started = false;
                start.Text = "Start";
            }
            else
            {
                // start
                if (Directory.Exists(folder.SelectedPath)
                    && File.Exists(file.FileName))
                {
                    Properties.Settings.Default.fileName = file.FileName;
                    Properties.Settings.Default.destinationFolder = folder.SelectedPath;
                    Properties.Settings.Default.interval = Convert.ToInt32(interval.Value);
                    Properties.Settings.Default.filesToKeep = Convert.ToInt32(filesToKeep.Value);
                    Properties.Settings.Default.Save();

                    backups.Items.Clear();
                    backups.Items.AddRange(Directory.GetFiles(folder.SelectedPath, "*.sav"));

                    timer1.Interval = Convert.ToInt32(interval.Value) * 1000 * 60;
                    timer1.Start();
                    started = true;
                    start.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Choose the file to backup and the destination folder.");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            fileName.Text = file.FileName = Properties.Settings.Default.fileName;
            backupFolder.Text = folder.SelectedPath = Properties.Settings.Default.destinationFolder;
            interval.Value = Properties.Settings.Default.interval;
            filesToKeep.Value = Properties.Settings.Default.filesToKeep;

            if (Directory.Exists(folder.SelectedPath))
            {
                backups.Items.Clear();
                backups.Items.AddRange(Directory.GetFiles(folder.SelectedPath, "*.sav"));
            }
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            fileName.Text = file.FileName;
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            folder.ShowDialog();
            backupFolder.Text = folder.SelectedPath;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // copiar ficheiro para a pasta de destino.
            List<string> files = Directory.GetFiles(folder.SelectedPath, "*.sav").ToList();

            if (files.Count >= Convert.ToInt32(filesToKeep.Value))
            {
                files.Sort();
                // delete the oldest file.
                File.Delete(files[0]);

            }

            string now = DateTime.Now.ToString("G");

            string destination = Path.GetFileNameWithoutExtension(file.FileName) + now + ".sav";

            File.Copy(file.FileName, Path.Combine(folder.SelectedPath, destination));

            backups.Items.Clear();
            backups.Items.AddRange(Directory.GetFiles(folder.SelectedPath, "*.sav"));

            lastBackup.Text = now;
        }

        private void restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (backups.SelectedIndex > 0)
                {
                    File.Copy(backups.SelectedItem.ToString(), file.FileName, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
