using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class SqlSelectOrderBy
    {
        private String column;
        private Boolean isAscendent;

        public SqlSelectOrderBy()
        {

        }

        public SqlSelectOrderBy(string column, Boolean isAscendent)
        {
            this.column = column;
            this.isAscendent = isAscendent;
        }

        public string Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }

        public Boolean IsAscendent
        {
            get
            {
                return isAscendent;
            }

            set
            {
                isAscendent = value;
            }
        }

        public String GetAscendent()
        {
            if (this.isAscendent)
            {
                return "ASC";
            }
            else
            {
                return "DESC";
            }
        }

        public override string ToString()
        {
            return this.column + " " + this.GetAscendent();
        }
    }
}
