﻿using P03AplikacjaZawodnicy.Domain;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Services
{
    internal class PDFManager
    {
        private readonly string sciezka;

        public PDFManager(string sciezka)
        {
            this.sciezka = sciezka;
        }

        public void WygenerujPDF(Zawodnik[] zawodnicy)
        {       
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Raport zawodnicy";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            for (int i = 0; i < zawodnicy.Length; i++)
                gfx.DrawString(zawodnicy[i].DaneRaportowe, font, XBrushes.Aqua, 40, 50 + 25*i);

            document.Save(sciezka);
            // ...and start a viewer.


        }
    }
}
