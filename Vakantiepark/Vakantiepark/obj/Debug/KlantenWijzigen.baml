   M S B A M L   `   `   `  ����G  CVakantiepark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VakantieparkVakantiepark  5   	   "    Vakantiepark.KlantenWijzigen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Vakantiepark     5   	   -   5          � Title$  KlantenWijzigen��5   	   $��372.025��6!   $��384.376��62   .��5	      � .+�5
   
   �� $"��Klanten wijzigen/Verwijderen��6   $
��Left=�67   $	��Top=�6R   $��24(�6j   $
��Bold"�6x   $��43��6�   $	��362��6�   $��	10,10,0,0q�6�   �� 5   
   -   5         ��Name$ 	btnWijzig��5      $��Wijzig��6$   $
��Left=�65   $��293,138,0,0q�6P   $	��Top=�6e   $��75��6}   $��25��6�   �� 5   
   $��Achternaam:��6   $
��Left=�6&   $��
29,138,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5   
   $��	Voornaam:��6   $
��Left=�6$   $��
29,107,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5   
   -   5         ��Name$ txtVoornaam��5      $
��Left=�6'   $��23��6B   $��157,107,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ txtAchternaam��5      $
��Left=�6)   $��23��6D   $��157,142,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   $��Geboortedatum:��6   $
��Left=�6)   $��
29,168,0,0q�6D   $	��Top=�6X   $
��Bold"�6p   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpGeboortedatum��5      $
��Left=�6.   $��157,170,0,0q�6I   $	��Top=�6^   $��24��6v   $	��120��6�   �� 5   
   $��	Telefoon:��6   $
��Left=�6$   $��
29,199,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5   
   -   5        $ txtTelefoon��5      $
��Left=�6'   $��23��6B   $��157,201,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   $��E-Mail:��6   $
��Left=�6"   $��
31,230,0,0q�6=   $	��Top=�6Q   $
��Bold"�6i   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��23��6?   $��157,230,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   $��Woonplaats:��6   $
��Left=�6&   $��
31,258,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5   
   -   5        $ txtWoonplaats��5      $
��Left=�6)   $��23��6D   $��157,260,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -	   5        $ btnVerwijder��5      $��	Verwijder��6'   $
��Left=�6;   $��
293,89,0,0q�6V   $	��Top=�6j   $��75��6�   $��25��6�   6�   �� 5   
   -
   5         ��Name$
 lbID��5      $�� ��6   $
��Left=�6)   $��
157,76,0,0q�6D   $	��Top=�6X   �� 5   
   $	��ID:��6   $
��Left=�6   $��	29,81,0,0q�69   $	��Top=�6L   $
��Bold"�6d   5      5      