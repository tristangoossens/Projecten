   M S B A M L   `   `   `  ����G  CKassaproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KassaprojectKassaproject  5   	   "    Kassaproject.Producteninvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Kassaproject     5   	     � Title$  Producteninvoer��5   	   $	��450��6!   $	��800��6.   .��5	      � 
�������.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgProducten��5
      $
��Left=�6(   $	��420��6C   $	��Top=�6P   $	��399��6h      AutoGenerateColumns .  
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5      $
 Naam��6a    6%   �� *name+ 6>   Z� 6a     5      $ Producttype��6m    6%   �� *producttype.type+ 6J   Z� 6m   5      �� 5   
   -   5         ��Name$ cbType��5      $
��Left=�6#   $��550,120,0,0q�6>   $	��Top=�6S   $	��120��6k   6w   �� 5   
   $��Producttype:��6   $
��Left=�6'   $��424,120,0,0q�6B   $	��Top=�6W   $��90��6o   �� 5   
   $��Productnaam:��6   $
��Left=�6'   $��
424,72,0,0q�6B   $	��Top=�6V   $��90��6n   �� 5   
   $��Producteninvoer��6   $
��Left=�6*   $��
404,10,0,0q�6E   $	��Top=�6Y   $��57��6q   $	��285��6}   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtProductnaam��5      $
��Left=�6*   $��23��6E   $��
550,72,0,0q�6Q   	 �� TextWrapping$
	 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        
 ��Name$
 
btnPinvoer��5      $��Voer in��6%   $
��Left=�67   $��424,221,0,0q�6R   $	��Top=�6g   $	��111��6   $��44��6�   
����������	#FF0200006�   �� 5   
   -   5        $ txtPrijs��5      $
��Left=�6$   $��23��6?   $��550,166,0,0q�6K   $
	 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   $��Prijs:��6   $
��Left=�6!   $��424,166,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $
 	btnPterug��5      $��Terug naar menu��6$   $
��Left=�6>   $��654,360,0,0q�6Y   $	��Top=�6n   $	��106��6�   $��38��6�   ���	#FF020000
�������6�   5      5      