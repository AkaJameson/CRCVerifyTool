using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCVerifyTool
{
    public enum DataType
    {
        STRING,
        HEX,
        File
    }

    public class DataTypeItem
    {
        public DataType dataType { get; set; }

        public string Name { get; set; }
    }
}
