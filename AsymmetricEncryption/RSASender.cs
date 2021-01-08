using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymmetricEncryption
{
    /// <summary>
    /// RSASender class
    /// Has the purpose of making a form that can encrypt data 
    /// </summary>
    public partial class RSASender : Form
    {
        public RSASender()
        {
            InitializeComponent();
            // new instance of rsaReceiver
            RSAReceiver rsaReceiver = new RSAReceiver();
            // make rsaReceiver show at the same time as RSASender
            rsaReceiver.Show();
           
        }
        // private instances of Rsa and XmlReader
        private Rsa rsa = new Rsa();

        private XmlReader xmlReader = new XmlReader();

        // RsaSender_Load gets executed when the form loads it will load the values of modulus and exponent from publickey.xml file
        private void RSASender_Load(object sender, EventArgs e)
        {
            
            string publicKeyPath = rsa.GetPublicKeyPath();
            string privateKeyPath = rsa.GetPrivateKeyPath();
           // run xmlreader.GetValueFromXmlFile on both modulus and exponent to get the values from the publickey.xml file
            ModulusTextBox.Text = xmlReader.GetValueFromXmlFile("Modulus", publicKeyPath);
            ExponentTextBox.Text = xmlReader.GetValueFromXmlFile("Exponent", privateKeyPath);
        }

        // encryptButton executes encryptData based on the plainText inserted in the textBox. 
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // get publicKeyPath 
            string publicKeyPath = rsa.GetPublicKeyPath();
            string plainText = PlainedTextBox.Text;
            // run EncryptData method and store the byte array in the byte array encryptedText
            byte[] encryptedText = rsa.EncryptData(publicKeyPath, Encoding.UTF8.GetBytes(plainText));
            // show the encryptedText in the text box
            CipherTextBox.Text = Convert.ToBase64String(encryptedText);
        }
    }
}