using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControlLibrary;

namespace VoorbeeldICT1
{
    public partial class Form1 : Form
    {

        CCAdvertentieToevoegen ccAdvertentieToevoegen;
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
#region velden 
            //ccAdvertentieToevoegen.AddAdvertentie(
            //    tbAdvertentieNaam.Text,
            //    tbAdvertentieMedium.Text,
            //    tbAdvertentieContent.Text,
            //    tbAdvertentieOntwerper.Text);
#endregion
            Dictionary<string, string> data = new Dictionary<string, string>();
            vullen(data);
            ccAdvertentieToevoegen.AddAdvertentie(data);
            
        }

        private void vullen(Dictionary<string, string> data)
        {
            foreach (Control c in this.Controls)
            {
                string zoek = "tbAdvertentie";
                if (c is TextBox)
                {
                    if ((c as TextBox).Name.Contains(zoek))
                    {
                        data.Add(
                            (c as TextBox).Name.Remove(0, zoek.Length),
                            (c as TextBox).Text);
                    }
                }
            }
        }



        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ccAdvertentieToevoegen = new CCAdvertentieToevoegen(
                tbKlantNaam.Text, tbCampagneNaam.Text);
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
