   M S B A M L   `   `   `  ����G  CVakantiepark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VakantieparkVakantiepark  5   	        Vakantiepark.Klanteninvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Vakantiepark     5   	     � Title$  Klanteninvoer��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgKlant��5
      $
��Left=�6$   $	��373��6?   $	��Top=�6L   $	��391��6d   $��403,47,-0.4,0q�6p      
IsReadOnly .    AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Wijzig��6L      ClipboardContentBinding 6)   Z�    CellTemplate 5      �� 5      .R�5      ��  ��Name$ 	btnChange��6%   -   5        $��Wijzig��5   8   6I   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      	   
Foreground
	 �  ��$ ID��6p   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *id+   ClipboardContentBinding 6<   Z� 6p     5      $ Voornaam��6f   
 6%   �� *	firstname+ 6C   Z� 6f     5      $ 
Achternaam��6e   
 6%   �� *
lastname+ 6B   Z� 6e     5      $ Geboortedatum��6f   
 6%   �� *	birthdate+ 6C   Z� 6f     5      $ 
Woonplaats��6a   
 6%   �� *city+ 6>   Z� 6a     5      $ Telefoon��6h   
 6%   �� *phonenumber+ 6E   Z� 6h     5      $ E-Mail��6b   
 6%   �� *email+ 6?   Z� 6b   5      �� 5   
   $��Achternaam:��6   $
��Left=�6&   $��	0,118,0,0q�6A   $	��Top=�6T   $��16(�6l   $
��Bold"�6z   �� 5   
   $��* Email:��6   $
��Left=�6#   $��	2,267,0,0q�6>   $	��Top=�6Q   $��16(�6i   $
��Bold"�6w   �� 5   
   $��Telefoonnummer:��6   $
��Left=�6*   $��	0,230,0,0q�6E   $	��Top=�6X   $��16(�6p   $
��Bold"�6~   �� 5   
   $��Woonplaats:��6   $
��Left=�6&   $��	2,193,0,0q�6A   $	��Top=�6T   $��16(�6l   $
��Bold"�6z   �� 5    
   $��Geboortedatum:��6   $
��Left=�6)   $��	0,156,0,0q�6D   $	��Top=�6W   $��16(�6o   $
��Bold"�6}   �� 5!   
   $��	Voornaam:��6   $
��Left=�6$   $��0,81,0,0q�6?   $	��Top=�6Q   $��16(�6i   $
��Bold"�6w   �� 5"   
   -   5         ��Name$ txtVoornaam��5"      $
��Left=�6'   $��23��6B   $��
147,90,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5#   
   -   5        $ txtAchternaam��5#      $
��Left=�6)   $��23��6D   $��147,126,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5$   
   -   5        $ txtWoonplaats��5$      $
��Left=�6)   $��23��6D   $��147,202,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5%   
   -   5        $ txtTelefoonnummer��5%      $
��Left=�6-   $��23��6H   $��147,239,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5&   
   -   5        $ txtEmail��5&      $
��Left=�6$   $��23��6?   $��147,276,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   (  "System.Windows.Controls.DatePicker  5'   
   -   5          Name$ dpGeboortedatum��5'      $
��Left=�6.   $��147,164,0,0q�6I   $	��Top=�6^   $	��120��6v   �� 5(   
   $��* = Optioneel��6   $
��Left=�6(   $��	2,378,0,0q�6C   $	��Top=�6V   $��16(�6n   $
��Bold"�6|   �� 5)   
   -	   5        $ 	btnInvoer��5)      $��Voer in!��6$   $
��Left=�67   $��
15,314,0,0q�6R   $	��Top=�6f   $��89��6~   $��29��6�   6�   �� 5*   
   $��Klanteninvoer��6   $
��Left=�6(   $	��Top=�6C   $��36(�6[   $
��Bold"�6i   $��0,6,0,0q�6{   �� 5+   
   -
   5        $ btnMenu��5+      $��	Hoofdmenu��6"   $
��Left=�66   $��281,384,0,0q�6Q   $	��Top=�6f   $��94��6~   $��27��6�   6�   �� 5,   
   $��Zoeken op ID:��6   $
��Left=�6(   $��
403,10,0,0q�6C   $	��Top=�6W   $��26��6o   �� 5-   
   -   5        $ txtZoek��5-      $
��Left=�6#   $��26��6>   $��
510,10,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��142��6�   �� 5.   
   -   5        $ btnZoek��5.      $��Zoek!��6"   $
��Left=�62   $��
678,10,0,0q�6M   $	��Top=�6a   $��80��6y   $��26��6�   6�   50      51      