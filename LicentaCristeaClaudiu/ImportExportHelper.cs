using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    public class ImportExportHelper
    {
        public ImportExportHelper()
        {

        }

        public String LoadFromFile(String path)
        {
            String text = System.IO.File.ReadAllText(path);
            return text;
        }
        public void SaveToFile(String path, String sql)
        {
            try
            {
                System.IO.File.WriteAllText(path, sql);
            }
            catch(System.IO.IOException ex)
            {
                System.Windows.Forms.MessageBox.Show("File already in use!");
            }
            
        }
    }
}
