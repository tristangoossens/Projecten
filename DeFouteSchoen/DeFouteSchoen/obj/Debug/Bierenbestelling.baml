   M S B A M L   `   `   `  ����H  DDeFouteSchoen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DeFouteSchoenDeFouteSchoen  5   	   $    DeFouteSchoen.Bierenbestelling   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DeFouteSchoen     5   	     � Title$  Bierenbestelling��5   	   $	��450��6"   $	��800��6/   .��5	      � ��5
   
   �� 5       �� ImageSource$� �https://cdn.vox-cdn.com/thumbor/JgNyGimutNutR9o8kq9pr_WxAgQ=/0x0:2000x1335/1200x675/filters:focal(840x508:1160x828)/cdn.vox-cdn.com/uploads/chorus_image/image/61623387/2018_09_28_GoldLineBar_003.0.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgBestelling��5      $
��Left=�6)   $	��420��6D   $��403,0,-0.4,0q�6Q   $	��Top=�6g   $	��391��6    J� Opacity$	 0.7Q�6�   ���	#FFF0EFEF   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6_     5      $
 Naam��6f    6%   �� *	beer.name+ 6C   Z� 6f     5      $ Hoeveelheid��6c    6%   �� *amount+ 6@   Z� 6c     5      $ Datum��6a    6%   �� *date+ 6>   Z� 6a   5      �� 5   
   $��Bieren Bestelling��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   $��36(�6r   $��64��6�   $	��271��6�   $	 0.7Q�6�   ���	#FFEDEBEB6�   �� 5   
   -   5        	 ��Name$	 cbBier��5      $
��Left=�6#   $��
46,128,0,0q�6>   $	��Top=�6R   $	��120��6j   �� 5   
   -   5        
 ��Name$
 txtHoeveelheid��5      $
��Left=�6*   $��23��6E   $��
46,190,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5         ��Name$ btnBestelling��5      $��	Bestellen��6(   $
��Left=�6<   $��
46,310,0,0q�6W   $	��Top=�6k   $��75��6�   6�   5      5      