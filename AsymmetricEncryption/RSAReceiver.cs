using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymmetricEncryption
{
    /// <summary>
    /// class RSAReceiver
    /// has purpose of making a form that can decrypt a text encrypted with rsa 2048
    /// </summary>
    public partial class RSAReceiver : Form
    {
        public RSAReceiver()
        {
            InitializeComponent();
            rsa.SafeKeysToXml();
        }
        // private instances of Rsa and XmlReader classes
        private Rsa rsa = new Rsa();

        private XmlReader xmlReader = new XmlReader();

        // load method wich will load all the values from publickey.xml and privatekey.xml
        private void RSAReceiver_Load(object sender, EventArgs e)
        {
            string publicKeyPath = rsa.GetPublicKeyPath();
            string privateKeyPath = rsa.GetPrivateKeyPath();

            // run xmlreader.GetValueFromXmlFile on modulus and exponent to get the values from the publickey.xml file
            // run xmlreader.GetValueFromXmlFile on d, p, dp, q, inverseQ to get the values from the privatekey.xml file
            ModulusTextBox.Text = xmlReader.GetValueFromXmlFile("Modulus", publicKeyPath);
            ExponentTextBox.Text = xmlReader.GetValueFromXmlFile("Exponent", publicKeyPath);
            DTextBox.Text = xmlReader.GetValueFromXmlFile("D", privateKeyPath);
            PTextBox.Text = xmlReader.GetValueFromXmlFile("P", privateKeyPath);
            DPTextBox.Text = xmlReader.GetValueFromXmlFile("DP", privateKeyPath);
            QTextBox.Text = xmlReader.GetValueFromXmlFile("Q", privateKeyPath);
            InverseQTextBox.Text = xmlReader.GetValueFromXmlFile("InverseQ", privateKeyPath);
        }
        // DecryptButton which will run the DecryptData method on the cipherText and return the decrypted message to a textBox
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string privateKeyPath = rsa.GetPrivateKeyPath();

            byte[] cipherText = Convert.FromBase64String(CipherTextBox.Text);

            byte[] decryptedMessage = rsa.DecryptData(privateKeyPath, cipherText);

            DecryptedTextBox.Text = Encoding.Default.GetString(decryptedMessage);
        }
    }
}
