using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class SqlUpdateWhereCreator
    {
        private List<String> conditionList;
        private String[] specialCharacters = { "(", ")", "AND", "OR" };

        public SqlUpdateWhereCreator()
        {
            this.conditionList = new List<String>();
        }

        public List<string> ConditionList
        {
            get
            {
                return conditionList;
            }

            set
            {
                conditionList = value;
            }
        }

        public void AddToLists(String column, String value)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int count = this.conditionList.Count();
            sb.Append("WHERE ");
            if (count > 1)
            {
                sb.Append(this.conditionList[0]);
                sb.Append(" ");
                for (int i = 1; i < count; i++)
                {
                    if (this.specialCharacters.Contains(this.conditionList[i]))
                    {
                        sb.Append(this.conditionList[i]);
                        sb.Append(" ");
                    }
                    else
                    {
                        if (this.specialCharacters.Contains(this.conditionList[i - 1]))
                        {
                            sb.Append(this.conditionList[i]);
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(",");
                            sb.Append(this.conditionList[i]);
                        }
                    }
                }
            }
            else
            {
                sb.Append(this.conditionList[0]);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
