   M S B A M L   `   `   `  ����M  IProjetInfoToolsCRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjetInfoToolsCRMProjetInfoToolsCRM  5      $    ProjetInfoToolsCRM.ViewFacture   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ProjetInfoToolsCRM     5      
�������$��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5      .��5      � $��	10,0,10,0q�6    � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��250 �6   .+�5   
   �� -   5        $��ListViewFactures��5   �   ���#2D3343$��0��6I   $��0,0,0,1q�6�   ���#37445F��6(   �� *
Factures+ �� View 5      �� 5      -   5        ClientsGrid��  myHeaderStyle! �� ColumnHeaderContainerStyle# [ 5   0   .P�5      �� $��ID��6%    �� Width$ 80��6]    �� DisplayMemberBinding 62   �� *	IdFacture+6]   �� 5      $	��Nom��6%   $ 80��6`    62   �� *MyClient.Nom+6`   �� 5      $��Prenom��6%   $ 80��6f    65   �� *MyClient.Prenom+6f   5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value
	 �����63   �� 5        � ��	 5!      �� 5"      
 �� 
TargetType"
 ��6.   .R�5#   "   ��  �� CornerRadius$ 2��6)    J� SnapsToDevicePixels . #��z��5$   !   #��z��5%   !   #��z��5&   !   ._�5'   &   �� $��InnerBorder��6-   $ 1��6@   $��1q�6Q   ._�5(   *   �  5)   .   �� 5*   2   $��11��6@   �� 5+   2   .+�5.   .   �� $��UpperHighlight��68   $y�	Collapsed=�6N   ���	#75FFFFFF6e   �� 5/   .   $��2��6C   #��z��50   -   # z 51   -   52   +   53   '   54   #    �� Triggers 55   "   P� 56   &    P� Property �@J�IsMouseOver P� Value . . �57   *   ��  � ��
	 ���� 6G   �� 58   *    � ��
	 �   �6H   �� 59   *    �� 
TargetName$ UpperHighlight��61    � y�$	 Visible=�6c   5:   '   P� 5;   &    �@��
IsSelected . . �5<   *   ��  � ��
	 �   �6G   5=   '   P� 5>   &    � {� .  . �5?   *   �� #	 � ��6G    � ��5@   '   5B      5D      5E      5G      � 5I   
   $��1��6    � ColumnDefinitions 5J      �� 5K      $��* �6#   �� 5L      $��* �6#   �� 5M      $��* �6#   .+�5P      ��  �� Orientation$ Vertical=�6   $��0��60   $��10q�6@   .+�5Q      �� 
�������.��6+   ID6/   �� 5R      -   5         ��Name$ TxtID��5R      {�.  6=   5S      �� 5T      $ Vertical=�6   $��1��60   $��10q�6@   .+�5U      �� 
�������.��6+   Client63   �� 5V      -   5         ��Name$
 CboC��5V      5W      � 5X      $��2��6    5Y      �� 5Z      $��* �6$   �� 5[      $��* �6$   �� 5\      $��* �6$   .+�5_      �� -   5        $��BtnFactureAdd��5_   &   $��0��6   .��6W   	Ajouter6`   �� 5`      -   5        $��BtnFactureUpdate��5`   &   $��1��6   .��6]   
Modifier6g   �� 5a      -   5        $��BtnFactureDelete��5a   &   $��2��6   .��6]   	Supprimer6h   5b      5c      5e      5f      