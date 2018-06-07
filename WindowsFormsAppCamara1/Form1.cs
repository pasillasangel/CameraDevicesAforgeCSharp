using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;

namespace WindowsFormsAppCamara1
{
    public partial class Form1 : Form
    {
        int count = 0;
        Camera myCamera = new Camera();

        public Form1()
        {
            InitializeComponent();

            GetInfo();

            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
        }

        private void GetInfo()
        {
            var CameraDevices = myCamera.GetCameraSources();
            var CameraResolutions = myCamera.GetSupportedResolutions();

            foreach (var d in CameraDevices)
                cmbCameraDevices.Items.Add(d);

            foreach (var r in CameraResolutions)
                cmbCameraResolutions.Items.Add(r);

            cmbCameraDevices.SelectedIndex = 0;
            cmbCameraResolutions.SelectedIndex = 0;
        }

        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            picCamera.Image = img;
        }

        private void cmbCameraDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(cmbCameraDevices.SelectedIndex);
        }

        private void cmbCameraResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(cmbCameraResolutions.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            myCamera.Capture(filename);
            count++;
        }
    }
}
