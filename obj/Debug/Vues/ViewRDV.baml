   M S B A M L   `   `   `  ����M  IProjetInfoToolsCRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjetInfoToolsCRMProjetInfoToolsCRM  5           ProjetInfoToolsCRM.ViewRDV   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ProjetInfoToolsCRM     5      
�������$��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5      .��5      � $��	10,0,10,0q�6    � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��250 �6   .+�5   
   �� -   5        $��ListViewRDVs��5   z   ���#2D3343$��0��6E   $��1q�6�   ���#37445F��6(   �� *RDVs+ �� View 5      �� 5      -   5        ClientsGrid��  myHeaderStyle! �� ColumnHeaderContainerStyle# [ 5   0   .P�5      �� $��ID��6%    �� Width$	 120��6Y    �� DisplayMemberBinding 62   �� *IdRDV+6Y   �� 5      $��Date RDV��6%   $	 160��6`    67   �� *	dateRDV+6`   �� 5      $��
Nom Client��6%   $	 130��6g    69   �� *MyClient.Nom+6g   �� 5      $��Prenom Client��6%   $	 130��6m    6<   �� *MyClient.Prenom+6m   �� 5      $��Nom Commercial��6%   $	 120��6r    6=   �� *MyCommercial.NomCom+6r   �� 5      $��Prenom Commercial��6%   $	 120��6x    6@   �� *MyCommercial.PrenomCom+6x   5      ��5       �� 5!       �� 
TargetType" ��6   .�5"      ��  �� Property � ��	 �� Value
	 �����63   �� 5#       � ��	 5$      �� 5%      
 �� 
TargetType"
 ��6.   .R�5&   "   ��  �� CornerRadius$ 2��6)    J� SnapsToDevicePixels . #��z��5'   !   #��z��5(   !   #��z��5)   !   ._�5*   &   �� $��InnerBorder��6-   $ 1��6@   $��1q�6Q   ._�5+   *   �  5,   .   �� 5-   2   $��11��6@   �� 5.   2   .+�51   .   �� $��UpperHighlight��68   $y�	Collapsed=�6N   ���	#75FFFFFF6e   �� 52   .   $��2��6C   #��z��53   -   # z 54   -   55   +   56   '   57   #    �� Triggers 58   "   P� 59   &    P� Property �@J�IsMouseOver P� Value . . �5:   *   ��  � ��
	 ���� 6G   �� 5;   *    � ��
	 �   �6H   �� 5<   *    �� 
TargetName$ UpperHighlight��61    � y�$	 Visible=�6c   5=   '   P� 5>   &    �@��
IsSelected . . �5?   *   ��  � ��
	 �   �6G   5@   '   P� 5A   &    � {� .  . �5B   *   �� #	 � ��6G    � ��5C   '   5E      5G      5H      5J      � 5L   
   $��1��6    � ColumnDefinitions 5M      �� 5N      $��* �6#   �� 5O      $��* �6#   �� 5P      $��* �6#   .+�5S      ��  �� Orientation$ Vertical=�6   $��0��60   $��10q�6@   .+�5T      �� 
�������.��6+   ID6/   �� 5U      -   5         ��Name$ TxtID��5U      {�.  6=   �� 5V      
�������.��6+   Date61   �� 5W      -   5        $ TxtDate��5W      6-   5X      �� 5Y      $ Vertical=�6   $��1��60   $��10q�6@   .+�5Z      �� 
�������.��6+   Client63   �� 5[      -   5         ��Name$
 CboC��5[      �� 5\      
�������.��6+   
Employé64   �� 5]      -   5        $
 CboE��5]      5^      � 5_      $��2��6    5`      �� 5a      $��* �6$   �� 5b      $��* �6$   �� 5c      $��* �6$   .+�5f      �� -   5        $��	BtnRDVAdd��5f   &   $��0��6   .��6P   	Ajouter6Y   �� 5g      -   5        $��BtnRDVUpdate��5g   &   $��1��6   .��6U   
Modifier6_   �� 5h      -	   5        $��BtnRDVDelete��5h   &   $��2��6   .��6U   	Supprimer6`   5i      5j      5l      5m      