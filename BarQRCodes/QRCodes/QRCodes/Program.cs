namespace QRCodes;
using System;
using QRCoder;

internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE      };
            //var result = writer.Write("Hello");
            //var barcodeBitmap = new Bitmap(result);
            //pictureBox1.Image = barcodeBitmap;
            // instantiate a writer object
        }
    }