   M S B A M L   `   `   `  ���� F  BWordsSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WordsSystemWordsSystem  [ WSystem.Data.SQLite, Version=1.0.112.1, Culture=neutral, PublicKeyToken=db937bc2d44ff139S<clr-namespace:System.Data.SQLite;assembly=System.Data.SQLiteSystem.Data.SQLite     WordsSystem.Manage_Dict   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WordsSystem     OSQLite<clr-namespace:System.Data.SQLite;assembly=System.Data.SQLite       � Title$  词库管理��$	��865��$	��800��.���  � ColumnDefinitions �� �� $	��20* ��� $	��20* ��� $
��121* ��� $
��638* �.+�&   System.Windows.Controls.DataGrid  -     Name$ datagrid��$��14,42,378,524q�   AutoGenerateColumns$ False��   RowHeaderWidth$ 0Q�$��3��$��2��   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value$ 16(���  � ��$ Center=�	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��   FontSize$ 16Q�   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $
 原文��$ 16Q�$ 80  �� *
Original+  $
 译文��$ 16Q�$ 80  �� *Translation+  $
 例句��$ 16Q�$ 80  �� *Explanation+  $
 释义��$ 16Q�$ 90  �� *	Example+�� -    ��Name$ Create_dict��$��创建词库��$
��Left=�$��508,130,0,0q�$	��Top=�$��16(�$��4���� -   $ Delete_dict��$��删除词库��$
��Left=�$��
508,52,0,0q�$	��Top=�$��16(�$��4���� -   $ Add_word��$$��为当前词库添加新单词��$
��Left=�$��282,734,0,0q�$	��Top=�$��16(�$��4��$��40��$	��194���� -   $ Delete_word��$��删除单词��$
��Left=�$��508,190,0,0q�$	��Top=�$��16(�$��4���� $!��删除当前选择的单词��$
��Left=�$��302,184,0,0q�$	��Top=�$��16(�$��4���� -    ��Name$ Current_dict��$
��Left=�$��
317,51,0,0q�$	��Top=�$	��120��$��16(�$��4���� -    ��Name$ L_current_dict��$��当前词库��$
��Left=�$��
317,16,0,0q�$	��Top=�$��16(�$��4���� -    ��Name$ Create_Table_Name��$
��Left=�$��317,131,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��16(�$��4���� $��输入新建表名��$
��Left=�$��
317,96,0,0q�$	��Top=�$��16(�$��4���� -	   $ 	Loriginal��$��原文��$��3��$
��Left=�$��	0,372,0,0q�$	��Top=�$��16(��� -
   $ 	Toriginal��$��2��$��3��$
��Left=�$��
61,376,0,0q�$
 Wrap=�$	��Top=�$	��293��$��16(��� -   $ Ltranslation��$��译文��$��4��$
��Left=�$��238,372,0,0q�$	��Top=�$��16(��� -   $ Ttranslation��$��4��$
��Left=�$��298,376,0,0q�$
 Wrap=�$	��Top=�$	��315��$��16(��� -   $ Lexplanation��$��释义��$��3��$
��Left=�$��	0,407,0,0q�$	��Top=�$��16(��� -   $ Texplanation��$��3��$
��Left=�$��
61,422,0,0q�$
 Wrap=�$	��Top=�$	��673��$��16(�$	��127��$��2���� -   $ Lexample��$��例句��$��3��$
��Left=�$��	0,561,0,0q�$	��Top=�$��16(��� -   $ Texample��$��3��$
��Left=�$��
61,576,0,0q�$
 Wrap=�$	��Top=�$	��673��$��16(�$	��124��$��2���� -   $ Bupdate��$��更新单词��$��4��$
��Left=�$��479,281,0,0q�$	��Top=�$��16(�$��45��$��97���� -   $ Bclean��$��清空��$��3��$
��Left=�$��
95,734,0,0q�$	��Top=�$��16(�$��2��$��40��$	��112���� -   $ Bselected_update_word��$��选择更新��$��4��$
��Left=�$��319,281,0,0q�$	��Top=�$��45��$��97��$��16(��� -   $ Lnotice��$����连续添加单词时以;间隔，所填选项若无，则留;即可。例如添加两个词，则所填选项都应有一个;。��
���  ��$��3��$
��Left=�$��
10,339,0,0q�$	��Top=�$��14(�$��2��$	��724��