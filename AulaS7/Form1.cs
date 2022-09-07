using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyModbus;

namespace AulaS7
{
    public partial class Form1 : Form
    {
        public ModbusClient cliente = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente == null)
                {
                    string ip = "192.168.0.139";
                    int Port = 502;
                    cliente = new ModbusClient(ip, Port);
                    cliente.Connect();                    
                }
                else
                {
                    cliente.Disconnect();
                    cliente = null;
                }
            }
            catch (Exception ex)
            {
                cliente = null;
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK);                
            }

            if (cliente == null)
            {
                timer1.Stop();
                button1.BackColor = this.BackColor;
                button1.Text = "conectar";
            }
            else
            {
                timer1.Start();
                button1.BackColor = Color.Green;
                button1.Text = "desconectar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cliente != null && cliente.Connected)
            {
                int MN = cliente.ReadInputRegisters(0, 1)[0];
                txtMN.Text = MN.ToString();
                desenhaTanque(MN);

                int MN2 = cliente.ReadInputRegisters(2, 1)[0];
                txtMN2.Text = MN2.ToString();
                desenhaTanque2(MN2);

                int MN3 = cliente.ReadInputRegisters(4, 1)[0];
                txtMN3.Text = MN3.ToString();
                desenhaTanque3(MN3);

                int VE = (int)numVE.Value;
                cliente.WriteSingleRegister(0, VE);
                cliente.WriteSingleRegister(2, VE);
                cliente.WriteSingleRegister(4, VE);

                int VS = (int)numVS.Value;
                cliente.WriteSingleRegister(1, VS);
                cliente.WriteSingleRegister(3, VS);
                cliente.WriteSingleRegister(5, VS);

            }
        }

        private void desenhaTanque(float valor)
        {
            int sx = tank.Width;
            int sy = tank.Height;
            Bitmap bmp = new Bitmap(sx, sy);
            Graphics gp = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, sx);
            int px = sx/2;
            float hy = (float)sy * (valor/1000f);
            gp.DrawLine(pen, px, sy, px, sy - hy);
            tank.Image = bmp;
        }
        private void desenhaTanque2(float valor)
        {
            int sx = tank2.Width;
            int sy = tank2.Height;
            Bitmap bmp = new Bitmap(sx, sy);
            Graphics gp = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, sx);
            int px = sx / 2;
            float hy = (float)sy * (valor / 1000f);
            gp.DrawLine(pen, px, sy, px, sy - hy);
            tank2.Image = bmp;
        }
        private void desenhaTanque3(float valor)
        {
            int sx = tank3.Width;
            int sy = tank3.Height;
            Bitmap bmp = new Bitmap(sx, sy);
            Graphics gp = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, sx);
            int px = sx / 2;
            float hy = (float)sy * (valor / 1000f);
            gp.DrawLine(pen, px, sy, px, sy - hy);
            tank3.Image = bmp;
        }
    }
}
