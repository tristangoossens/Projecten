   M S B A M L   `   `   `  ����G  CKassaproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KassaprojectKassaproject  5   	   $    Kassaproject.Bestellingsinvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Kassaproject     5   	     � Title$  Bestellingsinvoer��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgItemsinorder��5
      $
��Left=�6+   $	��210��6F   $	��Top=�6S   $	��399��6k      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5      $ Hoeveelheid��6c    6%   �� *amount+ 6@   Z� 6c     5      $ Order Id��6d    6%   �� *	orderid+ 6A   Z� 6d     5      $ Productnaam��6i    6%   �� *product.name+ 6F   Z� 6i   5      �� 5   
   $��Bestellingsinvoer��6   $
��Left=�6,   $��	404,0,0,0q�6G   $	��Top=�6Z   $	��285��6r   $��57��6~   $��24(�6�   $
��Bold"�6�   �� 5   
   $��Klant:��6   $
��Left=�6!   $��
423,96,0,0q�6<   $	��Top=�6P   �� 5   
   -   5         ��Name$ cbKlant��5      $
��Left=�6$   $��
509,96,0,0q�6?   $	��Top=�6S   $	��120��6k   ��5      �� 5       �� EndPoint$	 0,1&�6&   	 �� 
StartPoint$		 0,0&�65   .��5      � 
 � Color$
 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $
 White��6#   $ 1Q�61   5      5      �� 5   
   $��Product:��6   $
��Left=�6#   $��423,146,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ 	cbProduct��5      $
��Left=�6&   $��509,146,0,0q�6A   $	��Top=�6V   $	��120��6n   �� 5   
   -   5         ��Name$ txtHoeveelheid��5      $
��Left=�6*   $��23��6E   $��509,193,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��Hoeveelheid:��6   $
��Left=�6'   $��423,193,0,0q�6B   $	��Top=�6W   �� 5    
   -   5         ��Name$ 	btnBterug��5       $��Terug naar menu��6$   $
��Left=�6>   $��671,372,0,0q�6Y   $	��Top=�6n   $	��113��6�   $��38��6�   
�������6�   �� 5!   
   -   5        $ 
btnBinvoer��5!      $��Voer in��6%   $
��Left=�67   $��423,237,0,0q�6R   $	��Top=�6g   $	��100��6   $��39��6�   
�������6�     5"   
   -   5        $ dgOrder��5"      $
��Left=�6$   $	��210��6?   $��	0,210,0,0q�6L   $	��Top=�6_   $	��399��6w    .   �� ItemStringFormat$  ��6�    5#        5$      $ Id��6_    6%   �� *Id+ 6<   Z� 6_     5%      $ Datum��6|    6%   �� *date+ �� StringFormat$ 
dd-MM-yyyy�� 6Y   Z� 6|     5&      $ 
Naam klant��6n    6%   �� *customer.lastname+ 6K   Z� 6n   5(      5*      5+      