
namespace TelescopeMountBackslashMeasurement
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonChooseCamera = new System.Windows.Forms.Button();
            this.labelCamera = new System.Windows.Forms.Label();
            this.textBoxExposure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerExposure = new System.ComponentModel.BackgroundWorker();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.buttonExposure = new System.Windows.Forms.Button();
            this.buttonCameraConnect = new System.Windows.Forms.Button();
            this.buttonMountConnect = new System.Windows.Forms.Button();
            this.labelMount = new System.Windows.Forms.Label();
            this.buttonChooseMount = new System.Windows.Forms.Button();
            this.trbZoomFactor = new System.Windows.Forms.TrackBar();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.labelFocallength = new System.Windows.Forms.Label();
            this.labelPixelsize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSetReference = new System.Windows.Forms.CheckBox();
            this.checkBoxMeasure = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.panelScrollArea = new System.Windows.Forms.Panel();
            this.buttonRABackslash = new System.Windows.Forms.Button();
            this.labelDiffRA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDiffDEC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).BeginInit();
            this.panelScrollArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChooseCamera
            // 
            this.buttonChooseCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonChooseCamera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCamera.Location = new System.Drawing.Point(700, 29);
            this.buttonChooseCamera.Name = "buttonChooseCamera";
            this.buttonChooseCamera.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseCamera.TabIndex = 0;
            this.buttonChooseCamera.Text = "...";
            this.buttonChooseCamera.UseVisualStyleBackColor = false;
            this.buttonChooseCamera.Click += new System.EventHandler(this.buttonChooseCamera_Click);
            // 
            // labelCamera
            // 
            this.labelCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCamera.AutoSize = true;
            this.labelCamera.Location = new System.Drawing.Point(517, 34);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCamera.Size = new System.Drawing.Size(177, 13);
            this.labelCamera.TabIndex = 1;
            this.labelCamera.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // textBoxExposure
            // 
            this.textBoxExposure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBoxExposure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExposure.Location = new System.Drawing.Point(13, 54);
            this.textBoxExposure.Name = "textBoxExposure";
            this.textBoxExposure.Size = new System.Drawing.Size(100, 15);
            this.textBoxExposure.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure [s]:";
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(13, 81);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLoop.TabIndex = 5;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // picZoom
            // 
            this.picZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picZoom.Location = new System.Drawing.Point(520, 424);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(268, 238);
            this.picZoom.TabIndex = 8;
            this.picZoom.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(13, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(363, 530);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            this.picImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseClick);
            this.picImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseMove);
            // 
            // buttonExposure
            // 
            this.buttonExposure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonExposure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExposure.ForeColor = System.Drawing.Color.Silver;
            this.buttonExposure.Image = ((System.Drawing.Image)(resources.GetObject("buttonExposure.Image")));
            this.buttonExposure.Location = new System.Drawing.Point(13, 114);
            this.buttonExposure.Name = "buttonExposure";
            this.buttonExposure.Size = new System.Drawing.Size(100, 23);
            this.buttonExposure.TabIndex = 6;
            this.buttonExposure.UseVisualStyleBackColor = false;
            this.buttonExposure.Click += new System.EventHandler(this.buttonExposure_Click);
            // 
            // buttonCameraConnect
            // 
            this.buttonCameraConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCameraConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonCameraConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonCameraConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCameraConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
            this.buttonCameraConnect.Location = new System.Drawing.Point(748, 29);
            this.buttonCameraConnect.Name = "buttonCameraConnect";
            this.buttonCameraConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonCameraConnect.TabIndex = 2;
            this.buttonCameraConnect.UseVisualStyleBackColor = false;
            this.buttonCameraConnect.Click += new System.EventHandler(this.buttonCameraConnect_Click);
            // 
            // buttonMountConnect
            // 
            this.buttonMountConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMountConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonMountConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonMountConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMountConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
            this.buttonMountConnect.Location = new System.Drawing.Point(748, 75);
            this.buttonMountConnect.Name = "buttonMountConnect";
            this.buttonMountConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonMountConnect.TabIndex = 11;
            this.buttonMountConnect.UseVisualStyleBackColor = false;
            this.buttonMountConnect.Click += new System.EventHandler(this.buttonMountConnect_Click);
            // 
            // labelMount
            // 
            this.labelMount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMount.AutoSize = true;
            this.labelMount.Location = new System.Drawing.Point(517, 80);
            this.labelMount.Name = "labelMount";
            this.labelMount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMount.Size = new System.Drawing.Size(177, 13);
            this.labelMount.TabIndex = 10;
            this.labelMount.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // buttonChooseMount
            // 
            this.buttonChooseMount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonChooseMount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseMount.Location = new System.Drawing.Point(700, 75);
            this.buttonChooseMount.Name = "buttonChooseMount";
            this.buttonChooseMount.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseMount.TabIndex = 9;
            this.buttonChooseMount.Text = "...";
            this.buttonChooseMount.UseVisualStyleBackColor = false;
            this.buttonChooseMount.Click += new System.EventHandler(this.buttonChooseMount_Click);
            // 
            // trbZoomFactor
            // 
            this.trbZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trbZoomFactor.LargeChange = 1;
            this.trbZoomFactor.Location = new System.Drawing.Point(520, 373);
            this.trbZoomFactor.Maximum = 6;
            this.trbZoomFactor.Minimum = 2;
            this.trbZoomFactor.Name = "trbZoomFactor";
            this.trbZoomFactor.Size = new System.Drawing.Size(228, 45);
            this.trbZoomFactor.TabIndex = 12;
            this.trbZoomFactor.Value = 3;
            this.trbZoomFactor.ValueChanged += new System.EventHandler(this.trbZoomFactor_ValueChanged);
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Location = new System.Drawing.Point(754, 396);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(18, 13);
            this.lblZoomFactor.TabIndex = 13;
            this.lblZoomFactor.Text = "x3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Focal length:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Diameter:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resolution:";
            // 
            // labelResolution
            // 
            this.labelResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(609, 178);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(16, 13);
            this.labelResolution.TabIndex = 19;
            this.labelResolution.Text = "...";
            // 
            // labelDiameter
            // 
            this.labelDiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Location = new System.Drawing.Point(609, 160);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(16, 13);
            this.labelDiameter.TabIndex = 18;
            this.labelDiameter.Text = "...";
            // 
            // labelFocallength
            // 
            this.labelFocallength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFocallength.AutoSize = true;
            this.labelFocallength.Location = new System.Drawing.Point(609, 142);
            this.labelFocallength.Name = "labelFocallength";
            this.labelFocallength.Size = new System.Drawing.Size(16, 13);
            this.labelFocallength.TabIndex = 17;
            this.labelFocallength.Text = "...";
            // 
            // labelPixelsize
            // 
            this.labelPixelsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPixelsize.AutoSize = true;
            this.labelPixelsize.Location = new System.Drawing.Point(609, 196);
            this.labelPixelsize.Name = "labelPixelsize";
            this.labelPixelsize.Size = new System.Drawing.Size(16, 13);
            this.labelPixelsize.TabIndex = 21;
            this.labelPixelsize.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pixelsize:";
            // 
            // checkBoxSetReference
            // 
            this.checkBoxSetReference.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSetReference.AutoSize = true;
            this.checkBoxSetReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.checkBoxSetReference.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.checkBoxSetReference.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(119)))));
            this.checkBoxSetReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSetReference.Location = new System.Drawing.Point(13, 191);
            this.checkBoxSetReference.Name = "checkBoxSetReference";
            this.checkBoxSetReference.Size = new System.Drawing.Size(84, 23);
            this.checkBoxSetReference.TabIndex = 22;
            this.checkBoxSetReference.Text = "set Reference";
            this.checkBoxSetReference.UseVisualStyleBackColor = false;
            this.checkBoxSetReference.CheckedChanged += new System.EventHandler(this.checkBoxSetReference_CheckedChanged);
            // 
            // checkBoxMeasure
            // 
            this.checkBoxMeasure.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMeasure.AutoSize = true;
            this.checkBoxMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.checkBoxMeasure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.checkBoxMeasure.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(119)))));
            this.checkBoxMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMeasure.Location = new System.Drawing.Point(12, 283);
            this.checkBoxMeasure.Name = "checkBoxMeasure";
            this.checkBoxMeasure.Size = new System.Drawing.Size(57, 23);
            this.checkBoxMeasure.TabIndex = 23;
            this.checkBoxMeasure.Text = "measure";
            this.checkBoxMeasure.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Difference:";
            // 
            // labelDiff
            // 
            this.labelDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(609, 230);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(16, 13);
            this.labelDiff.TabIndex = 25;
            this.labelDiff.Text = "...";
            // 
            // panelScrollArea
            // 
            this.panelScrollArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScrollArea.AutoScroll = true;
            this.panelScrollArea.Controls.Add(this.picImage);
            this.panelScrollArea.Location = new System.Drawing.Point(119, 12);
            this.panelScrollArea.Name = "panelScrollArea";
            this.panelScrollArea.Size = new System.Drawing.Size(392, 650);
            this.panelScrollArea.TabIndex = 26;
            // 
            // buttonRABackslash
            // 
            this.buttonRABackslash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.buttonRABackslash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRABackslash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRABackslash.ForeColor = System.Drawing.Color.Silver;
            this.buttonRABackslash.Location = new System.Drawing.Point(12, 238);
            this.buttonRABackslash.Name = "buttonRABackslash";
            this.buttonRABackslash.Size = new System.Drawing.Size(100, 23);
            this.buttonRABackslash.TabIndex = 27;
            this.buttonRABackslash.Text = "move mount";
            this.buttonRABackslash.UseVisualStyleBackColor = false;
            this.buttonRABackslash.Click += new System.EventHandler(this.buttonRABackslash_Click);
            // 
            // labelDiffRA
            // 
            this.labelDiffRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiffRA.AutoSize = true;
            this.labelDiffRA.Location = new System.Drawing.Point(609, 248);
            this.labelDiffRA.Name = "labelDiffRA";
            this.labelDiffRA.Size = new System.Drawing.Size(16, 13);
            this.labelDiffRA.TabIndex = 29;
            this.labelDiffRA.Text = "...";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Difference RA:";
            // 
            // labelDiffDEC
            // 
            this.labelDiffDEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiffDEC.AutoSize = true;
            this.labelDiffDEC.Location = new System.Drawing.Point(609, 266);
            this.labelDiffDEC.Name = "labelDiffDEC";
            this.labelDiffDEC.Size = new System.Drawing.Size(16, 13);
            this.labelDiffDEC.TabIndex = 31;
            this.labelDiffDEC.Text = "...";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Difference DEC:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.labelDiffDEC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelDiffRA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRABackslash);
            this.Controls.Add(this.panelScrollArea);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxMeasure);
            this.Controls.Add(this.checkBoxSetReference);
            this.Controls.Add(this.labelPixelsize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelDiameter);
            this.Controls.Add(this.labelFocallength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZoomFactor);
            this.Controls.Add(this.trbZoomFactor);
            this.Controls.Add(this.buttonMountConnect);
            this.Controls.Add(this.labelMount);
            this.Controls.Add(this.buttonChooseMount);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.buttonExposure);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExposure);
            this.Controls.Add(this.buttonCameraConnect);
            this.Controls.Add(this.labelCamera);
            this.Controls.Add(this.buttonChooseCamera);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).EndInit();
            this.panelScrollArea.ResumeLayout(false);
            this.panelScrollArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseCamera;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.Button buttonCameraConnect;
        private System.Windows.Forms.TextBox textBoxExposure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Button buttonExposure;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExposure;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.Button buttonMountConnect;
        private System.Windows.Forms.Label labelMount;
        private System.Windows.Forms.Button buttonChooseMount;
        private System.Windows.Forms.TrackBar trbZoomFactor;
        private System.Windows.Forms.Label lblZoomFactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.Label labelFocallength;
        private System.Windows.Forms.Label labelPixelsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSetReference;
        private System.Windows.Forms.CheckBox checkBoxMeasure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Panel panelScrollArea;
        private System.Windows.Forms.Button buttonRABackslash;
        private System.Windows.Forms.Label labelDiffRA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDiffDEC;
        private System.Windows.Forms.Label label10;
    }
}

