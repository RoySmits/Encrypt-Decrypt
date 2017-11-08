using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptionDecryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string hash = "r0y$m1t5";

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtValue.Text);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encrypttxt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(encrypttxt.Text);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    decrypttxt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"e:\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(encrypttxt.Text);
                }
            }

        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
            // Open the file to read from.
        //    string path = @"e:\MyTest.txt";
        //    using (StreamReader sr = File.OpenText(path))
        //    {
        //        while ((path = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(path);
        //        }
        //    }

        //}

    }
}