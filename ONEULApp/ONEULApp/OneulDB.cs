using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ONEULApp
{
    class OneulDB
    {

        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public DateTime Time
        {
            get;
            set;
        }

        public string Memo
        {
            get;
            set;
        }

    }
}
