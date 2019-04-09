using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Threading;

namespace RemaCHEM
{
    public partial class Form1 : Form
    {

        // łączenie z bazą danych na sztywno
        private string _connString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\Projects\\RemaGUM\\RemaGUM.mdb"; //połaczenie z bazą danych
         
        /// <summary>
        /// The rest
        /// </summary>
        private Rest _rest = new Rest();

        private ToolTip _tt;
        private byte[] _zawartoscPliku;
        private string _dirNazwa;

        public class settings
        {
            private string _XMLfile;
            private string _connectionString;   //connectionString
            private string _dBcopyFile;         //pełna ścieżka kopii bazy danych

            private int _copyInterval;          //interwał sporzadzania kopii bazy
            private string _dBhistoryDir;       //pełna nazwa katalogu historii bazy
            private int _historyInterval;       //interwał sprzadzania kopii w katalogu hsitorii bazy

            /// <summary>
            /// Konstruktor wymiany danych ustawień programu w XML.
            /// </summary>
            public settings()
            { }//settings

            /// <summary>
            /// Czyta plik.
            /// </summary>
            public void read()
            {
                read(_XMLfile);
            }//read

            /// <summary>
            /// Czyta plik.
            /// </summary>
            /// <param name="XMLfile">Nazwa pliku xml</param>
            public void read(string XMLfile)
            {
                _XMLfile = XMLfile;
                XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(XMLfile);
                XmlNode node = doc.FirstChild;

                while (node != null)
                {
                    node = node.NextSibling;
                    if (node.Name.ToUpper() == "settings".ToUpper())
                    {
                        node = node.FirstChild;
                        goto childNodes;
                    }
                }
                childNodes:;
                while (node != null)
                {
                    if (node.Name.ToUpper() == "ConnectionString".ToUpper()) _connectionString = node.InnerText;
                    if (node.Name.ToUpper() == "dBcopyFile".ToUpper()) _dBcopyFile = node.InnerText;
                    if (node.Name.ToUpper() == "copyInterval".ToUpper()) _copyInterval = int.Parse(node.InnerText);
                    if (node.Name.ToUpper() == "dBhistoryDir".ToUpper()) _dBhistoryDir = node.InnerText;
                    if (node.Name.ToUpper() == "historyInterval".ToUpper()) _historyInterval = int.Parse(node.InnerText);
                    node = node.NextSibling;
                }
            }//read

            /// <summary>
            /// Zapisuje do pliku.
            /// </summary>
            public void write()
            {
                try
                {
                    XmlTextWriter writer = new XmlTextWriter(_XMLfile, System.Text.Encoding.UTF8);
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();

                    writer.WriteStartElement("settings");

                    writer.WriteElementString("ConnectionString", _connectionString);

                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                catch
                {
                    MessageBox.Show("Error writing file", "RemaCHEM",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//write

            /// <summary>
            /// Connection string.
            /// </summary>
            public string connectionString
            {
                get { return _connectionString; }
                set { _connectionString = value; }
            }

            /// <summary>
            /// Connection string.
            /// </summary>
            public string XMLfile
            {
                get { return _XMLfile; }
                set { _XMLfile = value; }
            }

            /// <summary>
            /// Pełna ścieżka kopii bazy danych.
            /// </summary>
            public string dBcopyFile
            {
                get { return _dBcopyFile; }
                set { _dBcopyFile = value; }
            }

            /// <summary>
            /// Interwał w minutach sporzadzania kopii bazy danych.
            /// </summary>
            public int copyInterval
            {
                get { return _copyInterval; }
                set { _copyInterval = value; }
            }

            /// <summary>
            /// Pełna nazwa katalogu historii bazy.
            /// </summary>
            public string dBhistoryDir
            {
                get { return _dBhistoryDir; }
                set { _dBhistoryDir = value; }
            }

            /// <summary>
            /// Interwał w dniach sporządzania kopii bazy w katalogu historii.
            /// </summary>
            public int historyInterval
            {
                get { return _historyInterval; }
                set { _historyInterval = value; }
            }


        }//class settings






        public Form1()
        {
            InitializeComponent();
           


        }// Form1




        // // // // // // // // // // // // // // // // // // // // ZAKŁADKA PRZYRZĄD.

        /// <summary>
        /// Wypełnia danymi 
        /// </summary>
        private void WypelnijlistBoxPrzyrzady()
        {
            nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
            listBoxPrzyrzady.Items.Clear();
            przyrzadBUS.Select();

            while (!przyrzadBUS.eof)
            {
                listBoxPrzyrzady.Items.Add(przyrzadBUS.VO.Nazwa_przyrzadu);
                przyrzadBUS.skip();
            }
        }// WypelnijlistBoxPrzyrzady()

        private void OdswiezListePrzyrzadow()
        {
        }
        /// <summary>
        /// Czyści formularz Przyrząd
        /// </summary>
        private void CzyscDanePrzyrzadu()
        {
            toolStripStatusLabelPrzyrzadu.Text = "";

            textBoxNazwaPrzyrzadu.Text = string.Empty;
            textBoxTypPrzyrzadu.Text = string.Empty;
            textBoxRodzajPrzyrzadu.Text = string.Empty;
            textBoxNrfabrycznyPrzyrzadu.Text = string.Empty;
            textBoxNrSystemowyPrzyrzadu.Text = string.Empty;
            richTextBoxDaneProducentaPrzyrzadu.Text = string.Empty;
            dateTimePickerDataOstPrzegladuPrzyrzadu.Text = string.Empty;
            comboBoxOpiekunPrzyrzadu.Text = string.Empty;

            pictureBox.Image = null;


        }//CzyscDanePrzyrzadu()

        /// <summary>
        /// Obsługa zmiany indeksu listy Przyrządów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPrzyrzady_SelectedIndexChanged(object sender, EventArgs e)
        {
            nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);

            if (radioButtonNazwaPrzyrzadu.Checked)
            {
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nazwa_przyrzadu ASC;");
                przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
            }
            else if (radioButtonTypPrzyrzadu.Checked)
            {
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Typ_przyrzadu ASC;");
                przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
            }
            else if (radioButtonNrSystemowyPrzyrzadu.Checked)
            {
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nr_systemowy_przyrzadu ASC;");
                przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
            }
            else if (radioButtonOstatniPrzegladPrzyrzadu.Checked)
            {
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Data_ost_przeg_przyrzadu ASC;");
                przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
            }
            try
            {
                listBoxPrzyrzady.Tag = przyrzadBUS.VO.Identyfikator;
                toolStripStatusLabelPrzyrzadu.Text = przyrzadBUS.VO.Identyfikator.ToString();

                textBoxNazwaPrzyrzadu.Text = przyrzadBUS.VO.Nazwa_przyrzadu;
                textBoxTypPrzyrzadu.Text = przyrzadBUS.VO.Typ_przyrzadu;
                textBoxRodzajPrzyrzadu.Text = przyrzadBUS.VO.Rodzaj_przyrzadu;
                textBoxNrfabrycznyPrzyrzadu.Text = przyrzadBUS.VO.Nr_fabryczny_przyrzadu;
                textBoxNrSystemowyPrzyrzadu.Text = przyrzadBUS.VO.Nr_systemowy_przyrzadu;
                richTextBoxDaneProducentaPrzyrzadu.Text = przyrzadBUS.VO.Dane_producenta_przyrzadu;
                //data przechowywana w bazie jako rok mc i dzień
                dateTimePickerDataOstPrzegladuPrzyrzadu.Value = new DateTime(przyrzadBUS.VO.Rok_ost_przeg_przyrzadu, przyrzadBUS.VO.Mc_ost_przeg_przyrzadu, przyrzadBUS.VO.Dz_ost_przeg_przyrzadu);
                comboBoxOpiekunPrzyrzadu.Text = przyrzadBUS.VO.Opiekun_przyrzadu;

                if (File.Exists(przyrzadBUS.VO.Zdjecie_przyrzadu))
                {
                    File.Delete(przyrzadBUS.VO.Zdjecie_przyrzadu);
                }

                _zawartoscPliku = przyrzadBUS.VO.Zawartosc_pliku_zdj_przyrzadu; // zawartość zdjęcia.


            }
            catch { }
        }// listBoxPrzyrzady_SelectedIndexChanged

        // zdjęcie przyrządu

        private void PokazZdjeciePrzyrzadu(string ZdjeciePrzyrzadu)
        {
            try
            {
                if (!Directory.Exists(_dirNazwa))
                {
                    Directory.CreateDirectory(_dirNazwa);
                }
                nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);

                if (radioButtonNazwaPrzyrzadu.Checked)
                {
                    przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nazwa_przyrzadu ASC;");
                    przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
                    toolStripStatusLabelPrzyrzadu.Text = przyrzadBUS.VO.Identyfikator.ToString();
                }
                else if (radioButtonTypPrzyrzadu.Checked)
                {
                    przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Typ_przyrzadu ASC;");
                    przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
                    toolStripStatusLabelPrzyrzadu.Text = przyrzadBUS.VO.Identyfikator.ToString();
                }
                else if (radioButtonNrSystemowyPrzyrzadu.Checked)
                {
                    przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nr_systemowy_przyrzadu ASC;");
                    przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
                    toolStripStatusLabelPrzyrzadu.Text = przyrzadBUS.VO.Identyfikator.ToString();
                }
                else if (radioButtonOstatniPrzegladPrzyrzadu.Checked)
                {
                    przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Data_ost_przeg_przyrzadu ASC;");
                    przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
                    toolStripStatusLabelPrzyrzadu.Text = przyrzadBUS.VO.Identyfikator.ToString();
                }

                przyrzadBUS.idx = listBoxPrzyrzady.SelectedIndex;
                listBoxPrzyrzady.Tag = przyrzadBUS.VO.Identyfikator;

                nsDocInDb.docInDb docInDb = new nsDocInDb.docInDb();
                docInDb.dirNazwa = _dirNazwa;
                docInDb.zdjecieNazwa = przyrzadBUS.VO.Zdjecie_przyrzadu;
                docInDb.zapiszNaNaped(przyrzadBUS.VO.Zawartosc_pliku_zdj_przyrzadu);
                string zdjecie = _dirNazwa + "\\" + przyrzadBUS.VO.Zdjecie_przyrzadu;

                if (File.Exists(zdjecie))
                {
                    Bitmap bmp = (Bitmap)Bitmap.FromFile(zdjecie);
                    pictureBox.Image = Bitmap.FromFile(zdjecie);
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Brak wgranego zdjęcia przyrządu lub problem z prezentacją zdjęcia. Błąd: " + ex.Message, "RemaGUM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }//PokazZdjeciePrzyrzadu

        // Radio buttony
        private void radioButtonNazwaPrzyrzadu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNazwaPrzyrzadu.Checked)
            {
                listBoxPrzyrzady.Items.Clear();
                CzyscDanePrzyrzadu();

                nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nazwa_przyrzadu ASC;");

                while (!przyrzadBUS.eof)
                {
                    listBoxPrzyrzady.Items.Add(przyrzadBUS.VO.Nazwa_przyrzadu);
                    przyrzadBUS.skip();
                }
                if (listBoxPrzyrzady.Items.Count > 0)
                {
                    listBoxPrzyrzady.SelectedIndex = 0;
                }
            }
        }//radioButtonNazwaPrzyrzadu_CheckedChanged(object sender, EventArgs e)

        private void radioButtonTypPrzyrzadu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTypPrzyrzadu.Checked)
            {
                listBoxPrzyrzady.Items.Clear();
                CzyscDanePrzyrzadu();

                nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Typ_przyrzadu ASC;");

                while (!przyrzadBUS.eof)
                {
                    listBoxPrzyrzady.Items.Add(przyrzadBUS.VO.Nazwa_przyrzadu + " " + przyrzadBUS.VO.Typ_przyrzadu);
                    przyrzadBUS.skip();
                }
                if (listBoxPrzyrzady.Items.Count > 0)
                {
                    listBoxPrzyrzady.SelectedIndex = 0;
                }
            }
        }// radioButtonTypPrzyrzadu_CheckedChanged(object sender, EventArgs e)

        private void radioButtonOstatniPrzegladPrzyrzadu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOstatniPrzegladPrzyrzadu.Checked)
            {
                listBoxPrzyrzady.Items.Clear();
                CzyscDanePrzyrzadu();

                nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Data_ost_przeg_przyrzadu ASC;");

                while (!przyrzadBUS.eof)
                {
                    listBoxPrzyrzady.Items.Add(przyrzadBUS.VO.Nazwa_przyrzadu + " " + przyrzadBUS.VO.Dz_ost_przeg_przyrzadu + "-" + przyrzadBUS.VO.Mc_ost_przeg_przyrzadu + "-" + przyrzadBUS.VO.Rok_ost_przeg_przyrzadu);
                    przyrzadBUS.skip();
                }
                if (listBoxPrzyrzady.Items.Count > 0)
                {
                    listBoxPrzyrzady.SelectedIndex = 0;
                }
            }
        }// radioButtonOstatniPrzegladPrzyrzadu_CheckedChanged(object sender, EventArgs e)

        private void radioButtonNrSystemowyPrzyrzadu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNrSystemowyPrzyrzadu.Checked)
            {
                listBoxPrzyrzady.Items.Clear();
                CzyscDanePrzyrzadu();

                nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
                przyrzadBUS.SelectQuery("SELECT * FROM Przyrzad ORDER BY Nr_systemowy_przyrzadu ASC;");

                while (!przyrzadBUS.eof)
                {
                    listBoxPrzyrzady.Items.Add(przyrzadBUS.VO.Nazwa_przyrzadu + " " + przyrzadBUS.VO.Nr_systemowy_przyrzadu);
                    przyrzadBUS.skip();
                }
                if (listBoxPrzyrzady.Items.Count > 0)
                {
                    listBoxPrzyrzady.SelectedIndex = 0;
                }
            }
        } // radioButtonNrSystemowyPrzyrzadu_CheckedChanged(object sender, EventArgs e)

        private void buttonSzukajPrzyrzad_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Przycisk Nowy w zakładce Przyrząd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNowyPrzyrzad_Click(object sender, EventArgs e)
        {
            listBoxPrzyrzady.Tag = "";

            textBoxNazwaPrzyrzadu.Text = String.Empty;
            textBoxTypPrzyrzadu.Text = String.Empty;
            textBoxRodzajPrzyrzadu.Text = String.Empty;
            textBoxNrfabrycznyPrzyrzadu.Text = String.Empty;
            textBoxNrSystemowyPrzyrzadu.Text = String.Empty;
            richTextBoxDaneProducentaPrzyrzadu.Text = String.Empty;
            dateTimePickerDataOstPrzegladuPrzyrzadu.Text = String.Empty;
            comboBoxOpiekunPrzyrzadu.Text = String.Empty;

            labelZdjecieNazwa.Text = string.Empty;
            pictureBox.Image = null;
            _zawartoscPliku = new byte[] { }; // pusta zawartość zdjęcia.

        }//  private void buttonNowyPrzyrzad_Click(object sender, EventArgs e)

        private void buttonZapiszPrzyrzad_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (textBoxNazwaPrzyrzadu.Text == string.Empty)
            {
                MessageBox.Show("Wpisz nazwę przyrządu.", "RemaGUM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nsAccess2DB.PrzyrzadBUS przyrzadBUS = new nsAccess2DB.PrzyrzadBUS(_connString);
            nsAccess2DB.PrzyrzadVO przyrzadVO = new nsAccess2DB.PrzyrzadVO();

            //toolStripStatusLabelPrzyrzadu.Text = przyrzadVO.Identyfikator.ToString();


            przyrzadVO.Nazwa_przyrzadu = textBoxNazwaPrzyrzadu.Text.Trim();
            przyrzadVO.Typ_przyrzadu = textBoxTypPrzyrzadu.Text.Trim();
            przyrzadVO.Rodzaj_przyrzadu = textBoxRodzajPrzyrzadu.Text.Trim();
            przyrzadVO.Nr_fabryczny_przyrzadu = textBoxNrfabrycznyPrzyrzadu.Text.Trim();
            przyrzadVO.Nr_systemowy_przyrzadu = textBoxNrSystemowyPrzyrzadu.Text.Trim();
            przyrzadVO.Dane_producenta_przyrzadu = richTextBoxDaneProducentaPrzyrzadu.Text.Trim();


            przyrzadVO.Rok_ost_przeg_przyrzadu = dateTimePickerDataOstPrzegladuPrzyrzadu.Value.Year;
            przyrzadVO.Mc_ost_przeg_przyrzadu = dateTimePickerDataOstPrzegladuPrzyrzadu.Value.Month;
            przyrzadVO.Dz_ost_przeg_przyrzadu = dateTimePickerDataOstPrzegladuPrzyrzadu.Value.Day;
            //przyrzadVO.Data_ost_przeg_przyrzadu = dateTimePickerDataOstPrzegladuPrzyrzadu.Value;
            przyrzadVO.Data_ost_przeg_przyrzadu = int.Parse(przyrzadVO.Rok_ost_przeg_przyrzadu.ToString("0000") + przyrzadVO.Mc_ost_przeg_przyrzadu.ToString("00") + przyrzadVO.Dz_ost_przeg_przyrzadu.ToString("00"));
            przyrzadVO.Opiekun_przyrzadu = comboBoxOpiekunPrzyrzadu.Text.Trim();

            if (toolStripStatusLabelPrzyrzadu.Text == string.Empty)
            {
                przyrzadBUS.VO.Identyfikator = -1; // nowa pozycja
            }
            else
            {
                przyrzadVO.Identyfikator = int.Parse(toolStripStatusLabelPrzyrzadu.Text); // edycja
            }

            przyrzadBUS.write(przyrzadVO);

            WypelnijlistBoxPrzyrzady();

            pokazKomunikat("Przyrząd zapisany w bazie.");

            if (toolStripStatusLabelPrzyrzadu.Text == string.Empty)
            {
                listBoxPrzyrzady.SelectedIndex = listBoxPrzyrzady.Items.Count - 1;
            }
            else
            {
                listBoxPrzyrzady.SelectedIndex = przyrzadBUS.getIdx(przyrzadVO.Identyfikator);
            }


            //}
            //catch { }
        }// private void buttonZapiszPrzyrzad_Click(object sender, EventArgs e)



        // Wyświetla komunikaty chwilowe w programie.
                  

        private void pokazKomunikat(string tresc)
        {
                Frame frame = new Frame(tresc);
                frame.Show();
                frame.Refresh();
                Thread.Sleep(2000);
                frame.Close();
                frame.Dispose();
            }// pokazKomunikat
        }
}// RemaCHEM
