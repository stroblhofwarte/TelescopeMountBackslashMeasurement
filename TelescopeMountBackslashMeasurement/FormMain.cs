/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * Some code used from:
 * PictureBox, JohnWillemse <https://www.codeproject.com/Articles/21097/PictureBox-Zoom>
 * 30 Oct 2007, CPOL
 *
 * 
 * 
 * 
 * 
 * 
 */

using ASCOM.DriverAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelescopeMountBackslashMeasurement
{
    public partial class FormMain : Form
    {
        #region Properties

        private string _cameraId = "ASCOM.Simulator.Camera";
        private string _mountId = "";
        private Camera _camera = null;
        private Telescope _mount = null;
        private double _exposure = 0.01;
        private int _stretchFactor = 256;
        private double _resolution = 0.0;

        private int _ZoomFactor = 5;
        private Color _BackColor;
        private Image _OriginalImage = null;
        private Image _WorkingImage = null;

        private Point _referencePoint;
        private Point _measurePoint;
        private bool _referenceSet = false;
        private bool _measureSet = false;
        #endregion

        #region Colors

        private Color _textboxBnormal = Color.Silver;
        private Color _textboxBerror = Color.LightSalmon;

        #endregion
        public FormMain()
        {
            InitializeComponent();
            panelScrollArea.Controls.Add(picImage);
            UpdateAscomDeviceLabels();
            backgroundWorkerExposure.DoWork += BackgroundWorkerExposure_DoWork;

            //_ZoomFactor = trbZoomFactor.Value;
            _BackColor = picImage.BackColor;

            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picZoom.SizeMode = PictureBoxSizeMode.StretchImage;

            // Reload settings
            _exposure = (double)Properties.Settings.Default["LastExposure"];
            textBoxExposure.Text = _exposure.ToString(System.Globalization.CultureInfo.InvariantCulture);
            _cameraId = Properties.Settings.Default["CameraId"].ToString();
            _mountId = Properties.Settings.Default["MountId"].ToString();

            UpdateAscomDeviceLabels();
            EnableCameraControls(false);
            _OriginalImage = Bitmap.FromFile("Beteigeuze_Spectrum_-20.00_0.30s_0000.png");
            _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
            ResizeAndDisplayImage();
        }

        #region ASCOM
        private void EnableCameraControls(bool en)
        {
            checkBoxLoop.Enabled = en;
            textBoxExposure.Enabled = en;
            buttonExposure.Enabled = en;
            if (en)
            {
                _resolution = PixelResolution();
                labelPixelsize.Text = _camera.PixelSizeX.ToString(System.Globalization.CultureInfo.InvariantCulture) + " µm";
            }
            else
            {
                labelPixelsize.Text = "...";
            }
        }

        private double PixelResolution()
        {
            if (_mount == null) return 0.0;
            if (_camera == null) return 0.0;
            if (!_mount.Connected) return 0.0;
            if (!_camera.Connected) return 0.0;
            double focallength = _mount.FocalLength * 1000;
            double pixelsize = _camera.PixelSizeX; 
            double resolution =  (pixelsize / focallength) * 206.265;
            labelResolution.Text = resolution.ToString(System.Globalization.CultureInfo.InvariantCulture) + "''/pixel";
            return resolution;
        }
        private void EnableMountControls(bool en)
        {
            if(en)
            {
                labelFocallength.Text = (_mount.FocalLength * 1000).ToString(System.Globalization.CultureInfo.InvariantCulture) + " mm";
                labelDiameter.Text = (_mount.ApertureDiameter * 1000).ToString(System.Globalization.CultureInfo.InvariantCulture) + " mm";
                _resolution = PixelResolution();
            }
            else
            {
                labelFocallength.Text = "...";
                labelDiameter.Text = "...";
                labelResolution.Text = "...";
            }
        }
        private void UpdateAscomDeviceLabels()
        {
            string visibleText = _cameraId;
            if (visibleText.Length > 32)
                visibleText = visibleText.Substring(0, 32) + "...";
            labelCamera.Text = visibleText;

            visibleText = _mountId;
            if (visibleText.Length > 32)
                visibleText = visibleText.Substring(0, 32) + "...";
            labelMount.Text = visibleText;
        }

        private void buttonChooseCamera_Click(object sender, EventArgs e)
        {
            _cameraId = Camera.Choose(_cameraId);
            UpdateAscomDeviceLabels();
            Properties.Settings.Default["CameraId"] = _cameraId;
            Properties.Settings.Default.Save();
            
        }

        private void buttonChooseMount_Click(object sender, EventArgs e)
        {
            _mountId = Telescope.Choose(_mountId);
            UpdateAscomDeviceLabels();
            Properties.Settings.Default["MountId"] = _mountId;
            Properties.Settings.Default.Save();

        }
        private void buttonCameraConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_camera == null)
                {
                    _camera = new Camera(_cameraId);
                    _camera.Connected = true;
                    if (_camera.Connected)
                    {
                        this.buttonCameraConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.On;
                        _stretchFactor = (_camera.MaxADU / 256) + 1;
                        EnableCameraControls(true);
                    }
                    else
                    {
                        EnableCameraControls(false);
                        _camera.Dispose();
                        _camera = null;
                    }
                }
                else
                {
                    _camera.Connected = false;
                    _camera.Dispose();
                    _camera = null;
                    this.buttonCameraConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
                    EnableCameraControls(false);
                }
            } catch (Exception ex)
            {
                if (_camera != null)
                    _camera.Dispose();
                _camera = null;
                this.buttonCameraConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
                EnableCameraControls(false);
            }
        }

        private void buttonMountConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mount == null)
                {
                    _mount = new Telescope(_mountId);
                    _mount.Connected = true;
                    if (_mount.Connected)
                    {
                        this.buttonMountConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.On;
                        EnableMountControls(true);
                    }
                    else
                    {
                        EnableMountControls(false);
                        _mount.Dispose();
                        _mount = null;
                    }
                }
                else
                {
                    _mount.Connected = false;
                    _mount.Dispose();
                    _mount = null;
                    this.buttonMountConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
                    EnableMountControls(false);
                }
            } catch (Exception ex)
            {
                if (_mount != null)
                    _mount.Dispose();
                _mount = null;
                this.buttonMountConnect.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Off;
                EnableMountControls(false);
            }
        }

        #endregion

        #region Camera Image
        private void DisplayImage(int[,] array)
        {
            int w = array.GetUpperBound(0) + 1;
            int h = array.GetUpperBound(1) + 1;
            _OriginalImage = fromTwoDimIntArrayGray(array);
            _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
            ResizeAndDisplayImage();
        }

        // Conversion from array to bitmap: some code from Nyerguds, <https://stackoverflow.com/questions/49046376/turning-int-array-into-bmp-in-c-sharp>
        public Bitmap fromTwoDimIntArrayGray(Int32[,] data)
        {
            Int32 width = data.GetLength(0);
            Int32 height = data.GetLength(1);
            Int32 stride = width * 4;
            Int32 byteIndex = 0;
            Byte[] dataBytes = new Byte[height * stride];
            for (Int32 y = 0; y < height; y++)
            {
                for (Int32 x = 0; x < width; x++)
                {
                    // UInt32 0xAARRGGBB = Byte[] { BB, GG, RR, AA }
                    Byte val = (Byte)(((UInt32)data[x, y]) / _stretchFactor);
                    // This code clears out everything but a specific part of the value
                    // and then shifts the remaining piece down to the lowest byte
                    dataBytes[byteIndex + 0] = val; // B
                    dataBytes[byteIndex + 1] = val; // G
                    dataBytes[byteIndex + 2] = val; // R
                    dataBytes[byteIndex + 3] = 255; // A
                                                                                 // More efficient than multiplying
                    byteIndex += 4;
                }
            }
            return BuildImage(dataBytes, width, height, stride, PixelFormat.Format32bppArgb, null, null);
        }

        public Bitmap BuildImage(Byte[] sourceData, Int32 width, Int32 height, Int32 stride, PixelFormat pixelFormat, Color[] palette, Color? defaultColor)
        {
            Bitmap newImage = new Bitmap(width, height, pixelFormat);
            BitmapData targetData = newImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, newImage.PixelFormat);
            Int32 newDataWidth = ((Image.GetPixelFormatSize(pixelFormat) * width) + 7) / 8;
            // Compensate for possible negative stride on BMP format.
            Boolean isFlipped = stride < 0;
            stride = Math.Abs(stride);
            // Cache these to avoid unnecessary getter calls.
            Int32 targetStride = targetData.Stride;
            Int64 scan0 = targetData.Scan0.ToInt64();
            for (Int32 y = 0; y < height; y++)
                Marshal.Copy(sourceData, y * stride, new IntPtr(scan0 + y * targetStride), newDataWidth);
            newImage.UnlockBits(targetData);
            // Fix negative stride on BMP format.
            if (isFlipped)
                newImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            // For indexed images, set the palette.
            if ((pixelFormat & PixelFormat.Indexed) != 0 && palette != null)
            {
                ColorPalette pal = newImage.Palette;
                for (Int32 i = 0; i < pal.Entries.Length; i++)
                {
                    if (i < palette.Length)
                        pal.Entries[i] = palette[i];
                    else if (defaultColor.HasValue)
                        pal.Entries[i] = defaultColor.Value;
                    else
                        break;
                }
                newImage.Palette = pal;
            }
            return newImage;
        }

        private void BackgroundWorkerExposure_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_camera == null) return;
            if (!_camera.Connected) return;
            this.Invoke((MethodInvoker)delegate
            {
                this.buttonExposure.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Stop;
            });
            _camera.StartExposure(_exposure, true);
            while (!_camera.ImageReady)
            {
                Thread.Sleep(50);
            }
            int[,] imgArray = (int[,])_camera.ImageArray;
            this.Invoke((MethodInvoker)delegate
            {
                this.buttonExposure.Image = global::TelescopeMountBackslashMeasurement.Properties.Resources.Exposure;
                DisplayImage(imgArray);
            });
            
        }

        private void buttonExposure_Click(object sender, EventArgs e)
        {
            string expTime = textBoxExposure.Text;
            expTime = expTime.Replace(",", ".");
            textBoxExposure.Text = expTime;
            if (!double.TryParse(expTime, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out _exposure))
            {
                textBoxExposure.BackColor = _textboxBerror;
                return;
            }
            textBoxExposure.BackColor = _textboxBnormal;
            Properties.Settings.Default["LastExposure"] = _exposure;
            Properties.Settings.Default.Save();
            backgroundWorkerExposure.RunWorkerAsync();
        }
        #endregion

        #region Private Methods from PictureBox

        /// <summary>
        /// Resizes the image stored in _OriginalImage to fit in picImage,
        /// maintaining the aspect ratios and displays it.
        /// </summary>
        private void ResizeAndDisplayImage()
        {
            // Set the backcolor of the pictureboxes
            picImage.BackColor = _BackColor;
            picZoom.BackColor = _BackColor;

            // If _OriginalImage is null, then return. This situation can occur
            // when a new backcolor is selected without an image loaded.
            if (_WorkingImage == null)
                return;

            picImage.Image = _WorkingImage;

            Graphics gr = Graphics.FromImage(_WorkingImage);
            gr.CompositingMode = CompositingMode.SourceCopy;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            Pen referencePen = new Pen(new SolidBrush(Color.Yellow));
            Pen measurePen = new Pen(new SolidBrush(Color.Green));
            if (_referenceSet)
            {
                gr.DrawLine(referencePen, (int)_referencePoint.X, 0, (int)_referencePoint.X, picImage.Image.Height);
                gr.DrawLine(referencePen, 0, (int)_referencePoint.Y, picImage.Image.Width, (int)_referencePoint.Y);
            }
            if (_measureSet)
            {
                gr.DrawLine(measurePen, (int)_measurePoint.X, 0, (int)_measurePoint.X, picImage.Image.Height);
                gr.DrawLine(measurePen, 0, (int)_measurePoint.Y, picImage.Image.Width, (int)_measurePoint.Y);

            }
            gr.Dispose();
            return;
            // sourceWidth and sourceHeight store the original image's width and height
            // targetWidth and targetHeight are calculated to fit into the picImage picturebox.
            int sourceWidth = _WorkingImage.Width;
            int sourceHeight = _WorkingImage.Height;
            int targetWidth;
            int targetHeight;
            double ratio;

            // Calculate targetWidth and targetHeight, so that the image will fit into
            // the picImage picturebox without changing the proportions of the image.
            if (sourceWidth > sourceHeight)
            {
                // Set the new width
                targetWidth = picImage.Width;
                // Calculate the ratio of the new width against the original width
                ratio = (double)targetWidth / sourceWidth;
                // Calculate a new height that is in proportion with the original image
                targetHeight = (int)(ratio * sourceHeight);
            }
            else if (sourceWidth < sourceHeight)
            {
                // Set the new height
                targetHeight = picImage.Height;
                // Calculate the ratio of the new height against the original height
                ratio = (double)targetHeight / sourceHeight;
                // Calculate a new width that is in proportion with the original image
                targetWidth = (int)(ratio * sourceWidth);
            }
            else
            {
                // In this case, the image is square and resizing is easy
                targetHeight = picImage.Height;
                targetWidth = picImage.Width;
            }

            // Calculate the targetTop and targetLeft values, to center the image
            // horizontally or vertically if needed
            int targetTop = (picImage.Height - targetHeight) / 2;
            int targetLeft = (picImage.Width - targetWidth) / 2;

            // Create a new temporary bitmap to resize the original image
            // The size of this bitmap is the size of the picImage picturebox.
            Bitmap tempBitmap = new Bitmap(picImage.Width, picImage.Height, PixelFormat.Format32bppRgb);

            // Set the resolution of the bitmap to match the original resolution.
            tempBitmap.SetResolution(_WorkingImage.HorizontalResolution, _WorkingImage.VerticalResolution);

            // Create a Graphics object to further edit the temporary bitmap
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);

            // First clear the image with the current backcolor
            bmGraphics.Clear(_BackColor);

            // Set the interpolationmode since we are resizing an image here
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the original image on the temporary bitmap, resizing it using
            // the calculated values of targetWidth and targetHeight.
            bmGraphics.DrawImage(_WorkingImage,
                                 new Rectangle(targetLeft, targetTop, targetWidth, targetHeight),
                                 new Rectangle(0, 0, sourceWidth, sourceHeight),
                                 GraphicsUnit.Pixel);

            // Dispose of the bmGraphics object
            bmGraphics.Dispose();

            // Set the image of the picImage picturebox to the temporary bitmap
            picImage.Image = tempBitmap;
        }

        /// <summary>
        /// Updates the picZoom image to show the portion of the main image
        /// the mouse is currently over.
        /// </summary>
        private void UpdateZoomedImage(MouseEventArgs e)
        {
            // Calculate the width and height of the portion of the image we want
            // to show in the picZoom picturebox. This value changes when the zoom
            // factor is changed.
            int zoomWidth = picZoom.Width / _ZoomFactor;
            int zoomHeight = picZoom.Height / _ZoomFactor;

            // Calculate the horizontal and vertical midpoints for the crosshair
            // cursor and correct centering of the new image
            int halfWidth = zoomWidth / 2;
            int halfHeight = zoomHeight / 2;

            // Create a new temporary bitmap to fit inside the picZoom picturebox
            Bitmap tempBitmap = new Bitmap(zoomWidth, zoomHeight, PixelFormat.Format24bppRgb);

            // Create a temporary Graphics object to work on the bitmap
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);

            // Clear the bitmap with the selected backcolor
            bmGraphics.Clear(_BackColor);

            // Set the interpolation mode
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the portion of the main image onto the bitmap
            // The target rectangle is already known now.
            // Here the mouse position of the cursor on the main image is used to
            // cut out a portion of the main image.
            double ratioX = (double)_WorkingImage.Width / (double)picImage.Width;
            double ratioY = (double)_WorkingImage.Height / (double)picImage.Height;
            bmGraphics.DrawImage(_WorkingImage,
                                 new Rectangle(0, 0, zoomWidth, zoomHeight),
                                 new Rectangle((int)((double)e.X*ratioX) - halfWidth, (int)((double)e.Y*ratioY) - halfHeight, zoomWidth, zoomHeight),
                                 GraphicsUnit.Pixel);

            // Draw the bitmap on the picZoom picturebox
            picZoom.Image = tempBitmap;

            // Draw a crosshair on the bitmap to simulate the cursor position
            bmGraphics.DrawLine(Pens.Green, halfWidth + 1, halfHeight - 4, halfWidth + 1, halfHeight - 1);
            bmGraphics.DrawLine(Pens.Green, halfWidth + 1, halfHeight + 6, halfWidth + 1, halfHeight + 3);
            bmGraphics.DrawLine(Pens.Green, halfWidth - 4, halfHeight + 1, halfWidth - 1, halfHeight + 1);
            bmGraphics.DrawLine(Pens.Green, halfWidth + 6, halfHeight + 1, halfWidth + 3, halfHeight + 1);

            // Dispose of the Graphics object
            bmGraphics.Dispose();

            // Refresh the picZoom picturebox to reflect the changes
            picZoom.Refresh();
        }

        #endregion // Private Methods

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            // If no picture is loaded, return
            if (picImage.Image == null)
                return;

            UpdateZoomedImage(e);
        }

        private void trbZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            _ZoomFactor = trbZoomFactor.Value;
            lblZoomFactor.Text = string.Format("x{0}", _ZoomFactor);
        }

        private void picImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (!checkBoxSetReference.Checked && !checkBoxMeasure.Checked) return;
            _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
            double ratioX = (double)_WorkingImage.Width / (double)picImage.Width;
            double ratioY = (double)_WorkingImage.Height / (double)picImage.Height;
         
            double orginalX = ((double)e.X * ratioX)+1.0;
            double orginalY = ((double)e.Y * ratioY) + 1.0;

            if (checkBoxMeasure.Checked)
            { 
                _measurePoint = new Point((int)orginalX, (int)orginalY);
                _measureSet = true;
                checkBoxMeasure.Checked = false;

                double dx = _referencePoint.X - _measurePoint.X;
                double dy = _referencePoint.Y - _measurePoint.Y;
                double pixeldifference = Math.Sqrt((dx * dx) + (dy * dy));
                double arcsec = pixeldifference * _resolution;
                double arcsecRA = dx * _resolution;
                double arcsecDEC = dy * _resolution;
                labelDiff.Text = arcsec.ToString(System.Globalization.CultureInfo.InvariantCulture) + "''";
                labelDiffRA.Text = arcsecRA.ToString(System.Globalization.CultureInfo.InvariantCulture) + "''";
                labelDiffDEC.Text = arcsecDEC.ToString(System.Globalization.CultureInfo.InvariantCulture) + "''";
            }
            if(checkBoxSetReference.Checked)
            {
                _referencePoint = new Point((int)orginalX, (int)orginalY);
                _referenceSet = true;
                checkBoxSetReference.Checked = false;
            }
            ResizeAndDisplayImage();
        }

        private void checkBoxSetReference_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSetReference.Checked)
            {
                _referenceSet = false;
                _measureSet = false;
                _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
                ResizeAndDisplayImage();

            }
        }

        private void buttonRABackslash_Click(object sender, EventArgs e)
        {
            if (_mount == null) return;
            if (_mount.Connected == false) return;
            if (_mount.CanUnpark)
                _mount.Unpark();
            _mount.Tracking = false;
            double alt = _mount.Altitude;
            double az = _mount.Azimuth;
            _mount.SlewToAltAz(az + 1.0, alt + 1.0);
            _mount.SlewToAltAz(az, alt);
        }
    }
}
