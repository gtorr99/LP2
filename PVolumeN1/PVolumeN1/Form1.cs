using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolumeN1
{
    public partial class Form1 : Form
    {
        private double _raio;
        private double _altura;
        private double _volume;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtRaio_Validated(sender, e) && TxtAltura_Validated(sender, e))
            {
                _volume = Math.PI * Math.Pow(_raio, 2) * _altura;
                txtVolume.Text = _volume.ToString("N2");
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean TxtRaio_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtRaio.Text, out _raio))
            {
                MessageBox.Show("Raio Inválido!");
                txtRaio.Focus();
                return false;
            }

            if (_raio < 1)
            {
                MessageBox.Show("Raio deve ser maior que zero!");
                txtRaio.Focus();
                return false;
            }

            return true;
        } 
        
        private Boolean TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out _altura))
            {
                MessageBox.Show("Altura Inválida!");
                txtAltura.Focus();
                return false;
            }

            if (_altura < 1)
            {
                MessageBox.Show("Altura deve ser maior que zero!");
                txtAltura.Focus();
                return false;
            }

            return true;
        }       
       
    }
}
