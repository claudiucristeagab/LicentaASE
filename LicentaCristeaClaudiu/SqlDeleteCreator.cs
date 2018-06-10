using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class SqlDeleteCreator
    {
        private String deleteLocation;
        private List<String> deleteConditions;

        private String[] specialCharacters = { "(", ")", "AND", "OR" };

        public SqlDeleteCreator()
        {
            this.DeleteConditions = new List<String>();
        }

        public SqlDeleteCreator(string deleteLocation, List<string> deleteConditions)
        {
            this.DeleteLocation = deleteLocation;
            this.DeleteConditions = deleteConditions;
        }

        public string DeleteLocation
        {
            get
            {
                return deleteLocation;
            }

            set
            {
                deleteLocation = value;
            }
        }

        public List<string> DeleteConditions
        {
            get
            {
                return deleteConditions;
            }

            set
            {
                deleteConditions = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE ");
            sb.Append("FROM ");
            sb.Append(this.deleteLocation);
            sb.Append(" ");
            int countConditions = this.deleteConditions.Count;
            if (countConditions > 0)
            {
                sb.Append("WHERE ");
                if (countConditions > 1)
                {
                    sb.Append(this.deleteConditions[0]);
                    sb.Append(" ");
                    for (int i = 1; i < countConditions; i++)
                    {
                        if (this.specialCharacters.Contains(this.deleteConditions[i]))
                        {
                            sb.Append(this.deleteConditions[i]);
                            sb.Append(" ");
                        }
                        else
                        {
                            if (this.specialCharacters.Contains(this.deleteConditions[i - 1]))
                            {
                                sb.Append(this.deleteConditions[i]);
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append(",");
                                sb.Append(this.deleteConditions[i]);
                                sb.Append(" ");
                            }
                        }
                    }
                }
                else
                {
                    sb.Append(this.deleteConditions[0]);
                    sb.Append(" ");
                }
            }
            sb.Append(";");
            return sb.ToString();
        }
    }
}
