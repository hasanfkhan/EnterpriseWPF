   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   H DEnterpriseWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EnterpriseWPFEnterpriseWPF 5   	       EnterpriseWPF.DataGridDemo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7core&clr-namespace:System;assembly=mscorlib     5   	   -localclr-namespace:EnterpriseWPF     5   	     � Title$  DataGridDemo��5   	   $	��300��6   $	��400��6+    � 	Resources 5       
  myEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� Type  EnterpriseWPF.Party��%j   &	        S� 5   
   $ 	GetValues��6,   "  6C    5	      M� 5
      "  6   6.   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5         AlternatingRowBackground
 ����� �� AlternationCount$ 2��6K      AutoGenerateColumns .  $	��400��6|   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $
 Title��6%    64   �� *Title+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 
Reelected?��6)    6=   �� *WasReelected+4  .System.Windows.Controls.DataGridComboBoxColumn  5      $
 Party��6)      SelectedItemBinding 68   �� *Affiliation+   ItemsSource 6d   ��  �� Source# [  5      5      5      