   M S B A M L   `   `   `  ����H  DDeFouteSchoen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DeFouteSchoenDeFouteSchoen  5   	   "    DeFouteSchoen.Bierenwijzigen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DeFouteSchoen     5   	     � Title$  Bierenwijzigen��5   	   $	��450��6    $	��800��6-   .��5	      � ��5
   
   �� 5       �� ImageSource$� �https://cdn.vox-cdn.com/thumbor/JgNyGimutNutR9o8kq9pr_WxAgQ=/0x0:2000x1335/1200x675/filters:focal(840x508:1160x828)/cdn.vox-cdn.com/uploads/chorus_image/image/61623387/2018_09_28_GoldLineBar_003.0.jpg��6   .+�5   
   �� -   5         ��Name$
 lbID��5      $�� ��6   $
��Left=�6)   $��	94,83,0,0q�6D   $	��Top=�6W   �� 5   
   $��Bieren wijzigen��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $��36(�6p   $
��Bold"�6~   ���	#FFDDDDDD J� Opacity$	 0.7Q�6�   �� 5   
   -   5         ��Name$ txtNaam��5      $
��Left=�6#   $��30��6>   $��
89,109,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   ���	#FFDDDDDD$	 0.7Q�6�   �� 5   
   -   5        $ txtPrijs��5      $
��Left=�6$   $��28��6?   $��
89,215,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   ���	#FFDDDDDD$	 0.7Q�6�   �� 5   
   -   5         ��Name$ cbType��5      $
��Left=�6#   $��
89,163,0,0q�6>   $	��Top=�6R   $	��120��6j   $��28��6v   $	 0.7Q�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      � 	 � Color$	 	#FFF0F0F0��6#   
 � Offset$
 0Q�65   � 5      $	 	#FFDDDDDD��6#   $
 1Q�65   5      5      �� 5   
   $��Naam:��6   $
��Left=�6    $��
10,110,0,0q�6;   $	��Top=�6O   ���	#FFDDDDDD$	 0.7Q�6~   $��28��6�   $��53��6�   �� 5   
   $��Type:��6   $
��Left=�6    $��
10,163,0,0q�6;   $	��Top=�6O   $��28��6g   ���	#FFDDDDDF$	 0.7Q�6�   $��53��6�   �� 5   
   $��Prijs:��6   $
��Left=�6!   $��
10,215,0,0q�6<   $	��Top=�6P   ���	#FFDDDDDD$��28��6   $	 0.7Q�6�   $��53��6�   �� 5   
   -   5         ��Name$ 	btnWijzig��5      $��Wijzig��6$   $
��Left=�65   $��
10,287,0,0q�6P   $	��Top=�6d   $��75��6|   $��28��6�   $	 0.7Q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgWijzigen��5      $
��Left=�6'   $	��420��6B   $��403,0,-0.4,0q�6O   $	��Top=�6e   $	��391��6}      AutoGenerateColumns .  ���	#FFDDDDDD$	 0.7Q�6�      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Wijzigen��6L      ClipboardContentBinding 6)   Z�    CellTemplate 5       �� 5!      .R�5"      �� $ 	btnChange��6%   -   5        $��Wijzig��5"   8   ���	#FFFF8000���	#FFF986006x   5#      5%        5&      $ Verwijderen��6L    6)   Z�  5'      �� 5(      .R�5)      �� $ 	btnDelete��6%   -   5        $��	Verwijder��5)   8   ���	#FFFF0303���	#FFFF02026{   5*      5,      0  *System.Windows.Controls.DataGridTextColumn  5-      $ ID��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5.      $
 Naam��6a    6%   �� *name+ 6>   Z� 6a     5/      $
 Type��6j    6%   �� *beertype.type+ 6G   Z� 6j     50      $ Prijs��6b    6%   �� *price+ 6?   Z� 6b     51      $ Aantal verkocht��6j    6%   �� *purchasecount+ 6G   Z� 6j   53      �� 54   
   $	��ID:��6   $
��Left=�6   $��275,113,0,0q�69   $	��Top=�6N   �� 55   
   -	   5        $
 lbId��55      $�� ��6   $
��Left=�6)   $��299,113,0,0q�6D   $	��Top=�6Y   �� 56   
   -
   5        $ btnVerwijder��56      $��Verwijderen��6'   $
��Left=�6=   $��
10,336,0,0q�6X   $	��Top=�6l   $��75��6�   $��28��6�   $	 0.7Q�6�   57      58      