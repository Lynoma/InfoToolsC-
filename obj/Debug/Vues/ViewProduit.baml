   M S B A M L   `   `   `  ����M  IProjetInfoToolsCRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjetInfoToolsCRMProjetInfoToolsCRM  5      $    ProjetInfoToolsCRM.ViewProduit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ProjetInfoToolsCRM     5      
�������$��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5      .��5      � $��	10,0,10,0q�6    � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��250 �6   .+�5   
   �� -   5        $��ListViewProduits��5   �   ���#2D3343$��0��6I   $��0,0,0,1q�6�   ���#37445F��6(   �� *
Produits+ �� View 5      �� 5      -   5        ClientsGrid��  myHeaderStyle! �� ColumnHeaderContainerStyle# [ 5   0   .P�5      �� $��ID��6%    �� Width$ 80��6Z    �� DisplayMemberBinding 62   �� *IdProd+6Z   �� 5      $	��Nom��6%   $ 80��6[    62   �� *	NomProd+6[   �� 5      $��Description��6%   $ 80��6d    6:   �� *
DescProd+6d   �� 5      $
��Prix��6%   $	 160��6]    63   �� *
PrixProd+6]   5      ��5      �� 5       �� 
TargetType" ��6   .�5       ��  �� Property � ��	 �� Value
	 �����63   �� 5!       � ��	 5"      �� 5#      
 �� 
TargetType"
 ��6.   .R�5$   "   ��  �� CornerRadius$ 2��6)    J� SnapsToDevicePixels . #��z��5%   !   #��z��5&   !   #��z��5'   !   ._�5(   &   �� $��InnerBorder��6-   $ 1��6@   $��1q�6Q   ._�5)   *   �  5*   .   �� 5+   2   $��11��6@   �� 5,   2   .+�5/   .   �� $��UpperHighlight��68   $y�	Collapsed=�6N   ���	#75FFFFFF6e   �� 50   .   $��2��6C   #��z��51   -   # z 52   -   53   +   54   '   55   #    �� Triggers 56   "   P� 57   &    P� Property �@J�IsMouseOver P� Value . . �58   *   ��  � ��
	 ���� 6G   �� 59   *    � ��
	 �   �6H   �� 5:   *    �� 
TargetName$ UpperHighlight��61    � y�$	 Visible=�6c   5;   '   P� 5<   &    �@��
IsSelected . . �5=   *   ��  � ��
	 �   �6G   5>   '   P� 5?   &    � {� .  . �5@   *   �� #	 � ��6G    � ��5A   '   5C      5E      5F      5H      � 5J   
   $��1��6    � ColumnDefinitions 5K      �� 5L      $��* �6#   �� 5M      $��* �6#   �� 5N      $��* �6#   .+�5Q      ��  �� Orientation$ Vertical=�6   $��0��60   $��10q�6@   .+�5R      �� 
�������.��6+   ID6/   �� 5S      -   5         ��Name$ TxtID��5S      {�.  6=   �� 5T      
�������.��6+   Nom60   �� 5U      -   5        $ TxtNom��5U      6,   5V      �� 5W      $ Vertical=�6   $��1��60   $��10q�6@   .+�5X      �� 
�������.��6+   Description68   �� 5Y      -   5        $ TxtDesc��5Y      6-   �� 5Z      
�������.��6+   Prix61   �� 5[      -   5        $ TxtPrix��5[      6-   5\      � 5]      $��2��6    5^      �� 5_      $��* �6$   �� 5`      $��* �6$   �� 5a      $��* �6$   .+�5d      �� -   5        $��BtnProduitAdd��5d   &   $��0��6   .��6W   	Ajouter6`   �� 5e      -   5        $��BtnProduitUpdate��5e   &   $��1��6   .��6]   
Modifier6g   �� 5f      -	   5        $��BtnProduitDelete��5f   &   $��2��6   .��6]   	Supprimer6h   5g      5h      5j      5k      