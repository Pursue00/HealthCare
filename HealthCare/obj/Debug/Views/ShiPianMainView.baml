   M S B A M L   `   `   `  ����  
HealthCare&     HealthCare.Views.ShiPianMainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ShiPianMainView��5      .��5	      � $
��Auto��6   $
��Auto��6   $��Stretch=�6&   $��Stretch=�6D    � ColumnDefinitions 5
   
   �� 5      $��5 �6   �� 5      $��* �6   .+�5   
   � ���#EFF3FB$��0��6$   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $��78 �6    �� 5      $��68 �6    �� 5      $��* �6    .+�5      � -   5         �Name$ gridTop��5      $��0��6$   ��5      �� 5       �� ImageSource$7 1pack://siteoforigin:,,,/Images/lansebeijingtu.png��6!   .+�5      �� $<��6中华医学会第二十次全国心血管病学年会��6   $��SimSun)�66   $��36(�6J   
�������$��Center=�6k   $
��Left=�6�   $��35 0 0 0q�6�   �� 5         ButtonChineseStyle#��[  6   $��Right=�6E   $��Center=�6b   $��	0 0 100 0q�6~   $��中  文��5      $��16(�6(   
����  �$��60��6I   $��36��6T   �� 5        ButtonEnglishStyle#��[ 6   $��Right=�6E   $��Center=�6b   $��0 0 10 0q�6~   $��English��5      $��16(�6+   
���   �$��70��6M   $��36��6X   5       � 5!      -   5        $ 
gridComBox��5!      $��1��6'   ���#F1F7FB.+�5"      �� $��姓名��6   $%��Fonts/Fonts.zip#Microsoft YaHei)�6&   $��20(�6S   ���#333333$��	35 28 0 0q�6v   $
��Left=�5#      $	��Top=�67   �� 5$      $	��190��6   $��30��6&   $
��Left=�62   $	��Top=�6M   $��	90 24 0 0q�6e   �� 5%      $��日期��6   $%��Fonts/Fonts.zip#Microsoft YaHei)�6&   $��20(�6S   ���#333333$��
320 28 0 0q�6v   $
��Left=�5&      $	��Top=�67   �� 5'        ComboBoxStyle#��[ 6   $	��190��6B   $��30��6N   $��
380 24 0 0q�6Z   $
��Left=�6n   $	��Top=�6�   �� 5(      $��会场��6   $%��Fonts/Fonts.zip#Microsoft YaHei)�6&   $��20(�6S   ���#333333$��
610 28 0 0q�6v   $
��Left=�5)      $	��Top=�67   �� 5*      #��[ 6   $	��190��6B   $��30��6N   $
��Left=�6Z   $��
670 24 0 0q�6u   $	��Top=�6�   �� 5+      $��是否提交��6   $%��Fonts/Fonts.zip#Microsoft YaHei)�6(   $��20(�6U   ���#333333$��
890 28 0 0q�6x   $
��Left=�5,      $	��Top=�67   �� 5-      #��[ 6   $	��190��6B   $��30��6N   $
��Left=�6Z   $��
990 24 0 0q�6u   $	��Top=�6�   �� 5.        ButtonSubmmitStyle#��[ 6   $
��Left=�6E   $��Center=�6`   $��
1220 0 0 0q�6|   $��提  交��5/      $��18(�6(   
�������$	��131��6I   $��36��6U   50      � 51      -   5        $ 
gridButton��51      $��2��6'   .+�52      �� #��[ 6   $��Right=�6E   $��Center=�6b   $��	0 0 296 0q�6~   $��修改日程��53      $��18(�6(   
�������$	��131��6I   $��36��6U   �� 54      #��[ 6   $��Right=�6E   $��Center=�6b   $��	0 0 154 0q�6~   $��打  印��55      $��18(�6(   
�������$	��131��6I   $��36��6U   �� 56        ButtonNotificationsStyle#��[ 6   $��Right=�6K   $��Center=�6h   $��0 0 10 0q�6�   $��发布通知��57      $��18(�6(   
�������$	��131��6I   $��36��6U   58      � 59      -   5        $ gridDataGrid��59      $��3��6)   .+�5:      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGird��5:        dataGridStyle#��[ 6-      AutoGenerateColumns .  $	��Top=�6�   $��Stretch=�6�      CanUserSortColumns .  $
��Auto��5;   /   $
��Auto��6<   $��5q�6K      
IsReadOnly . 	   CanUserResizeColumns	 .  
   CanUserResizeRows
 .     SelectionMode$ Single=�5<   K      CanUserReorderColumns .   �� AlternationCount$ 2��5=   1      RowHeaderWidth$ 0Q�6G      CanUserAddRows .  ��5:   U   ��  �� Path$ ScheduleCollection�   Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Id+  5@      $ 会场��6-   $	 120 6;    6H   �� *Togeter_hall+  5A      $ 日期��6-   $	 120 6:    6G   �� *Togeter_date+  5B      $ 时间��6-   $	 130 6:    6G   �� *Zf+  5C      $ 题目��6-   $	 140 6:    6G   �� *Dxqsg+  5D      $ 讲者��6-   $	 150 69    6F   �� *Name+  5E      $ 状态��6-   $	 120 6;    6H   �� *Zxj+  5F      $ 视频��6-   $	 120 6:    6G   �� *
have_video+  5G      $ 简介��6-   $	 130 6:    6G   �� *Zf+  5H      $ 预览��6-   $	 140 6:    6G   �� *Dxqsg+5J      5K      5L      5M      5N      