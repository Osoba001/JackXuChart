   M S B A M L   `   `   `  ????E  AJackXu.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:JackXu.WPF.Main.ViewsJackXu.WPF.Main.Views  5   	   C&clr-namespace:JackXu.WPF.CustomControlJackXu.WPF.CustomControl  5   	   )    #JackXu.WPF.Main.Views.StartupWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:JackXu.WPF.Main.Views     5   	   5hm&clr-namespace:JackXu.WPF.CustomControl     5   	      myBackGround#???   5        fg#???  6F     ? Title$  StartupWindow??5	   	   $	??750??6   $
??1080??6,   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $??40 ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ? $??0??6    5      ?? 5      $??* ?6#   ?? 5      $	??200 ?6#   .+?5      ?? -   5         ??Name$ Menubar??5   n    ?? SelectionMode$ Single=?6   $??0q?6Z   
?????? #???  6?   ??5      ?? 5      .R?5      ?  K? IsItemsHost$
 True??6$   5      .@?5       (   "JackXu.WPF.CustomControl.NavButton     Text$
 Home??6      NavUri$ /Main/Views/HomeView.xaml??6+     5!      $ Graphics Basic??6   $3 -/GraphicBasic2D/Views/GraphicBasic2DView.xaml??65     5"      $ 2D Transform??6   $5 //2DTransformation/Views/TransfermationView.xaml??63     5#      $
 Task??6   $  /Task/Views/TaskViews.xaml??6+   5$      ? 5%      $??1??6   .+?5&      	? -   5        $??bgRed??5&   -    	? 	GroupName$ bg??6   $	??red??6:   #???  6`   	? 5'      -   5        $??bgBlue??5'   -   $ bg??6   $
??blue??6;   #???  6c   	? 5(      -   5        $??bgWhite??5(   -   $ bg??6   $??white??6<   	 d? 	IsChecked$
	 TrueY?6L   #???  6w   	? 5)      -   5        $??bgBlack??5)   -   $ bg??6   $
??dark??6<   #???  6e   5*      5+       ? 5,   
   -   5        
  ?Name$
 navframe??5,   1   $??1??6   $??2??6     ? NavigationUIVisibility$ Hidden=?6C   5-      5.      