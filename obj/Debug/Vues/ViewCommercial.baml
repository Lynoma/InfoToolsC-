   M S B A M L   `   `   `  ����M  IProjetInfoToolsCRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjetInfoToolsCRMProjetInfoToolsCRM  5      '    !ProjetInfoToolsCRM.ViewCommercial   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ProjetInfoToolsCRM     5      
�������$��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5      .��5      � $��	10,0,10,0q�6    � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��250 �6   .+�5   
   �� -   5        $��ListViewCommercials��5   �   ���#2D3343$��0��6L   $��0,0,0,1q�6�   ���#37445F��6(   �� *Commercials+ �� View 5      �� 5      -   5        CommercialsGrid��  myHeaderStyle! �� ColumnHeaderContainerStyle# [ 5   4   .P�5      �� $��ID��6%    �� Width$ 80��6Y    �� DisplayMemberBinding 62   �� *IdCom+6Y   �� 5      $	��Nom��6%   $ 80��6Z    62   �� *NomCom+6Z   �� 5      $��Prenom��6%   $ 80��6`    65   �� *	PrenomCom+6`   �� 5      $��Adresse��6%   $	 160��6b    66   �� *
AdresseCom+6b   �� 5      $��	Telephone��6%   $ 80��6f    68   �� *TelephoneCom+6f   �� 5      $
��Mail��6%   $	 160��6\    63   �� *	MailCom+6\   �� 5      $	��Mdp��6%   $ 80��6Z    62   �� *MdpCom+6Z   5      ��5       �� 5!       �� 
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
�������.��6+   Nom60   �� 5W      -   5        $ TxtNom��5W      6,   �� 5X      
�������.��6+   Prenom63   �� 5Y      -   5        $ 	TxtPrenom��5Y      6/   �� 5Z      
�������.��6+   	Adresse64   �� 5[      -   5        $ 
TxtAdresse��5[      60   5\      �� 5]      $ Vertical=�6   $��1��60   $��10q�6@   .+�5^      �� 
�������.��6+   	Telephone66   �� 5_      -   5        $ TxtTelephone��5_      62   �� 5`      
�������.��6+   Mail61   �� 5a      -   5        $ TxtMail��5a      6-   �� 5b      
�������.��6+   Mdp60   �� 5c      -	   5        $ TxtMdp��5c      6,   5d      � 5e      $��2��6    5f      �� 5g      $��* �6$   �� 5h      $��* �6$   �� 5i      $��* �6$   .+�5l      �� -
   5        $��BtnCommercialAdd��5l   &   $��0��6   .��6]   	Ajouter6f   �� 5m      -   5        $��BtnCommercialUpdate��5m   &   $��1��6   .��6c   
Modifier6m   �� 5n      -   5        $��BtnCommercialDelete��5n   &   $��2��6   .��6c   	Supprimer6n   5o      5p      5r      5s      