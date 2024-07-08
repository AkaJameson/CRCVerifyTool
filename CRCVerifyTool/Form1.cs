using System.Text;
using System.Text.RegularExpressions;
using Xin.DotnetUtil.Verify.CRC;
namespace CRCVerifyTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Name = "CRCVerifyTool";
            this.Text = "CRCУ�鹤��";
            List<string> CRCCal_Func = new List<string>();

            foreach (CRCCrcAlgorithm crcAgl in Enum.GetValues(typeof(CRCCrcAlgorithm)))
            {
                CRCCal_Func.Add(crcAgl.ToString());
            }
            standardCrcType_cmb.Items.AddRange(CRCCal_Func.ToArray());
            standardCrcType_cmb.SelectedIndex = 0;
            dataType_cmb.DataSource = dataTypeItems;
            dataType_cmb.DisplayMember = "Name";
            dataType_cmb.ValueMember = "dataType";
            

        }

        private void standardCrcType_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CRCCrcAlgorithm selectItem = Enum.Parse<CRCCrcAlgorithm>(standardCrcType_cmb.SelectedItem as string);
            paramter = CRCUtil.GetCrcParamterFromDict(selectItem);

            //��text��ֵ
            //�����uintת����Hex��ʶ��string
            this.poly_text.Text = "0x" + paramter.Polynomial.ToString("X4");
            this.bitWidth_text.Text = paramter.BitWidth.ToString();
            this.initValue_text.Text = "0x" + paramter.InitValue.ToString("X4");
            this.xor_value.Text = "0x" + paramter.XORValue.ToString("X4");
            this.inputReverse_cb.Checked = paramter.InputReverse;
            this.outPutReverse_cb.Checked = paramter.OutPutReverse;
        }

        private void Parse_btn_Click(object sender, EventArgs e)
        {
            if ((dataType_cmb.SelectedItem as DataTypeItem).dataType.Equals(DataType.STRING))
            {
                verifyByte = ParseStringToByteArray(dataField.Text);
            }
            if ((dataType_cmb.SelectedItem as DataTypeItem).dataType.Equals(DataType.HEX))
            {
                verifyByte = HexStringToByteArray(dataField.Text);
            }
            CRCCrcAlgorithm algorithm = Enum.Parse<CRCCrcAlgorithm>(standardCrcType_cmb.SelectedItem as string);
            this.verifyoutCom_text.Text = "0x" + CRCUtil.Compute(verifyByte, algorithm).ToString("X4");

        }
        private void format_btn_Click(object sender, EventArgs e)
        {
            if ((dataType_cmb.SelectedItem as DataTypeItem).dataType.Equals(DataType.STRING))
            {
                return;
            }
            string input = dataField.Text.Trim();
            if (!IsHexadecimal(input))
            {
                MessageBox.Show("�����ʽ����");
                return;
            }

            string formatter = FormatHex(input);
            dataField.Text = formatter;
        }

        private byte[] ParseStringToByteArray(string inputString)
        {
            // ָ��ʹ�õı����ʽ
            Encoding encoding = Encoding.UTF8; // �����������ѡ����ʵı��뷽ʽ
            // ���ַ���ת��Ϊ�ֽ�����
            byte[] byteArray = encoding.GetBytes(inputString);
            return byteArray;
        }
        private byte[] HexStringToByteArray(string hexString)
        {
            // ȥ�����ܵĿո�
            hexString = hexString.Replace(" ", "");

            // ��������Ƿ�Ϊż�����ȣ���������򲹳����һ���ַ�
            if (hexString.Length % 2 != 0)
            {
                hexString = hexString.Substring(0, hexString.Length - 1) + "0" + hexString.Substring(hexString.Length - 1);
            }

            // ��ʼ���ֽ�����
            byte[] byteArray = new byte[hexString.Length / 2];

            // ÿ�����ַ�Ϊһ��ת��Ϊһ���ֽ�
            for (int i = 0; i < byteArray.Length; i++)
            {
                string hexPair = hexString.Substring(i * 2, 2); // ��ȡ�����ַ�
                byteArray[i] = Convert.ToByte(hexPair, 16); // ת��Ϊ�ֽ�
            }

            return byteArray;
        }
        /// <summary>
        /// ����Ƿ���16����
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsHexadecimal(string input)
        {
            return Regex.IsMatch(input, @"^[0-9A-Fa-f]+$");
        }
        /// <summary>
        /// ת��Ϊxx xx xx xx�ĸ�ʽ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string FormatHex(string input)
        {
            // ȥ�����ܵĿո�ͷ�ʮ�������ַ�
            input = Regex.Replace(input, @"\s+", "");
            input = input.ToUpper(); // ת��Ϊ��д�Ա�֤ A-F ����ȷ��

            // ÿ�����ַ���һ���ո�
            return string.Join(" ", Split(input, 2));
        }

        // ��ָ�����ȷָ��ַ���
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
        private void dataType_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((dataType_cmb.SelectedItem as DataTypeItem).dataType == DataType.File)
            {
                this.dataField.Enabled = false;
                this.format_btn.Enabled = false;
                this.uploadFile_btn.Visible = true;
            }
            else
            {
                this.dataField.Enabled = true;
                this.format_btn.Enabled = true;
                this.uploadFile_btn.Visible = false;
            }

        }

        private void uploadFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "ѡ����Ҫ�ϴ����ļ�";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            DialogResult fileResult = openFileDialog.ShowDialog();
            if (fileResult == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                if (fileInfo.Length > 2000)
                {
                    MessageBox.Show("�ļ�̫���ˣ���ȡ�ļ�ʧ��");
                    return;
                }
                verifyByte = File.ReadAllBytes(openFileDialog.FileName);

                MessageBox.Show("��ȡ�ļ��ɹ�");
            }
        }


        #region Var
        List<DataTypeItem> dataTypeItems = new List<DataTypeItem>()
        {
            new DataTypeItem{dataType = DataType.STRING, Name = "�ַ���"},
            new DataTypeItem{dataType = DataType.HEX,Name = "HEX"},
            new DataTypeItem{dataType = DataType.File,Name = "�ļ�"}
        };
        CRCParamter paramter;
        byte[] verifyByte;

        ResponsiveLayout responsiveLayout ;
        #endregion


   

        private void Form1_Resize(object sender, EventArgs e)
        {
            /*responsiveLayout.ResizeWindowLayout(this);*/

        }
    }


}
