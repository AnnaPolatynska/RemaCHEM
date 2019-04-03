using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace nsAccess2DB
{

    /// <summary>
    /// Class dbConnection.
    /// </summary>
    class dbConnection
    {
        /// <exclude />
        private OleDbDataAdapter _adapter;
        /// <exclude />
        private OleDbConnection _conn;
        /// <exclude />
        public string _error = string.Empty; //komunikat błedu
                                             /// <summary>
                                             /// Initializes a new instance of the <see cref="dbConnection"/> class.
                                             /// </summary>
                                             /// <param name="connString">The connection string.</param>
                                             /// <constructor>
                                             /// Połączenie z bazą.
                                             /// </constructor>
        public dbConnection(string connString)
        {
            _adapter = new OleDbDataAdapter();
            _conn = new OleDbConnection(connString);
        }//dbConnection
         /// <summary>
         /// Opens the connection.
         /// </summary>
         /// <returns>OleDbConnection.</returns>
         /// <method>
         /// Otwiera połaczenie jeśli jest zamknięte lub przerwane.
         /// </method>
        private OleDbConnection openConnection()
        {
            if (_conn.State == ConnectionState.Closed || _conn.State ==
                        ConnectionState.Broken)
            {
                _conn.Open();
            }
            return _conn;
        }//SqlConnection

        /// <summary>
        /// Executes the select query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>DataTable.</returns>
        /// <method>
        /// Polecenie wyboru.
        /// </method>
        public DataTable executeSelectQuery(String query, OleDbParameter[] parameters)
        {
            //SqlCommand comm = new SqlCommand();
            OleDbCommand comm = new OleDbCommand();

            //OleDbCommand
            DataTable dt = new DataTable();
            //dt.CaseSensitive = true;
            DataSet ds = new DataSet();
            //ds.CaseSensitive = true;
            try
            {
                comm.Connection = openConnection();
                comm.CommandText = query;
                comm.Parameters.AddRange(parameters);
                comm.ExecuteNonQuery();
                _adapter.SelectCommand = comm;

                _adapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (SqlException e)
            {
                _error = "Error - Connection.executeSelectQuery - Query: " + query + " \nException: " + e.StackTrace.ToString();
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }//executeSelectQuery

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <method>
        /// Polecenie dodania.
        /// </method>
        public bool executeInsertQuery(String query, OleDbParameter[] parameters)
        {
            //SqlCommand comm = new SqlCommand();
            OleDbCommand comm = new OleDbCommand();

            try
            {
                comm.Connection = openConnection();
                comm.CommandText = query;
                comm.Parameters.AddRange(parameters);
                _adapter.InsertCommand = comm;
                comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                _error = "Error - Connection.executeInsertQuery - Query: " + query + " \nException: \n" + e.StackTrace.ToString();
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }//executeInsertQuery

        /// <summary>
        /// Executes the delete query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <method>
        /// Polecenie usunięcia.
        /// </method>
        public bool executeDeleteQuery(String query, OleDbParameter[] parameters)
        {
            //SqlCommand comm = new SqlCommand();
            OleDbCommand comm = new OleDbCommand();
            try
            {
                comm.Connection = openConnection();
                comm.CommandText = query;
                comm.Parameters.AddRange(parameters);
                _adapter.DeleteCommand = comm;
                comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                _error = "Error - Connection.executeDeleteQuery - Query: " + query + " \nException: \n" + e.StackTrace.ToString();
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }//executeInsertQuery

        /// <summary>
        /// Executes the update query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <method>
        /// Polecenie aktualizacji.
        /// </method>
        public bool executeUpdateQuery(String query, OleDbParameter[] parameters)
        {
            //SqlCommand comm = new SqlCommand();
            OleDbCommand comm = new OleDbCommand();

            try
            {
                comm.Connection = openConnection();
                comm.CommandText = query;
                comm.Parameters.AddRange(parameters);
                _adapter.UpdateCommand = comm;
                comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                _error = "Error - Connection.executeUpdateQuery - Query: " + query + " \nException: " + e.StackTrace.ToString();
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }//executeUpdateQuery
    }// class dbConnection






    ////////////////////////////////////////////////////////////////  Klasa wymiany danych z tabelą Przyrząd
    // -----------------------------------------------------------------> PrzyrzadVO
    /// <summary>
    /// Klasa wymiany danych z tabelą Przyrząd
    /// </summary>
    public class PrzyrzadVO
    {
        private int _Identyfikator = -1;
        private string _Nazwa_przyrzadu = string.Empty;//100
        private string _Typ_przyrzadu = string.Empty; //100
        private string _Rodzaj_przyrzadu = string.Empty;//100
        private string _Nr_fabryczny_przyrzadu = string.Empty;//100
        private string _Nr_systemowy_przyrzadu = string.Empty;//100
        private string _Dane_producenta_przyrzadu = string.Empty;//255
        private string _Nazwa_stanowiska = string.Empty;//100
        private int _Data_ost_przeg_przyrzadu = 0;
        private int _Rok_ost_przeg_przyrzadu = 0;
        private int _Mc_ost_przeg_przyrzadu = 0;
        private int _Dz_ost_przeg_przyrzadu = 0;
        private string _Opiekun_przyrzadu = string.Empty;
        private string _Zdjecie_przyrzadu = string.Empty;//255
        private byte[] _Zawartosc_pliku_zdj_przyrzadu = new byte[] { }; // obiekt OLE - zdjęcie
        private string _Rozszerz_zdj_przyrzadu = string.Empty; // 255
                                                               /// <summary>
                                                               /// Konstruktor wymiany danych z tabelą Przyrząd
                                                               /// </summary>
        public PrzyrzadVO() { }
        public int Identyfikator
        {
            get { return _Identyfikator; }
            set { _Identyfikator = value; }
        }
        public string Nazwa_przyrzadu
        {
            get { return _Nazwa_przyrzadu; }
            set { _Nazwa_przyrzadu = value; }
        }
        public string Typ_przyrzadu
        {
            get { return _Typ_przyrzadu; }
            set { _Typ_przyrzadu = value; }
        }
        public string Rodzaj_przyrzadu
        {
            get { return _Rodzaj_przyrzadu; }
            set { _Rodzaj_przyrzadu = value; }
        }
        public string Nr_fabryczny_przyrzadu
        {
            get { return _Nr_fabryczny_przyrzadu; }
            set { _Nr_fabryczny_przyrzadu = value; }
        }
        public string Nr_systemowy_przyrzadu
        {
            get { return _Nr_systemowy_przyrzadu; }
            set { _Nr_systemowy_przyrzadu = value; }
        }
        public string Dane_producenta_przyrzadu
        {
            get { return _Dane_producenta_przyrzadu; }
            set { _Dane_producenta_przyrzadu = value; }
        }
        public string Nazwa_stanowiska
        {
            get { return _Nazwa_stanowiska; }
            set { _Nazwa_stanowiska = value; }
        }
        public int Data_ost_przeg_przyrzadu
        {
            get { return _Data_ost_przeg_przyrzadu; }
            set { _Data_ost_przeg_przyrzadu = value; }
        }
        public int Rok_ost_przeg_przyrzadu
        {
            get { return _Rok_ost_przeg_przyrzadu; }
            set { _Rok_ost_przeg_przyrzadu = value; }
        }
        public int Mc_ost_przeg_przyrzadu
        {
            get { return _Mc_ost_przeg_przyrzadu; }
            set { _Mc_ost_przeg_przyrzadu = value; }
        }
        public int Dz_ost_przeg_przyrzadu
        {
            get { return _Dz_ost_przeg_przyrzadu; }
            set { _Dz_ost_przeg_przyrzadu = value; }
        }
        public string Opiekun_przyrzadu
        {
            get { return _Opiekun_przyrzadu; }
            set { _Opiekun_przyrzadu = value; }
        }
        public string Zdjecie_przyrzadu
        {
            get { return _Zdjecie_przyrzadu; }
            set { _Zdjecie_przyrzadu = value; }
        }
        public byte[] Zawartosc_pliku_zdj_przyrzadu
        {
            get { return _Zawartosc_pliku_zdj_przyrzadu; }
            set { _Zawartosc_pliku_zdj_przyrzadu = value; }
        }
        public string Rozszerz_zdj_przyrzadu
        {
            get { return _Rozszerz_zdj_przyrzadu; }
            set { _Rozszerz_zdj_przyrzadu = value; }
        }
    }// PrzyrzadVO

    // Klasa dostępu do tabeli Przyrzad (Data Access Object) ---------------------------->DAO
    /// <summary>
    /// Klasa PrzyrządDAO
    /// </summary>
    public class PrzyrzadDAO
    {
        private dbConnection _conn;
        public string _error = string.Empty;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="connString"></param>
        public PrzyrzadDAO(string connString)
        {
            _conn = new dbConnection(connString);
            _error = _conn._error;
        } //konstruktor PrzyrzadDAO

        /// <summary>
        /// Selects the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>DataTable.</returns>
        public DataTable SelectQuery(string query)
        {
            OleDbParameter[] parameters = new OleDbParameter[0];
            DataTable dt = _conn.executeSelectQuery(query, parameters);
            _error = _conn._error;
            return dt;
        }//selectQuery

        /// <summary>
        /// Zwraca tabelę spełniającą wartości parametrów.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable Select()
        {
            string query = "SELECT * FROM Przyrzad;";
            OleDbParameter[] parameters = new OleDbParameter[0];
            DataTable dt = _conn.executeSelectQuery(query, parameters);
            _error = _conn._error;
            return dt;
        }//select
         /// <summary>
         /// Selects the specified identyfikator.
         /// </summary>
         /// <param name="Identyfikator">The identyfikator.</param>
         /// <returns>DataTable.</returns>
        public DataTable Select(int Identyfikator)
        {
            string query = "SELECT * FROM Przyrzad WHERE Identyfikator = " + Identyfikator.ToString() + ";";
            OleDbParameter[] parameters = new OleDbParameter[0];
            DataTable dt = _conn.executeSelectQuery(query, parameters);
            _error = _conn._error;
            return dt;
        }//select

        /// <summary>
        /// Wprowadza nowy rekord do tabeli Przyrzad.
        /// </summary>
        /// <param name="VO"></param>
        /// <returns></returns>
        public bool Insert(nsAccess2DB.PrzyrzadVO VO)
        {
            string query = "INSERT INTO Przyrzad (Nazwa_przyrzadu, Typ_przyrzadu, Rodzaj_przyrzadu, Nr_fabryczny_przyrzadu, Nr_systemowy_przyrzadu, Dane_producenta_przyrzadu, Nazwa_stanowiska, Data_ost_przeg_przyrzadu, Rok_ost_przeg_przyrzadu," +
                " Mc_ost_przeg_przyrzadu, Dz_ost_przeg_przyrzadu, Opiekun_przyrzadu, Zdjecie_przyrzadu, Zawartosc_pliku_zdj_przyrzadu, Rozszerz_zdj_przyrzadu);";

            OleDbParameter[] parameters = new OleDbParameter[15];
            parameters[0] = new OleDbParameter("Nazwa_przyrzadu", OleDbType.VarChar, 100);
            parameters[0].Value = VO.Nazwa_przyrzadu;

            parameters[1] = new OleDbParameter("Typ_przyrzadu", OleDbType.VarChar, 100);
            parameters[1].Value = VO.Typ_przyrzadu;

            parameters[2] = new OleDbParameter("Rodzaj_przyrzadu", OleDbType.VarChar, 100);
            parameters[2].Value = VO.Rodzaj_przyrzadu;

            parameters[3] = new OleDbParameter("Nr_fabryczny_przyrzadu", OleDbType.VarChar, 100);
            parameters[3].Value = VO.Nr_fabryczny_przyrzadu;

            parameters[4] = new OleDbParameter("Nr_systemowy_przyrzadu", OleDbType.VarChar, 100);
            parameters[4].Value = VO.Nr_systemowy_przyrzadu;

            parameters[5] = new OleDbParameter("Dane_producenta_przyrzadu", OleDbType.VarChar, 255);
            parameters[5].Value = VO.Dane_producenta_przyrzadu;

            parameters[6] = new OleDbParameter("Nazwa_stanowiska", OleDbType.VarChar, 100);
            parameters[6].Value = VO.Nazwa_stanowiska;

            parameters[7] = new OleDbParameter("Data_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[7].Value = VO.Data_ost_przeg_przyrzadu;

            parameters[8] = new OleDbParameter("Rok_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[8].Value = VO.Rok_ost_przeg_przyrzadu;

            parameters[9] = new OleDbParameter("Mc_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[9].Value = VO.Mc_ost_przeg_przyrzadu;

            parameters[10] = new OleDbParameter("Dz_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[10].Value = VO.Nazwa_przyrzadu;

            parameters[11] = new OleDbParameter("Opiekun_przyrzadu", OleDbType.VarChar, 100);
            parameters[11].Value = VO.Opiekun_przyrzadu;

            parameters[12] = new OleDbParameter("Zdjecie_przyrzadu", OleDbType.VarChar, 100);
            parameters[12].Value = VO.Zdjecie_przyrzadu;

            parameters[13] = new OleDbParameter("Zawartosc_pliku_zdj_przyrzadu", OleDbType.VarBinary);
            parameters[13].Value = VO.Zawartosc_pliku_zdj_przyrzadu;

            parameters[14] = new OleDbParameter("Rozszerz_zdj_przyrzadu", OleDbType.VarChar, 255);
            parameters[14].Value = VO.Rozszerz_zdj_przyrzadu;

            bool b = _conn.executeInsertQuery(query, parameters);
            _error = _conn._error;
            return b;
        }//insert

        /// <summary>
        /// Aktualizauje rekord tabeli Przyrzad.
        /// </summary>
        /// <param name="VO"></param>
        /// <returns></returns>
        public bool Update(nsAccess2DB.PrzyrzadVO VO)
        {
            string query = "UPDATE Przyrzad SET " +
                "Nazwa_przyrzadu = @Nazwa_przyrzadu, " +
                "Typ_przyrzadu = @Typ_przyrzadu, " +
                "Rodzaj_przyrzadu = @Rodzaj_przyrzadu, " +
                "Nr_fabryczny_przyrzadu = @Nr_fabryczny_przyrzadu, " +
                "Nr_systemowy_przyrzadu = @Nr_systemowy_przyrzadu, " +
                "Dane_producenta_przyrzadu = @Dane_producenta_przyrzadu, " +
                "Nazwa_stanowiska = @Nazwa_stanowiska, " +
                "Data_ost_przeg_przyrzadu = @Data_ost_przeg_przyrzadu, " +
                "Rok_ost_przeg_przyrzadu = @Rok_ost_przeg_przyrzadu, " +
                "Mc_ost_przeg_przyrzadu = @Mc_ost_przeg_przyrzadu, " +
                "Dz_ost_przeg_przyrzadu = @Dz_ost_przeg_przyrzadu, " +
                "Opiekun_przyrzadu = @Opiekun_przyrzadu, " +
                "Zdjecie_przyrzadu = @Zdjecie_przyrzadu, " +
                "Zawartosc_pliku_zdj_przyrzadu = @Zawartosc_pliku_zdj_przyrzadu, " +
                "Rozszerz_zdj_przyrzadu = @Rozszerz_zdj_przyrzadu);";

            OleDbParameter[] parameters = new OleDbParameter[15];
            parameters[0] = new OleDbParameter("Nazwa_przyrzadu", OleDbType.VarChar, 100);
            parameters[0].Value = VO.Nazwa_przyrzadu;

            parameters[1] = new OleDbParameter("Typ_przyrzadu", OleDbType.VarChar, 100);
            parameters[1].Value = VO.Typ_przyrzadu;

            parameters[2] = new OleDbParameter("Rodzaj_przyrzadu", OleDbType.VarChar, 100);
            parameters[2].Value = VO.Rodzaj_przyrzadu;

            parameters[3] = new OleDbParameter("Nr_fabryczny_przyrzadu", OleDbType.VarChar, 100);
            parameters[3].Value = VO.Nr_fabryczny_przyrzadu;

            parameters[4] = new OleDbParameter("Nr_systemowy_przyrzadu", OleDbType.VarChar, 100);
            parameters[4].Value = VO.Nr_systemowy_przyrzadu;

            parameters[5] = new OleDbParameter("Dane_producenta_przyrzadu", OleDbType.VarChar, 255);
            parameters[5].Value = VO.Dane_producenta_przyrzadu;

            parameters[6] = new OleDbParameter("Nazwa_stanowiska", OleDbType.VarChar, 100);
            parameters[6].Value = VO.Nazwa_stanowiska;

            parameters[7] = new OleDbParameter("Data_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[7].Value = VO.Data_ost_przeg_przyrzadu;

            parameters[8] = new OleDbParameter("Rok_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[8].Value = VO.Rok_ost_przeg_przyrzadu;

            parameters[9] = new OleDbParameter("Mc_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[9].Value = VO.Mc_ost_przeg_przyrzadu;

            parameters[10] = new OleDbParameter("Dz_ost_przeg_przyrzadu", OleDbType.Integer);
            parameters[10].Value = VO.Nazwa_przyrzadu;

            parameters[11] = new OleDbParameter("Opiekun_przyrzadu", OleDbType.VarChar, 100);
            parameters[11].Value = VO.Opiekun_przyrzadu;

            parameters[12] = new OleDbParameter("Zdjecie_przyrzadu", OleDbType.VarChar, 100);
            parameters[12].Value = VO.Zdjecie_przyrzadu;

            parameters[13] = new OleDbParameter("Zawartosc_pliku_zdj_przyrzadu", OleDbType.VarBinary);
            parameters[13].Value = VO.Zawartosc_pliku_zdj_przyrzadu;

            parameters[14] = new OleDbParameter("Rozszerz_zdj_przyrzadu", OleDbType.VarChar, 255);
            parameters[14].Value = VO.Rozszerz_zdj_przyrzadu;

            bool b = _conn.executeInsertQuery(query, parameters);
            _error = _conn._error;
            return b;
        }//update

        public bool Delete(int Identyfikator)
        {
            string query = "DELETE * FROM Przyrzad WHERE Identyfikator = " + Identyfikator.ToString() + ";";
            OleDbParameter[] parameters = new OleDbParameter[0];
            bool b = _conn.executeDeleteQuery(query, parameters);
            _error = _conn._error;
            return b;
        }//Delete

    }//PrzyrzadDAO

    // Warstwa operacji biznesowych tabeli Przyrzad -----> BUS
    /// <summary>
    /// Klasa PrzyrzadBUS
    /// </summary>
    public class PrzyrzadBUS
    {
        PrzyrzadDAO _DAO;
        private PrzyrzadVO[] _VOs = new PrzyrzadVO[0];  //lista danych
        private PrzyrzadVO _VOi = new PrzyrzadVO();       //dane na pozycji _idx
        private int _idx = 0;                           //indeks pozycji
        private bool _eof = false;                      //wskaźnik końca pliku
        private int _count = 0;                         //liczba pozycji
        public string _error = string.Empty;

        /// <summary>
        /// Kkonstruktor PrzyrzadBUS.
        /// </summary>
        /// <param name="connString"></param>
        public PrzyrzadBUS(string connString)
        {
            _DAO = new PrzyrzadDAO(connString);
            _error = _DAO._error;
        }// konstruktor PrzyrzadBUS

        /// <summary>
        /// Wypełnia tablice danych pozycjami.
        /// </summary>
        public void Select()
        {
            FillTable(_DAO.Select());
        }//select

        /// <summary>
        /// Wypełnia tablicę pozycjami.
        /// </summary>
        /// <param name="Identyfikator"></param>
        public void Select(int Identyfikator)
        {
            FillTable(_DAO.Select(Identyfikator));
        }//select

        /// <summary>
        /// Dowolne zapytanie z formularza.
        /// </summary>
        /// <param name="query">The query.</param>
        public void SelectQuery(string query)
        {
            FillTable(_DAO.SelectQuery(query));
        }//selectQuery

        /// <summary>
        /// Wprowadza rekord do tabeli.
        /// </summary>
        /// <param name="VO">Obiekt wymiany danych.</param>
        /// <returns>Wartość logiczna powodzenia akcji.</returns>
        private bool Insert(nsAccess2DB.PrzyrzadVO VO)
        {
            bool b = _DAO.Insert(VO);
            _error = _DAO._error;
            return b;
        }//insert

        /// <summary>
        /// Aktualizuje rekord z wyjątkiem Identyfikatora Przyrzadu.
        /// </summary>
        /// <param name="VO">Obiekt wymiany danych.</param>
        /// <returns>Wartość logiczna powodzenia akcji.</returns>
        private bool Update(nsAccess2DB.PrzyrzadVO VO)
        {
            bool b = _DAO.Update(VO);
            _error = _DAO._error;
            return b;
        }//update

        /// <summary>
        /// Kasuje rekord wybrany po Identyfikatorze.
        /// </summary>
        /// <param name="Identyfikator"></param>
        /// <returns></returns>
        public bool Delete(int Identyfikator)
        {
            return _DAO.Delete(Identyfikator);
        }// delete

        /// <summary>
        /// Wypełnia tablice.
        /// </summary>
        /// <param name="dt"></param>
        private void FillTable(DataTable dt)
        {
            PrzyrzadVO VOi;
            _VOs = new PrzyrzadVO[0];

            foreach (DataRow dr in dt.Rows)
            {
                Array.Resize(ref _VOs, _VOs.Length + 1);
                VOi = new PrzyrzadVO();

                VOi.Identyfikator = int.Parse(dr["Identyfikator"].ToString());
                VOi.Nazwa_przyrzadu = dr["Nazwa_przyrzadu"].ToString();
                VOi.Typ_przyrzadu = dr["Typ_przyrzadu"].ToString();
                VOi.Rodzaj_przyrzadu = dr["Rodzaj_przyrzadu"].ToString();
                VOi.Nr_fabryczny_przyrzadu = dr["Nr_fabryczny_przyrzadu"].ToString();
                VOi.Nr_systemowy_przyrzadu = dr["Nr_systemowy_przyrzadu"].ToString();
                VOi.Dane_producenta_przyrzadu = dr["Dane_producenta_przyrzadu"].ToString();
                VOi.Nazwa_stanowiska = dr["Nazwa_stanowiska"].ToString();
                try
                {
                    VOi.Data_ost_przeg_przyrzadu = int.Parse(dr["Data_ost_przeg_przyrzadu"].ToString());
                }
                catch { }
                VOi.Rok_ost_przeg_przyrzadu = int.Parse(dr["Rok_ost_przeg_przyrzadu"].ToString());
                VOi.Mc_ost_przeg_przyrzadu = int.Parse(dr["Mc_ost_przeg_przyrzadu"].ToString());
                VOi.Dz_ost_przeg_przyrzadu = int.Parse(dr["Dz_ost_przeg_przyrzadu"].ToString());
                VOi.Opiekun_przyrzadu = dr["Opiekun_przyrzadu"].ToString();
                VOi.Zdjecie_przyrzadu = dr["Zdjecie_przyrzadu"].ToString();
                try
                {
                    VOi.Zawartosc_pliku_zdj_przyrzadu = (byte[])dr["Zawartosc_pliku"];
                }
                catch
                {
                    VOi.Zawartosc_pliku_zdj_przyrzadu = new byte[] { };
                }
                VOi.Rozszerz_zdj_przyrzadu = dr["Rozszerz_zdj_przyrzadu"].ToString();

                _VOs[_VOs.Length - 1] = VOi;
            }
            _eof = _VOs.Length == 0;
            _count = _VOs.Length;
            if (_count > 0)
                _idx = 0;
            else
            {
                _idx = -1;
                _eof = true;
            }
        }//fillTable

        /// <summary>
        /// Przemieszcza indeks w tablicy danych o jedną pozycję.
        /// </summary>
        public void skip()
        {
            if (_count > 0)
            {
                _idx++;
                _eof = _idx >= _count;
            }
        }//skip

        /// <summary>
        /// Przemieszcza indeks w tablicy danych na pozycję pierwszą.
        /// </summary>
        public void top()
        {
            if (_count > 0)
            {
                _idx = 0;
                _eof = false;
            }
        }//top

        /// <summary>
        ///  Zmienna logiczna osiągnięcia końca pliku.
        /// </summary>
        public bool eof
        {
            get { return _eof; }
        }

        /// <summary>
        ///  Zwraca liczbę pozycji tablicy.
        /// </summary>
        public int count
        {
            get { return _count; }
        }//count

        /// <summary>
        /// Zwraca daną okrśloną wskaźnikiem pozycji.
        /// </summary>
        public PrzyrzadVO VO
        {
            get
            {
                if (_idx > -1 & _idx < _count)
                {
                    _VOi = _VOs[_idx];
                    return _VOi;
                }
                return new PrzyrzadVO();
            }
        }//PrzyrzadVO

        /// <summary>
        /// Ustawia wskaźnik pozycji.
        /// </summary>
        public int idx
        {
            set
            {
                if (value > -1 & value < _count)
                {
                    _idx = value;
                }
            }
        }//idx

        /// <summary>
        /// Sprawdza istnienie rekordu.
        /// </summary>
        /// <param name="Identyfikator"></param>
        /// <returns></returns>
        private bool Exists(int Identyfikator)
        {
            foreach (PrzyrzadVO VOi in _VOs)
            {
                if (VOi.Identyfikator == Identyfikator) return true;
            }
            return false;
        }//exist

        /// <summary>
        /// Zwraca indeks pozycji.
        /// </summary>
        /// <param name="Identyfikator"></param>
        /// <returns></returns>
        public int getIdx(int Identyfikator)
        {
            int idx = -1;
            foreach (PrzyrzadVO VOi in _VOs)
            {
                idx++;
                if (VOi.Identyfikator == Identyfikator) return idx;
            }
            return -1;
        }//getIdx

        /// <summary>
        /// Zwraca maszynę o wskazanym identyfikatorze.
        /// </summary>
        /// <param name="Identyfikator"></param>
        /// <returns></returns>
        public PrzyrzadVO GetVO(int Identyfikator)
        {
            foreach (nsAccess2DB.PrzyrzadVO VO in _VOs)
            {
                if (VO.Identyfikator == Identyfikator) return VO;
            }
            return new PrzyrzadVO();
        }//getVO

        public bool write(nsAccess2DB.PrzyrzadVO VO)
        {
            if (Exists(VO.Identyfikator))
            {
                return _DAO.Update(VO);
            }
            return _DAO.Insert(VO);
        }//write

    }//PrzyrzadBUS

}//nsAccess2DB
