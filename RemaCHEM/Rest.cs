using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemaCHEM
{
    class Rest
    {
        /// <summary>
        /// Połączenie z bazą danych RemaCHEM.
        /// </summary>
        /// <param name="connString">The connection string.</param>
        /// <returns>System.String.</returns>
        public string dbConnection(string connString)
        {
            return connString + "; Jet OLEDB:Database Password=RemaCHEM";
        }
    }// class Rest
}// RemaCHEM
