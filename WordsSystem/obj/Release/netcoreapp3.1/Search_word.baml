   M S B A M L   `   `   `  ���� F  BWordsSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WordsSystemWordsSystem      WordsSystem.Search_word   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WordsSystem       � Title$  单词搜索��$	��778��$	��846��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ datagrid��$��14,89,22,124q�   AutoGenerateColumns$ False��   RowHeaderWidth$ 0Q�   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value$ 16(���  � ��$ Center=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 原文��
   FontSize$
 16Q�   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Original+  $	 译文��$
 16Q�$	 150  �� *Translation+  $	 释义��$
 16Q�$	 250  �� *Explanation+  $	 例句��$
 16Q�$	 260  �� *	Example+   RowDetailsTemplate �� .R��� $��0q�
������� �� Padding$ 10q�._���  �� Orientation$ Vertical=�.+��� $ 
Horizontal=�.+��� $��16(�$��	原文：��$��Center=��� $��16(�$��Center=����� *
Original+�� $ 
Horizontal=�.+��� $��16(�$��	译文：��$��Center=��� $��16(�$��Center=����� *Translation+�� $ 
Horizontal=�.+��� $��16(�$��	释义：��$��Center=��� $��16(�$��Center=����� *Explanation+�� $ 
Horizontal=�.+��� $��16(�$��	例句：��$��Center=��� $��16(�$��Center=����� *	Example+�� -    ��Name$ Tsearch��$��79,0,423,50q� �� TextWrapping$
 Wrap=�$��20(�$��Bottom=��� -    ��Name$ Bsearch_original��$��按原文搜��$��502,0,228,38q�$��18(�$��51��$��Bottom=��� -    ��Name$ Lcurrent_dict��$��当前词库:��$
��Left=�$��
303,35,0,0q�$	��Top=�$��16(��� -    ��Name$ CB_current_dict��$
��Left=�$��
423,35,0,0q�$	��Top=�$	��120��$��16(��� -   $ Bsearch_translation��$��按译文搜��$��662,0,80,38q�$��18(�$��51��$��Bottom=�