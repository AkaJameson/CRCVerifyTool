   M S B A M L   `   `   `  ����L  HCRCVerifyTool_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CRCVerifyTool_WPF.ConvertersCRCVerifyTool_WPF.Converters  5   	   5clr-namespace:CRCVerifyTool_WPFCRCVerifyTool_WPF  5   	   "    CRCVerifyTool_WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ?converts*clr-namespace:CRCVerifyTool_WPF.Converters     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   1localclr-namespace:CRCVerifyTool_WPF     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	     � Title$  
MainWindow��5	   	   $	��800��5
   	   $	��450��5   	    � 
ResizeMode$ NoResize=�5   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
    � 	Resources 5      2   ,CRCVerifyTool_WPF.Converters.IntToHexConvert   IntToHexConvert��%   &	          5   
   6#   5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��9* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   $
��auto��5   #   $��16q�5   #      CornerRadius$ 10��5   #      Mode$ PrimaryDark=�5   #   .��5      ]� $��False��6   .+�5       �� $
��Left=�6    �� Orientation$ 
Horizontal=�63   .+�5"      �� $��16,0,0,0q�6    $��Center=�5#       $��CRC校验工具��5$       5&      �� 5'      -   5         ��Name$ btnClose��5'      $	��✕��5(      $��Right=�5)       ! MaterialDesignFlatLightButton#��[ 5*      �� 5+      -   5        $ btnMax��5+      $	��□��5,      $��Right=�5-      #��[ 5.      �� 5/      -   5        $ btnMin��5/      $	��−��50      $��Right=�51      #��[ 52      53      55      ]� 57   
   $��1��6   $
��True��6!   .+�59      �� $	��100��6   $��	10,0,0,10q�5:      .  (MaterialDesignThemes.Wpf.ColorZoneAssist	   
Background
	 �����
   
Foreground

 �����   Mode$ Custom=�5=      $
��Left=�5>      $��数据信息��5?      .��5@      �� $ Vertical=�6   .+�5A      �� $��算法选择 :��6    �� 5B      ��6   �� *CRCAlgorithms+ �� SelectedItem 6E   �� *DefaultSelectItem+ �� Mode$ TwoWay=��� 5C      $��多项式(Hex) :��6    �� 5D       �� 
IsReadOnly$
 True��6   ��60   �� *CRCParamter.Polynomial+ �� 	Converter# [  �� 5E      $��宽度位数(int) :��6    �� 5F      $
 True��6   ��60   �� *CRCParamter.BitWidth+�� 5G      $��初始值(Hex) :��6    �� 5H      $
 True��6   ��60   �� *CRCParamter.InitValue+# [  �� 5I      $��结果异或值(Hex) :��6    �� 5J      $
 True��6   ��60   �� *CRCParamter.XORValue+# [  �� 5K      $
��0,20q�6   $��输入反转��5L      ${�False��5N       d� 	IsChecked 5M      �� *CRCParamter.InputReverse+5N      �� 5O      $��输出反转��6   ${�False��5Q       5P      �� *CRCParamter.OutPutReverse+5Q      5R      5T      �� 5U      $	��500��6   $��	20,0,0,10q�5V      
	 �����

 �����$ Custom=�5Y      $��输入��5Z      .��5[      �� $	��250��6   $	��280��5\      $��Stretch=�5]      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$? 9请输入校验内容（注意区分string和Hex格式）��5^       �� AcceptsReturn$
 True��5_       �� 	IsEnabled$
 True��5a       �� TextWrapping$
 Wrap=�5c      " �� VerticalScrollBarVisibility$
 Auto=�5d      {�5`      �� *IsRichTextBoxEnable+��5b      �� *DataContent+5d      5e      �� 5f      $
��Left=�6   $ Vertical=�6/   .+�5g      �� $	��150��6   
	 �����

 �����$ Custom=�5j      $��操作��5k      .��5l      �� .+�5m      �� $��10q�6!   $��	格式化��5o   !    � Cursor$
 Hand��5p   !    $  MaterialDesignOutlinedDarkButton#��[ 5q   !    � ToolTip$" MaterialDesignOutlinedButton��5r   !   ��5n   !   �� *FormatDataContextCommand+5r   !   �� 5s      ��6#   �� *VerifyTypeList+ 6J   �� *DefaultVerifyItem+$ TwoWay=��� 5t      -   5        $ 
UploadFile��5t   !   $��10q�5u   !   $��上传文件��5w   !   #��[ 5y   !   $" MaterialDesignOutlinedButton��5z   !   {�5x   !   �� *IsUpLoadFileButtonShow+5z   !   �� 5{      $��10q�6!   $��解析��5}   !   #��[ 5~   !   $" MaterialDesignOutlinedButton��5   !   ��5|   !   �� *ParseDataContextCommand+5   !   5�      5�      �� 5�      $	��150��6   $	��110��5�      $��0,0,0,10q�5�      
	 �����

 �����$ Custom=�5�      $��校验结果��5�      .��5�      �� $��50��6   $��15(�5�      $
 True��5�      ��5�      �� *
CRCOutcome+# [  5�      5�      5�      5�      5�      