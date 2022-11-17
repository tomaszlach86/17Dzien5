﻿using P03AplikacjaZawodnicy.Domain;
using P03AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {

        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            lblDane.Items.Clear();
            
            mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
            mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy = mz.PodajZawodnikow(txtKraj.Text);

            foreach (var z in zawodnicy)
            {
                lblDane.Items.Add(z.Imie + " " + z.Nazwisko);
            }

        }

        private void lblDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczony = Convert.ToString(lblDane.SelectedItem);

            MessageBox.Show(zaznaczony);

            // propozycja rozwiazania:
            // sprawdzamy, która pozycja na liście jest zaznaczona.
            // nastepnie na liscie naszych zawodnikow szukamy zawodnika o podanym indeksie 
            int zaznaczonaPozycja = lblDane.SelectedIndex;
            //ManagerZawodnikow mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
            //mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy = mz.Zawodnicy;
            Zawodnik zaznaczonyZawodnik = zawodnicy[zaznaczonaPozycja];

            // wady: po 1) nie potrzebnie wywolujemy ponowne odwolanie się do pliku źródłowego 
            // ta wada zsotała rozwiazania poprzez wyniesienie ManagerZawodnikow
            // do ciała klasy i w tym momencie obydwie metody korzystaja 
            // z tego samego obiektu (ManagerZawodnikow). A ManagerZawodnikow
            // posisada z cachowaną listę zawodnikow 

            // wada nr 2) 
        }
    }
}