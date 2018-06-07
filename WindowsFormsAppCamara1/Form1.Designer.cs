namespace WindowsFormsAppCamara1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCameraDevices = new System.Windows.Forms.ComboBox();
            this.cmbCameraResolutions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picCamera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCameraDevices
            // 
            this.cmbCameraDevices.FormattingEnabled = true;
            this.cmbCameraDevices.Location = new System.Drawing.Point(196, 27);
            this.cmbCameraDevices.Name = "cmbCameraDevices";
            this.cmbCameraDevices.Size = new System.Drawing.Size(317, 21);
            this.cmbCameraDevices.TabIndex = 0;
            this.cmbCameraDevices.SelectedIndexChanged += new System.EventHandler(this.cmbCameraDevices_SelectedIndexChanged);
            // 
            // cmbCameraResolutions
            // 
            this.cmbCameraResolutions.FormattingEnabled = true;
            this.cmbCameraResolutions.Location = new System.Drawing.Point(196, 76);
            this.cmbCameraResolutions.Name = "cmbCameraResolutions";
            this.cmbCameraResolutions.Size = new System.Drawing.Size(317, 21);
            this.cmbCameraResolutions.TabIndex = 1;
            this.cmbCameraResolutions.SelectedIndexChanged += new System.EventHandler(this.cmbCameraResolutions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera Devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolutions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picCamera
            // 
            this.picCamera.Location = new System.Drawing.Point(31, 135);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(757, 314);
            this.picCamera.TabIndex = 5;
            this.picCamera.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCameraResolutions);
            this.Controls.Add(this.cmbCameraDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCameraDevices;
        private System.Windows.Forms.ComboBox cmbCameraResolutions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picCamera;
    }
}

