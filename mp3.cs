using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecteur_mp3
{
    public partial class mp3 : Form
    {
        WMPLib.IWMPPlaylist playlist;
        WMPLib.IWMPMedia media;
        private int sing;

        public mp3()
        {
            InitializeComponent();
            playlist = axWindowsMediaPlayer2.playlistCollection.newPlaylist("myplaylist");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (checkBox4.Checked)
                {
                    string[] fts12 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*."+textBox1.Text, SearchOption.AllDirectories);

                    foreach (string file2 in fts12)
                    {
                        comboBox1.Items.Add(file2);
                        sing++;
                        media = axWindowsMediaPlayer2.newMedia(file2);
                        playlist.appendItem(media);
                    }
                }
                if (checkBox1.Checked)
                {
                    string[] fts1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.avi", SearchOption.AllDirectories);

                    foreach (string file in fts1)
                    {
                        comboBox1.Items.Add(file);
                        sing++;
                        media = axWindowsMediaPlayer2.newMedia(file);
                        playlist.appendItem(media);
                    }
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        string[] fts = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.mp3", SearchOption.AllDirectories);

                        foreach (string file in fts)
                        {
                            comboBox1.Items.Add(file);
                            sing++;
                            media = axWindowsMediaPlayer2.newMedia(file);
                            playlist.appendItem(media);
                        }
                    }
                    else
                    {
                        if (checkBox8.Checked)
                        {
                            string[] fts2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.bmp", SearchOption.AllDirectories);

                            foreach (string file in fts2)
                            {
                                comboBox1.Items.Add(file);
                                sing++;
                                media = axWindowsMediaPlayer2.newMedia(file);
                                playlist.appendItem(media);
                            }
                        }
                        else
                        {
                            if (checkBox6.Checked)
                            {
                                string[] fts3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.jpg", SearchOption.AllDirectories);

                                foreach (string file in fts3)
                                {
                                    comboBox1.Items.Add(file);
                                    sing++;
                                    media = axWindowsMediaPlayer2.newMedia(file);
                                    playlist.appendItem(media);
                                }
                            }
                            else
                            {
                                if (checkBox7.Checked)
                                {
                                    string[] fts4 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.gif", SearchOption.AllDirectories);

                                    foreach (string file in fts4)
                                    {
                                        comboBox1.Items.Add(file);
                                        sing++;
                                        media = axWindowsMediaPlayer2.newMedia(file);
                                        playlist.appendItem(media);
                                    }
                                }
                                else
                                {
                                    if (checkBox3.Checked)
                                    {
                                        string[] fts5 = Directory.GetFiles(folderBrowserDialog1.SelectedPath.ToString(), "*.ico", SearchOption.AllDirectories);

                                        foreach (string file in fts5)
                                        {
                                            comboBox1.Items.Add(file);
                                            sing++;
                                            media = axWindowsMediaPlayer2.newMedia(file);
                                            playlist.appendItem(media);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                axWindowsMediaPlayer2.currentPlaylist = playlist;
                axWindowsMediaPlayer2.settings.setMode("shuffle", true);
                axWindowsMediaPlayer2.Ctlcontrols.play();
                label14.Text = sing.ToString();

            }
            else { MessageBox.Show("choose checkbox"); }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer2.currentPlaylist = playlist;
            axWindowsMediaPlayer2.settings.setMode("shuffle", true);
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer2.URL = openFileDialog1.FileName.ToString();
        }
    }
}
