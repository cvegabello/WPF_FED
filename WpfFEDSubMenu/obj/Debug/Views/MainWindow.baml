   M S B A M L   `   `   `  ????H  DWpfFEDSubMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfFEDSubMenuWpfFEDSubMenu  5   	   9!clr-namespace:WpfFEDSubMenu.ViewsWpfFEDSubMenu.Views  5   	   A%clr-namespace:WpfFEDSubMenu.ViewModelWpfFEDSubMenu.ViewModel  5   	       WpfFEDSubMenu.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfFEDSubMenu     5   	   7	localView!clr-namespace:WpfFEDSubMenu.Views     5   	   ;	viewModel%clr-namespace:WpfFEDSubMenu.ViewModel     5   	     ? Title$  
MainWindow??5
   	   $	??450??5   	   $	??950??5   	   $	??550??5   	   $
??1460??5   	    ? WindowStyle$
 None=?5   	    ? 
ResizeMode$ CanResizeWithGrip=?5   	    ? AllowsTransparency . 
??????  ? WindowStartupLocation$ CenterScreen=?5   	    ? SizeToContent$ Manual=?6.   ??.  ? DataContext 5      +   %WpfFEDSubMenu.ViewModel.MainViewModel  5   
    ? 	Resources 5       ?? DataType2   ,WpfFEDSubMenu.ViewModel.SwitchBoardViewModel)   #WpfFEDSubMenu.Views.SwitchBoardView/  )WpfFEDSubMenu.ViewModel.CustomerViewModel    WpfFEDSubMenu.Views.Movies/   )WpfFEDSubMenu.ViewModel.SpecimenViewModel&    WpfFEDSubMenu.Views.SpecimenView??%?   (??       5      *, +)(?? 2     5      *, +)(?? d     5#      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5         5!      ?? 5#   
   "  6   .R?5$        5%      5(      .??5*      ?? 	 ?? CornerRadius$	 15??6   $??3q?5+   	   ??5,   
   ?? 5-      
 ?? 
StartPoint$	
 1,1&?6"    ?? EndPoint$	 0,0&?63   .??5.      ?    primaryBackColor1 ? Color# [  6    ? Offset$ 0Q?6J   ? 5/        primaryBackColor2# [ 6   $ 5Q?6J   50      ??53   
   ?? 54      $	
 0,0&?6"   $	 1,1&?63   .??55      ?   winBorderColor1# [ 6   $ 0Q?6H   ? 56        winBorderColor2# [ 6   $	 0.5Q?6H   ? 57        winBorderColor3# [ 6   $ 1Q?6H   58      ._?5<   
   ?  ? ColumnDefinitions 5=      ?? 5>      $
??Auto ?6#   ?? 5?      $??* ?6#   .+?5C      ?? -   5         ??Name$ nav_pnl??5C      $	 	15,0,0,15??5D      $??0??5E      $??60??5F      $
??Left=?5G        BarMenuBackColor1#??[ 5H      ._?5M      ?? .+?5N      ? $??90??6   .+?5P      d? -   5         d?Name$ Tg_Btn??5P   '   $??Center=?5Q   '   $
??Left=?5R   '   $??18,0,0,0q?5S   '   $??28??5T   '   $??28??5U   '   $??0q?5V   '     tb_style#??[ 5W   '   ??5Z      ?? 5[   "    ?? ImageSource$! ../Assets/tgBtn_default.png??6-    j? Stretch$
 None=?5\   -    ? Triggers 5_      :? 5`   "    :? RoutedEvent$ ToggleButton.Unchecked??6/   .[?5a   &   ?? .??5b   *   ?? -   5         ??Name$ HideStackPanel??5b   5   .??5c   .   W?  ?? 
TargetName$ nav_pnl??5d   1    ?? TargetProperty$ Width?5e   1    g? 	BeginTime$ 0:0:0X?5f   1    W? From$	 180X?5g   1   	 W? To$ 60X?6<    g? Duration$ 0:0:0.2D?5h   1   5i   /   5j   +   5k   '   5l   #   :? 5m   "   $ ToggleButton.Checked??6/   .[?5n   &   ?? .??5o   *   ?? -   5        $ ShowStackPanel??5o   5   .??5p   .   W? $ nav_pnl??5q   1   $ Width?5r   1   $ 0:0:0X?5s   1   $ 60X?5t   1   $	 180X?6;   $ 0:0:0.3D?5u   1   5v   /   5w   +   5x   '   5y   #   5|      ?? 5?      $??73,0,0,0q?6%   $??M E N U??5?   %   
???????$??18(?5?   %   
?????? $
??Left=?5?   %   $??Center=?5?   %     
font_style#??[ 5?   %    J? Effect 5?      3  -System.Windows.Media.Effects.DropShadowEffect  5?   "      
BlurRadius$ 10Q?64      ShadowDepth$ 1Q?5?   4      	Direction$	 -90Q?5?   4       Color$  White??5?   4   5?      5?      o? 5?      $	??450??6   #??[ 5?      $??0,40,0,0q?5?      ??5?      ?? 5?      .R?5?   "   $? ! $? Orientation$! Vertical=?69   5?      .@?5?      m? -   5        " m?Name$" 
mnuReports??5?   #   $??Reports??67    	 Menu1
# ? Tag## [ 5?   #    	 Menu_Template#??[	 5?   #   $ m? IsCheckable$ . % ? Cursor$
% Hand??5?   C   & m? CommandParameter$& 
mnuReports??5?   #   ' m? Command' 5?   #   ?? ( ?? RelativeSource( ?? *FindAncestor+) ?? AncestorType") ??* ?? Path$* DataContext.MenuCommand?+ m? Icon+ 5?      ?? 5?   "   $??../Assets/img_home.png??6(   $
??None=?5?   (   5?      m? 5?      -   5        $" 	mnuImages??5?   #   $??Images??66    
 SubMenu1## [
 5?   #     Menu_SubMenu_Template#??[ 5?   #   $
% Hand??5?   D   + 5?      ?? 5?   "   $??../Assets/img_music.png??6(   $
??None=?5?   (   .@?5?      m? $??	All Songs??6'     Item_Template#??[ 5?   '   $ . + 5?   "   ?? 5?   &   $??../Assets/img_songs.png??6,   $
??None=?5?   ,   5?      m? 5?      $??Albums??6'   #??[ 5?   '   + 5?   "   ?? 5?   &   $??../Assets/img_album.png??6,   $
??None=?5?   ,   5?      m? 5?      $??Genres??6'   #??[ 5?   '   + 5?   "   ?? 5?   &   $??../Assets/img_genre.png??6,   $
??None=?5?   ,   5Z     m? 5^     $??Artists??6'   #??[ 5_  '   + 5a  "   ?? 5c  &   $??../Assets/img_artist.png??6,   $
??None=?5d  ,   5h     m? 5l     $??	Playlists??6'   #??[ 5m  '   + 5o  "   ?? 5q  &   $ ??../Assets/img_playlist.png??6,   $
??None=?5r  ,   5v     5x     m? 5{     -   5        $" mnuDocuments??5{  #   $??	Documents??69    	 Menu2## [ 5|  #   #??[	 5}  #   $ . $
% Hand??5?  E   $& mnuDocuments??5?  #   ' 5?  #   ?? ( ?? *FindAncestor+") ??$* DataContext.MenuCommand?.@?6?   >+ 5?     ?? 5?  "   $??../Assets/img_movies.png??6(   $
??None=?5?  (   5?     5?     5?     5?     ?? 5?     $	 	0,15,15,0??5?     $??1??5?     ._?5?     ? , ? RowDefinitions, 5?     ?? 5?     $??30 ?6(   ?? 5?     $??28 ?6(   ?? 5?     $??* ?6(   .+?5?     ?? -   5        - ??Name$- pnlControlBar??5?  .   $??0??6!   . ?? Orientation$. 
Horizontal=?5?  !   $??RightToLeft=?5?  !   
?????? $??0,0,5,0q?5?  !   .+?5?     ?? -	   5        / ??Name$/ btnClose??5?  !     Control_btn#??[ 5?  !     CloseBtn_MouseOver## [ 5?  !   ??5?     ?? 5?  "   $# ../Assets/closeBtn_def_40.png??6-   5?     ?? 5?     -
   5        $/ btnMaximize??5?  !   #??[ 5?  !     MaxBtn_MouseOver## [ 5?  !   ??5?     ?? 5?  "   $! ../Assets/maxBtn_def_40.png??6-   5?     ?? 5?     -   5        $/ btnMinimize??5?  !   #??[ 5?  !     MinBtn_MouseOver## [ 5?  !   ??5?     ?? 5?  "   $! ../Assets/minBtn_def_40.png??6-   5?     5?     ? 5?     $??1??6    5?     ?? 5?     ?? 5?     .+?5?     ?? $??0??6%   $. 
Horizontal=?5?  %   $??Center=?5?  %   .+?5?     ?? $
??Fill=?5?  $   $??20??5?  $   $??20??5?  $   $??	35,0,10,0q?5?  $   ??5?  $   ?? *Icon+5?  $   ?? 5?       titleColor2#??[ 5?  (   $??16(?5?  (   $??
Montserrat)?5?  (   $??Medium"?5?  (   $??Center=?5?  (   ??5?  (   ?? *	Caption+5?  (   5?     ?? 5?     $??1??6%   $. 
Horizontal=?5?  %   $??RightToLeft=?5?  %   $??Center=?5?  %   $??0,0,20,0q?5?  %   .+?5?     ?? $??VEGABECA??6(     titleColor3#??[ 5?  (   $??	Monserrat)?5?  (   $??12(?5?  (   $??Center=?5?  (   A? 5?     $??20??6&   $??20??62    
 color2#??[ 5?  &   $??2??5?  &   $??	10,0,10,0q?5?  &   ??5?  "   ?? 5?  &   $ ../Assets/img_contact.png??61   5?     5     5     ?? 5     $??2??6%   $??8q?5	  %   ??5  %   ?? *CurrentChildView+5	  %   5     5     ? 5     -   5        0 ?Name$0 popup_tooltip??5     1 ? AllowsTransparency1 . 2 ? HorizontalOffset$	2 -10??5     3 ? VerticalOffset$3 -6??5     .??5     ? .+?5     $	   WpfFEDSubMenu.PopupUserControl	  -   5        4 	 Name$4 Header??5  -   ???#E0FFFF6=   5     5     5!     5$     5)     