using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xin.DotnetUtil.Verify.CRC;

namespace CRCVerifyTool_WPF.Model
{
    internal class VerifyModel
    {
        internal CRCParamter cRCParamter;

        internal List<string> crcAlgorithms = new List<string>();

        internal List<string> verifyTypeList = new List<string>() { "Hex", "String", "File" };

        internal string dataContent;

        internal string defaultSelectItem ;

        internal string defaultVerifyItem;

        internal byte[] fileInfo;

        internal uint crcOutcome;
        public VerifyModel()
        {
            //初始化算法列表
            foreach(var type in Enum.GetValues(typeof(CRCCrcAlgorithm)))
            {
                crcAlgorithms.Add(type.ToString());
            }
        }
    }
}
