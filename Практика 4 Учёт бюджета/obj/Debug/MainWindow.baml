   M S B A M L   `   `   `  ����.  *Практика 4 Учёт бюджета    BudgetApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Budget App��5   	   $	��450��6   $	��800��6)   .��5      � .+�5	   
   &   System.Windows.Controls.DataGrid  -   5          Name$ budgetDataGrid��5	         AutoGenerateColumns .     Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $
 Type��6%    63   �� *Type+  5      $ Amount��6%    65   �� *Amount+  5      $ IsIncome��6%    67   �� *
IsIncome+  5      $
 Date��6%    63   �� *Date+5      5      5      