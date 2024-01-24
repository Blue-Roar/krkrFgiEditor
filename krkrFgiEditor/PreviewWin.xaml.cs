using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace krkrFgiEditor
{
    /// <summary>
    /// PreviewWin.xaml 的交互逻辑
    /// </summary>
    public partial class PreviewWin : Window
    {
        public PreviewWin()
        {
            InitializeComponent();
        }
        MainWin _mainWin = null;
        public void LoadCG(string layers, Image image, Boolean dynamic=false, MainWin mainWin=null)
        {
            try
            {
                Title = layers;
                menuItem_Title.Header = layers;

                if (image != null)
                {
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, ImageFormat.Png);
                    ImageBrush imageBrush = new ImageBrush();
                    ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
                    ImageCG.Source = (ImageSource)imageSourceConverter.ConvertFrom(stream);
                }
                else
                {
                    ImageCG.Source = null;
                }
                sld_zoomScale_ValueChanged(this, null);

                if (dynamic)
                {
                    menuItem_Close.Visibility = Visibility.Collapsed;
                    menuItem_Hide.Visibility = Visibility.Visible;
                    menuItem_Topmost.IsChecked = true;
                }
                if (mainWin != null)
                {
                    _mainWin = mainWin;
                }
                Show();
            }
            catch (Exception)
            {

            }
        }

        public void UpdateCG(Image image)
        {
            if (image != null)
            {
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Png);
                ImageBrush imageBrush = new ImageBrush();
                ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
                ImageCG.Source = (ImageSource)imageSourceConverter.ConvertFrom(stream);
            }
            else
            {
                ImageCG.Source = null;
            }
            sld_zoomScale_ValueChanged(this, null);
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            if (e.Delta > 0)
            {
                sld_zoomScale.Value++;
            }
            else if (e.Delta < 0)
            {
                sld_zoomScale.Value--;
            }
            sld_zoomScale_ValueChanged(this, null);
        }

        private void menuItem_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuItem_zoom25_Click(object sender, RoutedEventArgs e)
        {
            sld_zoomScale.Value = 25;
        }

        private void menuItem_zoom50_Click(object sender, RoutedEventArgs e)
        {
            sld_zoomScale.Value = 50;
        }

        private void menuItem_zoom75_Click(object sender, RoutedEventArgs e)
        {
            sld_zoomScale.Value = 75;
        }

        private void menuItem_zoom100_Click(object sender, RoutedEventArgs e)
        {
            sld_zoomScale.Value = 100;
        }

        private void sld_zoomScale_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int scale = (int)sld_zoomScale.Value;
            if (ImageCG.Source == null)
            {
                vb_img.Width = 512 * scale / 100;
                vb_img.Height = 512 * scale / 100;
            }
            else
            {
                vb_img.Width = ImageCG.Source.Width * scale / 100;
                vb_img.Height = ImageCG.Source.Height * scale / 100;
            }
            Width = vb_img.Width / matrixDPI.M11;
            Height = vb_img.Height / matrixDPI.M22;
        }

        private void sld_alpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Opacity = sld_alpha.Value / 100;
        }
        private void menuItem_alpha25_Click(object sender, RoutedEventArgs e)
        {
            sld_alpha.Value = 25;
        }

        private void menuItem_alpha50_Click(object sender, RoutedEventArgs e)
        {
            sld_alpha.Value = 50;
        }

        private void menuItem_alpha75_Click(object sender, RoutedEventArgs e)
        {
            sld_alpha.Value = 75;
        }

        private void menuItem_alpha100_Click(object sender, RoutedEventArgs e)
        {
            sld_alpha.Value = 100;
        }

        Matrix matrixDPI;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            matrixDPI = PresentationSource.FromVisual(this).CompositionTarget.TransformToDevice;
            ScaleTransform dpiTransform = new ScaleTransform(1 / matrixDPI.M11, 1 / matrixDPI.M22);
            if (dpiTransform.CanFreeze) dpiTransform.Freeze();
            vb_img.LayoutTransform = dpiTransform;
            Width = vb_img.Width / matrixDPI.M11;
            Height = vb_img.Height / matrixDPI.M22;
        }
                
        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (!menuItem_Fixed.IsChecked)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    DragMove();
                }
            }
        }

        private void menuItem_Hide_Click(object sender, RoutedEventArgs e)
        {
            _mainWin.SwapPreview();
        }

        private void textBox_BackColor_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (textBox_BackColor.Text.Length != 9) textBox_BackColor.Text = "#00FFFFFF";
            Background = (System.Windows.Media.Brush) new BrushConverter().ConvertFromString(textBox_BackColor.Text);
        }
    }
}
