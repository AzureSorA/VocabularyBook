   M S B A M L   `   `   `  ����F  BWordsSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WordsSystemWordsSystem  5   	       WordsSystem.Search_word   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WordsSystem     5   	     � Title$  单词搜索��5   	   $	��778��6   $	��846��6#   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5
      $��14,89,22,124q�6%      AutoGenerateColumns$ False��6;      RowHeaderWidth$ 0Q�6W      ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value$ 16(�61   �� 5       � ��$ Center=�6C   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 原文��6%   
   FontSize$
 16Q�6N      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
Original+6\     5      $	 译文��6%   $
 16Q�6Q   $	 150 6_    61   �� *Translation+6_     5      $	 释义��6%   $
 16Q�6Q   $	 250 6_    61   �� *Explanation+6_     5      $	 例句��6%   $
 16Q�6M   $	 260 6[    61   �� *	Example+6[      RowDetailsTemplate 5      �� 5      .R�5      �� $��0q�6   
������� �� Padding$ 10q�6D   ._�5      ��  �� Orientation$ Vertical=�6%   .+�5      �� $ 
Horizontal=�6)   .+�5   "   �� $��16(�6,   $��	原文：��6:   $��Center=�6E   �� 5   "   $��16(�6,   $��Center=�6T   ��6:   �� *
Original+6T   5      �� 5       $ 
Horizontal=�6)   .+�5!   "   �� $��16(�6,   $��	译文：��6:   $��Center=�6E   �� 5"   "   $��16(�6,   $��Center=�6W   ��6:   �� *Translation+6W   5#      �� 5$      $ 
Horizontal=�6)   .+�5%   "   �� $��16(�6,   $��	释义：��6:   $��Center=�6E   �� 5&   "   $��16(�6,   $��Center=�6W   ��6:   �� *Explanation+6W   5'      �� 5(      $ 
Horizontal=�6)   .+�5)   "   �� $��16(�6,   $��	例句：��6:   $��Center=�6E   �� 5*   "   $��16(�6,   $��Center=�6S   ��6:   �� *	Example+6S   5+      5,      5-      5.      51      �� 52   
   -   5         ��Name$ Tsearch��52      $��79,0,423,50q�6#    �� TextWrapping$
 Wrap=�68   $��20(�6L   $��Bottom=�6Z   �� 53   
   -   5         ��Name$ Bsearch_original��53      $��按原文搜��6+   $��502,0,228,38q�6:   $��18(�6P   $��51��6^   $��Bottom=�6j   6�   �� 54   
   -   5         ��Name$ Lcurrent_dict��54      $��当前词库:��6'   $
��Left=�67   $��
303,35,0,0q�6R   $	��Top=�6f   $��16(�6~   �� 55   
   -   5         ��Name$ CB_current_dict��55      $
��Left=�6,   $��
423,35,0,0q�6G   $	��Top=�6[   $	��120��6s   $��16(�6   6�   �� 56   
   -   5        $ Bsearch_translation��56      $��按译文搜��6.   $��662,0,80,38q�6=   $��18(�6R   $��51��6�   $��Bottom=�6�   57      58      