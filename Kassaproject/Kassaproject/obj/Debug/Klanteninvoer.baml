   M S B A M L   `   `   `  ����G  CKassaproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KassaprojectKassaproject  5   	        Kassaproject.Klanteninvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Kassaproject     5   	     � Title$  Klanteninvoer��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgKlant��5
      $
��Left=�6$   $	��420��6?   $	��Top=�6L   $	��399��6d      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5      $ Voornaam��6f    6%   �� *	firstname+ 6C   Z� 6f     5      $ 
Achternaam��6e    6%   �� *
lastname+ 6B   Z� 6e     5      $ 
Woonplaats��6a    6%   �� *city+ 6>   Z� 6a     5      $ Telefoonnummer��6h    6%   �� *phonenumber+ 6E   Z� 6h     5      $ E-mail��6b    6%   �� *email+ 6?   Z� 6b   5      �� 5   
   -   5         ��Name$ 
btnKinvoer��5      $��Voer in��6%   $
��Left=�67   $��427,274,0,0q�6R   $	��Top=�6g   $	��124��6   $��43��6�   
�������6�   �� 5   
   $��Klanteninvoer��6   $
��Left=�6(   $��
427,10,0,0q�6C   $	��Top=�6W   $��44��6o   $	��232��6{   $��22(�6�   $
��Bold"�6�   �� 5   
   $��	Voornaam:��6   $
��Left=�6$   $��427,107,0,0q�6?   $	��Top=�6T    J� RenderTransformOrigin$ 
0.49,0.495&�6l   �� 5   
   $��Achternaam:��6   $
��Left=�6&   $��427,140,0,0q�6A   $	��Top=�6V   $ 0.392,0.444&�6n   $��87��6�   $��30��6�   �� 5   
   $��E-Mail adress:��6   $
��Left=�6)   $��427,225,0,0q�6D   $	��Top=�6Y   �� 5   
   $��Telefoonnummer:��6   $
��Left=�6*   $��427,199,0,0q�6E   $	��Top=�6Z   �� 5   
   $��Woonplaats:��6   $
��Left=�6&   $��427,173,0,0q�6A   $	��Top=�6V   �� 5   
   -   5        	 ��Name$	 txtFirstname��5      $
��Left=�6(   $��23��6C   $��539,110,0,0q�6O   
 �� TextWrapping$

 Wrap=�6d   $	��Top=�6x   $	��120��6�   $ 0.277,0.671&�6�   �� 5   
   -   5        $	 txtLastname��5      $
��Left=�6'   $��23��6B   $��539,140,0,0q�6N   $

 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $	 txtCity��5      $
��Left=�6#   $��23��6>   $��539,168,0,0q�6J   $

 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $	 txtPhonenumber��5      $
��Left=�6*   $��23��6E   $��539,196,0,0q�6Q   $

 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $	 txtEmail��5      $
��Left=�6$   $��23��6?   $��539,224,0,0q�6K   $

 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5    
   $��*��6   $
��Left=�6   $��413,225,0,0q�67   $	��Top=�6L   $
��Bold"�6d   �� 5!   
   $��* = Optioneel��6   $
��Left=�6(   $��413,365,0,0q�6C   $	��Top=�6X   $
��Bold"�6p   $��16(�6�   �� 5"   
   -   5        $ btnKmenu��5"      $��Terug naar menu��6#   $
��Left=�6=   $��635,365,0,0q�6X   $	��Top=�6m   $	��113��6�   $��32��6�   
�������6�   5$      5%      