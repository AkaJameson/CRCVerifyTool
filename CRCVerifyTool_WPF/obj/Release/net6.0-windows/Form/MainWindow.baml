   M S B A M L   `   `   `  ���� L  HCRCVerifyTool_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CRCVerifyTool_WPF.ConvertersCRCVerifyTool_WPF.Converters  5clr-namespace:CRCVerifyTool_WPFCRCVerifyTool_WPF  "    CRCVerifyTool_WPF.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ?converts*clr-namespace:CRCVerifyTool_WPF.Converters     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:CRCVerifyTool_WPF     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$  
MainWindow��$	��800��$	��450�� � 
ResizeMode$ NoResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome    � 	Resources 2   ,CRCVerifyTool_WPF.Converters.IntToHexConvert   IntToHexConvert��%   &	          .���  � RowDefinitions �� $��2* ��� $��9* �.+�(  "MaterialDesignThemes.Wpf.ColorZone  $��0��$
��auto��$��16q�   CornerRadius$ 10��   Mode$ PrimaryDark=�.��]� $��False��.+��� $
��Left=� �� Orientation$ 
Horizontal=�.+��� $��16,0,0,0q�$��Center=�$��CRC校验工具���� -    ��Name$ btnClose��$	��✕��$��Right=� ! MaterialDesignFlatLightButton#��[ �� -   $ btnMax��$	��□��$��Right=�#��[ �� -   $ btnMin��$	��−��$��Right=�#��[ ]� $��1��$
��True��.+��� $	��100��$��	10,0,0,10q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist	   
Background
	 �����
   
Foreground

 �����   Mode$ Custom=�$
��Left=�$��数据信息��.���� $ Vertical=�.+��� $��算法选择 :���� ���� *CRCAlgorithms+ �� SelectedItem �� *DefaultSelectItem+ �� Mode$ TwoWay=��� $��多项式(Hex) :����  �� 
IsReadOnly$
 True������ *CRCParamter.Polynomial+ �� 	Converter# [  �� $��宽度位数(int) :���� $
 True������ *CRCParamter.BitWidth+�� $��初始值(Hex) :���� $
 True������ *CRCParamter.InitValue+# [  �� $��结果异或值(Hex) :���� $
 True������ *CRCParamter.XORValue+# [  �� $
��0,20q�$��输入反转��${�False�� d� 	IsChecked �� *CRCParamter.InputReverse+�� $��输出反转��${�False�� �� *CRCParamter.OutPutReverse+�� $	��500��$��	20,0,0,10q�
	 �����

 �����$ Custom=�$��输入��.���� $	��250��$	��280��$��Stretch=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$? 9请输入校验内容（注意区分string和Hex格式）�� �� AcceptsReturn$
 True�� �� 	IsEnabled$
 True�� �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�{��� *IsRichTextBoxEnable+���� *DataContent+�� $
��Left=�$ Vertical=�.+��� $	��150��
	 �����

 �����$ Custom=�$��操作��.���� .+��� $��10q�$��	格式化�� � Cursor$
 Hand�� $  MaterialDesignOutlinedDarkButton#��[  � ToolTip$" MaterialDesignOutlinedButton������ *FormatDataContextCommand+�� ���� *VerifyTypeList+ �� *DefaultVerifyItem+$ TwoWay=��� -   $ 
UploadFile��$��10q�$��上传文件��#��[ $" MaterialDesignOutlinedButton��{��� *IsUpLoadFileButtonShow+�� $��10q�$��解析��#��[ $" MaterialDesignOutlinedButton������ *ParseDataContextCommand+�� $	��150��$	��110��$��0,0,0,10q�
	 �����

 �����$ Custom=�$��校验结果��.���� $��50��$��15(�$
 True������ *
CRCOutcome+# [  