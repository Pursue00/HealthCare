   M S B A M L   `   `   `  ����E  AHealthCare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HealthCare.CommonHealthCare.Common  5          HealthCare.Views.Login   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2commonclr-namespace:HealthCare.Common     5      -   5          N� Title$  医疗健康��5	       N� 
Background 5
      �� 5   
    �� ImageSource$+ %pack://siteoforigin:,,,/Images/bg.jpg��6   .��5      �� 
�������$	��0.5q�6     �� CornerRadius$ 2��67   $��Center=�6H   $��Center=�6e   $	��413��6�   $	��316��6�   ._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6   �� 5      $��* �6   .+�5      � $��0q�6   ���#0F9FDC.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�67   $��Center=�6T   .+�5      �� $��28��6   $��30��6'   $1��+pack://siteoforigin:,,,/Images/shouyyys.png��63   �� 5      $��试片室登录��6    $��30(�6-   $
��Bold"�6;   
�������$��10 0 0 0q�6`   5      5      �� 5      -   5         ��Name$ canvas��5      $��1��6%   
�������.+�5      �� -   5         ��Name$ tbName��5      $��	用户名��6,   
���   �$��18(�6J   $��60��6X   $��36��6c    �� Left$ 66��6o   
	 �� Top$	 38��6�   6�   �� 5      -   5        $ 
tbPassWord��5      $��	密   码��60   
���   �$��18(�6P   $��60��6^   $��36��6i   $ 66��6u   $	 90��6�   6�   �� 5      -   5        
 ��Name$
 tb��5      
���   �$��18(�69   $	��234��6G   $��36��6S   $	 132��6_   $	 34��6q   $
��Left=�6�   $��Center=�6�   ��5      �� *
UserName+62   G� 5!      -   5         G�Name$ pb��5!      
���   �$��18(�5"   .   $	��234��6<   $��36��6H   $	 132��6T   $	 85��6f   $
��Left=�6v   $��Center=�6�   5#   C   �� 5$      -   5         ��Name$ btnLogin��5$      $��登  录��6+   $��18(�6:   
�������$	��131��6[   $��36��6g   $ 62��6s   $		 164��6�      ButtonLoginStyle#��[  5%      $��login��6^   ��6?   �� *
BtnCommand+6y   �� 5&      -   5        $ 	btnCancel��5&      $��取  消��6,   $��18(�6;   
�������$	��131��6\   $��36��6h   $	 230��6t   $		 164��6�     ButtonCancelStyle#��[ 5'      $��cancel��6_   ��6@   �� *
BtnCommand+6{   5(      5)      5*      5+      