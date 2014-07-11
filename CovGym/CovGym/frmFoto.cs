﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace CovGym
{
    public partial class frmFoto : Form
    {
        string ruta;
        frmClientes cli = new frmClientes();
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public frmFoto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }
        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;


        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            ruta = Path.Combine(@"C:\archivos", "foto" + cli.txtClave.Text + ".png");
            EspacioCamara.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void frmFoto_Load(object sender, EventArgs e)
        {
            FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
            FuenteDeVideo.Start();
            groupBox1.Text = DispositivoDeVideo[cbxDispositivos.SelectedIndex].Name.ToString();
        }
    }
}