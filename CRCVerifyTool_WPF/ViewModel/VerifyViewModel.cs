using CRCVerifyTool_WPF.Command;
using CRCVerifyTool_WPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Xin.DotnetUtil.Verify.CRC;

namespace CRCVerifyTool_WPF.ViewModel
{
    internal class VerifyViewModel : INotifyPropertyChanged
    {
        #region 数据通知
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
        #region Var 
        private VerifyModel _verifyModel = new VerifyModel();
        private VerifyType _verifyType;

        #endregion

        #region 属性
        public CRCParamter CRCParamter
        {
            get { return _verifyModel.cRCParamter; }
            set { _verifyModel.cRCParamter = value; RaisePropertyChanged(nameof(CRCParamter)); }

        }

        public List<string> CRCAlgorithms
        {
            get { return _verifyModel.crcAlgorithms; }
        }


        public string DefaultSelectItem
        {
            get { return _verifyModel.defaultSelectItem; }
            set { _verifyModel.defaultSelectItem = value; UpdateCRCParamter(value); }
        }


        public List<string> VerifyTypeList
        {
            get { return _verifyModel.verifyTypeList; }
        }

        public string DefaultVerifyItem
        {
            get { return _verifyModel.defaultVerifyItem; }
            set
            {
                _verifyModel.defaultVerifyItem = value;
                RaisePropertyChanged(nameof(DefaultVerifyItem));
                RaisePropertyChanged(nameof(IsRichTextBoxEnable));
                RaisePropertyChanged(nameof(IsUpLoadFileButtonShow));
                UpdateVerifyType(value);
            }
        }

        public bool IsRichTextBoxEnable
        {
            get
            {
                return DefaultVerifyItem != nameof(VerifyType.File);
            }
        }

        public bool IsUpLoadFileButtonShow
        {
            get
            {
                return DefaultVerifyItem == nameof(VerifyType.File);
            }
        }

        public string DataContent
        {
            get
            {
                return _verifyModel.dataContent;
            }
            set
            {
                _verifyModel.dataContent = value;
                RaisePropertyChanged(nameof(DataContent));
            }
        }

        public byte[] FileInfo
        {
            get => _verifyModel.fileInfo;
            set => _verifyModel.fileInfo = value;
        }

        public uint CRCOutcome
        {
            get => _verifyModel.crcOutcome;
            set
            {
                _verifyModel.crcOutcome = value;
                RaisePropertyChanged(nameof(CRCOutcome));
            }
        }
        #endregion


        #region Func
        private void UpdateCRCParamter(string crcAlgorithmsName)
        {
            CRCParamter cRCParamter = CRCUtil.GetCrcParamterFromDict(Enum.Parse<CRCCrcAlgorithm>(crcAlgorithmsName));

            this.CRCParamter = cRCParamter;
        }

        private void UpdateVerifyType(string verifyType)
        {
            VerifyType type = Enum.Parse<VerifyType>(verifyType);
            if (type != null)
                _verifyType = type;

        }
 
        //将字符流转化成字节流
        private byte[] ParseStringToByteArray(string inputString)
        {
            // 指定使用的编码格式
            Encoding encoding = Encoding.UTF8; // 根据你的需求选择合适的编码方式
            // 将字符串转换为字节数组
            byte[] byteArray = encoding.GetBytes(inputString);
            return byteArray;
        }
        //将十六进制字符流转化成字节流
        private byte[] HexStringToByteArray(string hexString)
        {
            // 去除可能的空格
            hexString = hexString.Replace(" ", "");

            // 检查输入是否为偶数长度，如果不是则补充最后一个字符
            if (hexString.Length % 2 != 0)
            {
                hexString = hexString.Substring(0, hexString.Length - 1) + "0" + hexString.Substring(hexString.Length - 1);
            }

            // 初始化字节数组
            byte[] byteArray = new byte[hexString.Length / 2];

            // 每两个字符为一组转换为一个字节
            for (int i = 0; i < byteArray.Length; i++)
            {
                string hexPair = hexString.Substring(i * 2, 2); // 获取两个字符
                byteArray[i] = Convert.ToByte(hexPair, 16); // 转换为字节
            }

            return byteArray;
        }
        /// <summary>
        /// 检查是否是16进制
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsHexadecimal(string input)
        {
            return Regex.IsMatch(input.Trim(), @"^[0-9A-Fa-f]+$");
        }
        /// <summary>
        /// 转化为xx xx xx xx的格式
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string FormatHex(string input)
        {
            // 去除可能的空格和非十六进制字符
            input = Regex.Replace(input, @"\s+", "");
            input = input.ToUpper(); // 转换为大写以保证 A-F 的正确性

            // 每两个字符加一个空格
            return string.Join(" ", Split(input, 2));
        }

        // 按指定长度分割字符串
        private string[] Split(string str, int chunkSize)
        {
            int numChunks = (int)Math.Ceiling((double)str.Length / chunkSize);
            string[] chunks = new string[numChunks];

            for (int i = 0; i < numChunks; i++)
            {
                int startIndex = i * chunkSize;
                if (startIndex + chunkSize <= str.Length)
                    chunks[i] = str.Substring(startIndex, chunkSize);
                else
                    chunks[i] = str.Substring(startIndex);
            }

            return chunks;
        }
        #endregion
        public VerifyViewModel()
        {
            DefaultSelectItem = CRCAlgorithms.First();
            DefaultVerifyItem = VerifyTypeList.First();
            _verifyType = Enum.Parse<VerifyType>(DefaultVerifyItem);
            this.CRCParamter = CRCUtil.GetCrcParamterFromDict(Enum.Parse<CRCCrcAlgorithm>(DefaultSelectItem));
        }

        #region Command
        public ICommand FormatDataContextCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (_verifyType != VerifyType.Hex || string.IsNullOrEmpty(DataContent))
                        return;
                    if (!IsHexadecimal(DataContent))
                    {
                        MessageBox.Show("数据格式不正确");
                    }

                    DataContent = FormatHex(DataContent);

                }, (s) => true);
            }
        }

        public ICommand ParseDataContextCommand
        {
            get => new RelayCommand(() =>
            {
                switch (_verifyType)
                {
                    case VerifyType.Hex:
                        if (string.IsNullOrEmpty(DataContent))
                        {
                            return;
                        }
                        if (!IsHexadecimal(DataContent.Replace(" ","")))
                        {
                            MessageBox.Show("格式错误");
                            break;
                        }
                        CRCOutcome = CRCUtil.Compute(HexStringToByteArray(DataContent), CRCParamter);
                        break;
                    case VerifyType.String:
                        if (string.IsNullOrEmpty(DataContent))
                        {
                            return;
                        }
                        CRCOutcome = CRCUtil.Compute(ParseStringToByteArray(DataContent), CRCParamter);
                        break;
                    case VerifyType.File:
                        if (FileInfo.Length > 0)
                        {
                            CRCOutcome = CRCUtil.Compute(FileInfo, CRCParamter);    
                        }
                        break;
                }

            }, (s) => true);
            #endregion


        }

        public enum VerifyType
        {
            String,
            Hex,
            File
        }
    }
}
