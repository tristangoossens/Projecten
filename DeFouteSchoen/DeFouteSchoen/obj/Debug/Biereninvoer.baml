   M S B A M L   `   `   `  ����H  DDeFouteSchoen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DeFouteSchoenDeFouteSchoen  5   	        DeFouteSchoen.Biereninvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DeFouteSchoen     5   	     � Title$  Biereninvoer��5   	   $	��450��6   $	��800��6+   .��5	      � ��5
   
   �� 5       �� ImageSource$� �https://cdn.vox-cdn.com/thumbor/JgNyGimutNutR9o8kq9pr_WxAgQ=/0x0:2000x1335/1200x675/filters:focal(840x508:1160x828)/cdn.vox-cdn.com/uploads/chorus_image/image/61623387/2018_09_28_GoldLineBar_003.0.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgBieren��5      $
��Left=�6%   $	��420��6@   $��416,0,-0.4,0q�6M   $	��Top=�6c   $	��378��6{      AutoGenerateColumns .     
IsReadOnly . ���	#FFDDDDDD J� Opacity$	 0.7Q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+	   ClipboardContentBinding	 6<   Z� 6_     5      $
 Naam��6a    6%   �� *name+	 6>   Z� 6a     5      $
 Type��6j    6%   �� *beertype.type+	 6G   Z� 6j     5      $ Prijs��6b    6%   �� *price+	 6?   Z� 6b     5      $ Aantal verkocht��6j    6%   �� *purchasecount+	 6G   Z� 6j   5      �� 5   
   $��Biereninvoer��6   $
��Left=�6'   $��	10,10,0,0q�6B   $	��Top=�6U   $��36(�6m   $
��Bold"�6{   ���	#FFDDDDDD$	 0.7Q�6�   �� 5   
   $��Naam:��6   $
��Left=�6    $��	10,89,0,0q�6;   $	��Top=�6N   ���	#FFDDDDDD$	 0.7Q�6}   $��75��6�   $��28��6�   �� 5   
   -   5        
 ��Name$
 txtNaam��5      $
��Left=�6#   $��28��6>   $��
134,88,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   ���	#FFDDDDDD$	 0.7Q�6�   �� 5   
   $��Type:��6   $
��Left=�6    $��
10,140,0,0q�6;   $	��Top=�6O   $	 0.7Q�6g   ���	#FFDDDDDD$��75��6�   $��28��6�   ���	#FFDDDDDD6�   �� 5   
   -   5         ��Name$ cbType��5      $
��Left=�6#   $��134,140,0,0q�6>   $	��Top=�6S   $	��120��6k   $	 0.7Q�6w   $��28��6�   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $ 	#FFDDDDDD��6#   $ 1Q�65   5      5!      �� 5"   
   -   5        $
 txtPrijs��5"      $
��Left=�6$   $��28��6?   $��134,191,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   ���	#FFDDDDDD$	 0.7Q�6�   �� 5#   
   $��Prijs:��6   $
��Left=�6!   $��
10,191,0,0q�6<   $	��Top=�6P   ���	#FFDDDDDD$	 0.7Q�6   $��75��6�   $��28��6�   �� 5$   
   -   5         ��Name$ 
btnOpslaan��5$      $��Opslaan��6%   $
��Left=�67   $��
10,262,0,0q�6R   $	��Top=�6f   $��75��6~   $��25��6�   $	 0.7Q�6�   �� 5%   
   -   5        $ 	btnWijzig��5%      $��Bieren Wijzigen��6$   $
��Left=�6>   $��
10,307,0,0q�6Y   $	��Top=�6m   $��92��6�   $��25��6�   $	 0.7Q�6�   5'      5(      