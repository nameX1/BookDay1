   M S B A M L   `   `   `  ????B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MissionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     ? Title$  Datebook??5   	   $	??600??6   $	??900??6'   
???   ?.??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgDateBook??5
      $??17(?6(   $
??Bold"?66   $??10q?6H      AutoGenerateColumns .  ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5      ?  ? Color$ 	#FF9129A5??6#    ? Offset$ 0.771Q?65   ? 5      $ 	#FFFCB97C??6#   $ 0.411Q?65   ? 5      $ 	#FFF3B075??6#   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .  	   Header$	 Дата??6^   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 190 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ??  ?? Path$ CreationDate?6l   4  .System.Windows.Controls.DataGridCheckBoxColumn  5       .  $	 Прогресс??6?   $	
 107 6?    6)   ?? $ IsDone? ?? UpdateSourceTrigger$ PropertyChanged=?6?     5       .  $	 Задачи??6V   $
 * 6f    6%   ?? $
 Text?6f   5      5      5      