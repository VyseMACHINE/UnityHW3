using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
        Thread thCrypt = null;

        public Form1()
        {
            InitializeComponent();
            pbFileCopy.Minimum = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Multiselect = false;
            dlg.Title = "Открытия файла";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSourceFile.Text = dlg.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtKey != null)
            {
                try
                {
                    if (rdXorAdd.Enabled)
                    {
                        thCrypt = new Thread(ForEncrypt);
                        thCrypt.IsBackground = true;
                        thCrypt.Start();
                    }
                    else if (rdXorRem.Enabled)
                    {
                        thCrypt = new Thread(ForDecrypt);
                        thCrypt.IsBackground = true;
                        thCrypt.Start();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали radioButton");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите пароль!");
            }
        }

        public string Encrypt(string message, int key)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
                result += (char)(message[i] ^ key);
            return result;
        }

        public string Decrypt(string message, int key)
        {
            return Encrypt(message, key);
        }

        public void ForEncrypt()
        {
            string encryptedText = "";
            try
            {
                using (FileStream fstream = File.OpenRead(txtSourceFile.Text))
                {
                    byte[] array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);

                    string textFromFile = Encoding.Default.GetString(array);

                    encryptedText = Encrypt(textFromFile, Convert.ToInt32(txtKey.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            using (FileStream fstream = new FileStream(txtSourceFile.Text, FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(encryptedText);
                
                fstream.Write(array, 0, array.Length);
                
                pbFileCopy.Invoke(new Action<int>(
                    (x) =>
                    {
                        pbFileCopy.Maximum = x;
                        pbFileCopy.Update();
                    }), (int)fstream.Length);

                pbFileCopy.Invoke(new Action<int>(
                    (x) =>
                    {
                        pbFileCopy.Value = x;
                        pbFileCopy.Update();
                    }), (int)fstream.Length);
            }
        }

        public void ForDecrypt()
        {
            string decryptedText = "";

            using (FileStream fstream = File.OpenRead(txtSourceFile.Text))
            {
                byte[] array = new byte[fstream.Length];
                
                fstream.Read(array, 0, array.Length);
                
                string textFromFile = Encoding.Default.GetString(array);

                decryptedText = Decrypt(textFromFile, Convert.ToInt32(txtKey.Text));
            }

            using (FileStream fstream = new FileStream(txtSourceFile.Text, FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(decryptedText);
                
                fstream.Write(array, 0, array.Length);

                pbFileCopy.Invoke(new Action<int>(
                    (x) =>
                    {
                        pbFileCopy.Maximum = x;
                        pbFileCopy.Update();
                    }), (int)fstream.Length);

                pbFileCopy.Invoke(new Action<int>(
                    (x) =>
                    {
                        pbFileCopy.Value = x;
                        pbFileCopy.Update();
                    }), (int)fstream.Length);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
