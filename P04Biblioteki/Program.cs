﻿using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Biblioteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //  new XRect(0, 0, page.Width, page.Height),
            //  XStringFormats.Center);

            gfx.DrawString("ala", font, XBrushes.Aqua, 40, 100);



            // Save the document...
            const string filename = "HelloWorld2.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);

        }
    }
}
