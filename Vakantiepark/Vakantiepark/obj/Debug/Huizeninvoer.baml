   M S B A M L   `   `   `  ����G  CVakantiepark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VakantieparkVakantiepark  5   	       Vakantiepark.Huizeninvoer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Vakantiepark     5   	     � Title$  Huizeninvoer��5   	   $	��450��6   $	��800��6+   .��5	      � ��5
   
   �� 5      .+�5   
   �� -   5         ��Name$ btnTypes��5      $��Huizentypes��6#   $
��Left=�69   $��106,375,0,0q�6T   $	��Top=�6i   $��75��6�   $��35��6�   6�   �� 5   
   -   5        $ btnLoop��5      $
��Loop��6"   $
��Left=�61   $��
10,375,0,0q�6L   $	��Top=�6`   $��75��6x   $��35��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgHuizen��5      $
��Left=�6%   $	��420��6@   $��388,0,-0.4,0q�6M   $	��Top=�6c   $	��406��6{      AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Wijzig��6L      ClipboardContentBinding 6)   Z�    CellTemplate 5      �� 5      .R�5      �� $ 	btnChange��6%   -   5        $��Wijzig��5   8   6I   5      5      0  *System.Windows.Controls.DataGridTextColumn  5         
Foreground
 �  ��$ ID��6p   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *id+
   ClipboardContentBinding
 6<   Z� 6p     5      $ Nummer��6a   	 6%   �� *name+
 6>   Z� 6a     5      $
 Type��6k   	 6%   �� *housetype.type+
 6H   Z� 6k     5      $ Grootte��6k   	 6%   �� *housesize.size+
 6H   Z� 6k     5      $ Prijs��6b   	 6%   �� *price+
 6?   Z� 6b   5      �� 5   
   -   5        $ 
btnComfort��5      $��Comfort��6%   $
��Left=�67   $��
313,72,0,0q�6R   $	��Top=�6f   $��75��6~   $��32��6�   �� 5    
   -   5        $ btnVIP��5       $	��VIP��6!   $
��Left=�6/   $��313,109,0,0q�6J   $	��Top=�6_   $��75��6w   $��32��6�   �� 5!   
   -   5        $ 
btnPremium��5!      $��Premium��6%   $
��Left=�67   $��313,146,0,0q�6R   $	��Top=�6g   $��75��6   $��32��6�   �� 5"   
   $��Huizeninvoer��6   $
��Left=�6'   $	��Top=�6B   $��36(�6Z   $
��Bold"�6h   $��	10,10,0,0q�6z   �� 5#   
   $��Type:��6   $
��Left=�6    $��	10,84,0,0q�6;   $	��Top=�6N   $��18(�6f   $
��Bold"�6t   �� 5$   
   -   5         ��Name$ cbType��5$      $
��Left=�6#   $��
127,91,0,0q�6>   $	��Top=�6R   $	��120��6j   $��23��6v   �� 5%   
   $��Grootte:��6   $
��Left=�6#   $��
10,124,0,0q�6>   $	��Top=�6R   $��18(�6j   $
��Bold"�6x   �� 5&   
   -	   5        $ cbSize��5&      $
��Left=�6#   $��127,132,0,0q�6>   $	��Top=�6S   $	��120��6k   $��23��6w   �� 5'   
   $��Nummer:��6   $
��Left=�6"   $��
10,162,0,0q�6=   $	��Top=�6Q   $��18(�6i   $
��Bold"�6w   �� 5(   
   -
   5         ��Name$ 	txtNummer��5(      $
��Left=�6%   $��23��6@   $��127,171,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��16(�6�   �� 5)   
   $��Prijs:��6   $
��Left=�6!   $��
10,199,0,0q�6<   $	��Top=�6P   $��18(�6h   $
��Bold"�6v   �� 5*   
   -   5        $ txtPrijs��5*      $
��Left=�6$   $��23��6?   $��127,206,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   $��18(�6�    J� RenderTransformOrigin$ 0.491,0.453&�6�   �� 5+   
   -   5        $ btnToevoegen��5+      $��	Voeg toe!��6'   $
��Left=�6;   $��
10,240,0,0q�6V   $	��Top=�6j   $��75��6�   $��35��6�   6�   �� 5,   
   $��Selecteren op:��6   $
��Left=�6)   $��
296,41,0,0q�6D   $	��Top=�6X   $��87��6p   �� 5-   
   $	��€��6   $
��Left=�6   $��106,198,0,0q�67   $	��Top=�6L   $��18(�6d   $
��Bold"�6r   �� 5.   
   -   5        $ btnMenu��5.      $
��Menu��6"   $
��Left=�61   $��202,375,0,0q�6L   $	��Top=�6a   $��75��6y   $��35��6�   6�   50      51      