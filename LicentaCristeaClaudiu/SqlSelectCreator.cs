using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class SqlSelectCreator
    {
        private List<String> selectList;
        private List<String> fromList;
        private List<String> whereList;
        private List<String> groupByList;
        private List<SqlSelectOrderBy> orderByList;
        
        private String[] specialCharacters = {"(",")","AND","OR"};

        public SqlSelectCreator()
        {
            this.selectList = new List<String>();
            this.fromList = new List<String>();
            this.whereList = new List<String>();
            this.orderByList = new List<SqlSelectOrderBy>();
            this.groupByList = new List<String>();
        }

        public List<string> SelectList
        {
            get
            {
                return selectList;
            }

            set
            {
                selectList = value;
            }
        }

        public List<string> FromList
        {
            get
            {
                return fromList;
            }

            set
            {
                fromList = value;
            }
        }

        public List<string> WhereList
        {
            get
            {
                return whereList;
            }

            set
            {
                whereList = value;
            }
        }

        public List<SqlSelectOrderBy> OrderByList
        {
            get
            {
                return orderByList;
            }

            set
            {
                orderByList = value;
            }
        }

        public List<string> GroupByList
        {
            get
            {
                return groupByList;
            }

            set
            {
                groupByList = value;
            }
        }

        public void ClearAllCommands()
        {
            this.selectList.Clear();
            this.fromList.Clear();
            this.whereList.Clear();
            this.groupByList.Clear();
            this.orderByList.Clear(); 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            //SELECT
            int count = this.selectList.Count;
            if (count > 0)
            {
                sb.Append("SELECT ");
                if (count > 1)
                {
                    sb.Append(this.selectList[0]);
                    for (int i = 1; i < count; i++)
                    {
                        sb.Append(", ");
                        sb.Append(this.selectList[i]);
                    }
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(selectList[0]);
                    sb.Append(" ");
                }

                //FROM
                sb.Append("FROM ");
                count = this.fromList.Count;
                if (count > 0)
                {
                    if (count > 1)
                    {
                        sb.Append(this.fromList[0]);
                        for (int i = 1; i < count; i++)
                        {
                            sb.Append(", ");
                            sb.Append(this.fromList[i]);
                        }
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(this.fromList[0]);
                        sb.Append(" ");
                    }

                    //WHERE
                    count = this.whereList.Count;
                    if (count > 0)
                    {
                        sb.Append("WHERE ");
                        if (count > 1)
                        {
                            sb.Append(this.whereList[0]);
                            sb.Append(" ");
                            for (int i = 1; i < count; i++)
                            {
                                if (this.specialCharacters.Contains(this.whereList[i]))
                                {
                                    sb.Append(this.whereList[i]);
                                    sb.Append(" ");
                                }
                                else
                                {
                                    if (this.specialCharacters.Contains(this.whereList[i - 1]))
                                    {
                                        sb.Append(this.whereList[i]);
                                        sb.Append(" ");
                                    }
                                    else
                                    {
                                        sb.Append(",");
                                        sb.Append(this.whereList[i]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            sb.Append(this.whereList[0]);
                            sb.Append(" ");
                        }
                    }

                    //GROUP BY
                    count = this.groupByList.Count;
                    if (count > 0)
                    {
                        sb.Append("GROUP BY");
                        sb.Append(" ");
                        if (count > 1)
                        {
                            sb.Append(this.groupByList[0].ToString());
                            for (int i = 1; i < count; i++)
                            {
                                sb.Append(", ");
                                sb.Append(this.groupByList[i].ToString());
                            }
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(this.groupByList[0].ToString());
                            sb.Append(" ");
                        }
                    }

                    //ORDER BY
                    count = this.orderByList.Count;
                    if (count > 0)
                    {
                        sb.Append("ORDER BY");
                        sb.Append(" ");
                        if (count > 1)
                        {
                            sb.Append(this.orderByList[0].ToString());
                            for (int i = 1; i < count; i++)
                            {
                                sb.Append(", ");
                                sb.Append(this.orderByList[i].ToString());
                            }
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(this.orderByList[0].ToString());
                            sb.Append(" ");
                        }
                    }
                }
                sb.Append(";");
            }
            return sb.ToString();
        }
    }
}
