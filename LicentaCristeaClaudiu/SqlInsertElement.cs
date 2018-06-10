using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    class SqlInsertElement
    {
        private CheckBox checkBox;
        private TextBox textBox;
        private String column;
        private Boolean isNullable;
        private String dataType;
        private int maxChar;

        public SqlInsertElement()
        {

        }

        public SqlInsertElement(CheckBox checkBox, TextBox textBox)
        {
            this.checkBox = checkBox;
            this.textBox = textBox;
        }

        public SqlInsertElement(CheckBox checkBox, TextBox textBox, String column, bool isNullable, string dataType, int maxChar)
        {
            this.checkBox = checkBox;
            this.textBox = textBox;
            this.column = column;
            this.isNullable = isNullable;
            this.dataType = dataType;
            this.maxChar = maxChar;
        }

        public CheckBox CheckBox
        {
            get
            {
                return checkBox;
            }

            set
            {
                checkBox = value;
            }
        }

        public TextBox TextBox
        {
            get
            {
                return textBox;
            }

            set
            {
                textBox = value;
            }
        }

        public bool IsNullable
        {
            get
            {
                return isNullable;
            }

            set
            {
                isNullable = value;
            }
        }

        public string DataType
        {
            get
            {
                return dataType;
            }

            set
            {
                dataType = value;
            }
        }

        public int MaxChar
        {
            get
            {
                return maxChar;
            }

            set
            {
                maxChar = value;
            }
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
    }
}
