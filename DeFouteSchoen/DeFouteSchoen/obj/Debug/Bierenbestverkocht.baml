   M S B A M L   `   `   `  ����H  DDeFouteSchoen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DeFouteSchoenDeFouteSchoen  5   	   &     DeFouteSchoen.Bierenbestverkocht   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DeFouteSchoen     5   	     � Title$  Bierenbestverkocht��5   	   $	��450��6$   $	��800��61   .��5	      � ��5
   
   �� 5       �� ImageSource$� �https://cdn.vox-cdn.com/thumbor/JgNyGimutNutR9o8kq9pr_WxAgQ=/0x0:2000x1335/1200x675/filters:focal(840x508:1160x828)/cdn.vox-cdn.com/uploads/chorus_image/image/61623387/2018_09_28_GoldLineBar_003.0.jpg��6   .+�5   
   �� $��Best verkochte bieren��6   $
��Left=�60   $��
213,10,0,0q�6K   $	��Top=�6_   ���	#FF898686$��36(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgBieren��5      $
��Left=�6%   $	��247��6@   $��142,102,0,0q�6M   $	��Top=�6b   $	��503��6z      AutoGenerateColumns .     CanUserSortColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *name+   ClipboardContentBinding 6>   Z� 6a     5      $
 Type��6j   	   CanUserSort	 .   6%   �� *beertype.type+ 6G   Z� 6x     5      $ Aantal verkocht��6j   
   SortDirection$
 
DescendingX�6�      
IsReadOnly . 	 .  6%   �� *purchasecount+ 6G   Z� 6�   5      5      5      