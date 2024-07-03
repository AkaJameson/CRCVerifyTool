namespace CRCVerifyTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Parse_btn = new Button();
            format_btn = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            verifyoutCom_text = new TextBox();
            dataField = new RichTextBox();
            groupBox3 = new GroupBox();
            outPutReverse_cb = new CheckBox();
            inputReverse_cb = new CheckBox();
            groupBox2 = new GroupBox();
            xor_value = new TextBox();
            initValue_text = new TextBox();
            bitWidth_text = new TextBox();
            poly_text = new TextBox();
            standardCrcType_cmb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            uploadFile_btn = new Button();
            label6 = new Label();
            dataType_cmb = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // Parse_btn
            // 
            Parse_btn.BackgroundImageLayout = ImageLayout.Center;
            Parse_btn.Location = new Point(16, 35);
            Parse_btn.Margin = new Padding(2, 3, 2, 3);
            Parse_btn.Name = "Parse_btn";
            Parse_btn.Size = new Size(73, 25);
            Parse_btn.TabIndex = 1;
            Parse_btn.Text = "解析";
            Parse_btn.UseVisualStyleBackColor = true;
            Parse_btn.Click += Parse_btn_Click;
            // 
            // format_btn
            // 
            format_btn.BackgroundImageLayout = ImageLayout.Center;
            format_btn.Location = new Point(16, 82);
            format_btn.Margin = new Padding(2, 3, 2, 3);
            format_btn.Name = "format_btn";
            format_btn.Size = new Size(73, 25);
            format_btn.TabIndex = 2;
            format_btn.Text = "格式化";
            format_btn.UseVisualStyleBackColor = true;
            format_btn.Click += format_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(dataField);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(135, 21);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(375, 322);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "输入";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(verifyoutCom_text);
            groupBox4.Location = new Point(201, 264);
            groupBox4.Margin = new Padding(2, 3, 2, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 3, 2, 3);
            groupBox4.Size = new Size(194, 54);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "校验结果";
            // 
            // verifyoutCom_text
            // 
            verifyoutCom_text.Location = new Point(5, 22);
            verifyoutCom_text.Margin = new Padding(2, 3, 2, 3);
            verifyoutCom_text.Name = "verifyoutCom_text";
            verifyoutCom_text.ReadOnly = true;
            verifyoutCom_text.Size = new Size(98, 23);
            verifyoutCom_text.TabIndex = 0;
            // 
            // dataField
            // 
            dataField.Location = new Point(5, 31);
            dataField.Margin = new Padding(2, 3, 2, 3);
            dataField.Name = "dataField";
            dataField.Size = new Size(382, 228);
            dataField.TabIndex = 9;
            dataField.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(outPutReverse_cb);
            groupBox3.Controls.Add(inputReverse_cb);
            groupBox3.Location = new Point(5, 264);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(191, 54);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "数据反转";
            // 
            // outPutReverse_cb
            // 
            outPutReverse_cb.AutoSize = true;
            outPutReverse_cb.Enabled = false;
            outPutReverse_cb.Location = new Point(78, 20);
            outPutReverse_cb.Margin = new Padding(2, 3, 2, 3);
            outPutReverse_cb.Name = "outPutReverse_cb";
            outPutReverse_cb.Size = new Size(75, 21);
            outPutReverse_cb.TabIndex = 1;
            outPutReverse_cb.Text = "输出反转";
            outPutReverse_cb.UseVisualStyleBackColor = true;
            // 
            // inputReverse_cb
            // 
            inputReverse_cb.AutoSize = true;
            inputReverse_cb.Enabled = false;
            inputReverse_cb.Location = new Point(2, 20);
            inputReverse_cb.Margin = new Padding(2, 3, 2, 3);
            inputReverse_cb.Name = "inputReverse_cb";
            inputReverse_cb.Size = new Size(75, 21);
            inputReverse_cb.TabIndex = 0;
            inputReverse_cb.Text = "输入反转";
            inputReverse_cb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(xor_value);
            groupBox2.Controls.Add(initValue_text);
            groupBox2.Controls.Add(bitWidth_text);
            groupBox2.Controls.Add(poly_text);
            groupBox2.Controls.Add(standardCrcType_cmb);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(9, 21);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(121, 322);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据信息";
            // 
            // xor_value
            // 
            xor_value.Location = new Point(5, 264);
            xor_value.Margin = new Padding(2, 3, 2, 3);
            xor_value.Name = "xor_value";
            xor_value.ReadOnly = true;
            xor_value.Size = new Size(109, 23);
            xor_value.TabIndex = 8;
            // 
            // initValue_text
            // 
            initValue_text.Location = new Point(5, 209);
            initValue_text.Margin = new Padding(2, 3, 2, 3);
            initValue_text.Name = "initValue_text";
            initValue_text.ReadOnly = true;
            initValue_text.Size = new Size(109, 23);
            initValue_text.TabIndex = 7;
            // 
            // bitWidth_text
            // 
            bitWidth_text.Location = new Point(5, 152);
            bitWidth_text.Margin = new Padding(2, 3, 2, 3);
            bitWidth_text.Name = "bitWidth_text";
            bitWidth_text.ReadOnly = true;
            bitWidth_text.Size = new Size(109, 23);
            bitWidth_text.TabIndex = 6;
            // 
            // poly_text
            // 
            poly_text.Location = new Point(5, 101);
            poly_text.Margin = new Padding(2, 3, 2, 3);
            poly_text.Name = "poly_text";
            poly_text.ReadOnly = true;
            poly_text.Size = new Size(109, 23);
            poly_text.TabIndex = 5;
            // 
            // standardCrcType_cmb
            // 
            standardCrcType_cmb.FormattingEnabled = true;
            standardCrcType_cmb.Location = new Point(5, 50);
            standardCrcType_cmb.Margin = new Padding(2, 3, 2, 3);
            standardCrcType_cmb.Name = "standardCrcType_cmb";
            standardCrcType_cmb.Size = new Size(112, 25);
            standardCrcType_cmb.TabIndex = 2;
            standardCrcType_cmb.SelectedIndexChanged += standardCrcType_cmb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 235);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 4;
            label5.Text = "结果异或值(Hex):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 184);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 3;
            label4.Text = "初始值(Hex):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 133);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 2;
            label3.Text = "宽度位数(int):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "多项式(Hex):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "算法选择:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(uploadFile_btn);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(dataType_cmb);
            groupBox5.Controls.Add(Parse_btn);
            groupBox5.Controls.Add(format_btn);
            groupBox5.Location = new Point(519, 21);
            groupBox5.Margin = new Padding(2, 3, 2, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 3, 2, 3);
            groupBox5.Size = new Size(94, 322);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "操作";
            // 
            // uploadFile_btn
            // 
            uploadFile_btn.BackgroundImageLayout = ImageLayout.Center;
            uploadFile_btn.Location = new Point(16, 207);
            uploadFile_btn.Margin = new Padding(2, 3, 2, 3);
            uploadFile_btn.Name = "uploadFile_btn";
            uploadFile_btn.Size = new Size(73, 25);
            uploadFile_btn.TabIndex = 5;
            uploadFile_btn.Text = "上传文件";
            uploadFile_btn.UseVisualStyleBackColor = true;
            uploadFile_btn.Visible = false;
            uploadFile_btn.Click += uploadFile_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 4;
            label6.Text = "数据格式:";
            // 
            // dataType_cmb
            // 
            dataType_cmb.FormattingEnabled = true;
            dataType_cmb.Location = new Point(16, 142);
            dataType_cmb.Margin = new Padding(2, 3, 2, 3);
            dataType_cmb.Name = "dataType_cmb";
            dataType_cmb.Size = new Size(74, 25);
            dataType_cmb.TabIndex = 3;
            dataType_cmb.SelectedIndexChanged += dataType_cmb_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 382);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Parse_btn;
        private Button format_btn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private CheckBox inputReverse_cb;
        private ComboBox standardCrcType_cmb;
        private CheckBox outPutReverse_cb;
        private TextBox xor_value;
        private TextBox initValue_text;
        private TextBox bitWidth_text;
        private TextBox poly_text;
        private RichTextBox dataField;
        private GroupBox groupBox4;
        private TextBox verifyoutCom_text;
        private GroupBox groupBox5;
        private ComboBox dataType_cmb;
        private Label label6;
        private Button uploadFile_btn;
    }
}
