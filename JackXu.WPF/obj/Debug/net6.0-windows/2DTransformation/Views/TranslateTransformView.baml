   M S B A M L   `   `   `  ????E  AJackXu.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:JackXu.WPF._2DTransformation.Views"JackXu.WPF._2DTransformation.Views  5      ?    9JackXu.WPF._2DTransformation.Views.TranslateTransformView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:JackXu.WPF._2DTransformation.Views     5      .??5	      (? .??5
   
   ? $	??525??6   $	??330??6   $
??Left=?6(   $	??Top=?5        ? ShowGridLines$
  True??6+    ? ColumnDefinitions 5      ?? 5      $	??260 ?6#   ?? 5      $	??260 ?6#   .+?5      ?? .+?5      ?? $??Center=?6   $??
10,10,10,0q?69   $
??Wrap=?5      $??14(?6-   $
??Bold"?6;   $??Translation Animation??5      ?? 5      $??
10,10,10,0q?6   $
??Wrap=?60   $_??YThe translation properties X and Y                           are animated from -90 to 90.??5      ?? 5      $??10q?6   
???   ?$??1q?69      MyGrayGridBrush#??[  5      $
??Left=?6G   ._?5      ?? $
}?True??6   $	??240??61   $	??250??6=   .+?5      ??  ?? Left$	 100??6$   
 ?? Top$ 80??66   $??50??6F   $??70??5   %   
??????? J? Opacity$	 0.5Q?6C   
???   ?$??2??5   4   z?5      T? 5   "   -   5        rectTranlate??5   5   5!       ? Triggers 5$      :? 5%       :? RoutedEvent$ Canvas.Loaded??6+   .[?5&   "   ?? .??5'   &   ??  g? RepeatBehavior$ Forever??61    g? AutoReverse$
 True??6J   .??5(   *   W? 	 ?? 
TargetName$	 rectTranlate??6:   
 ?? TargetProperty$
 X?6_    W? From -905)   :   	 W? To 906E    g? Duration$ 0:0:5D?6M   W? 5*   *   $	 rectTranlate??6:   $
 Y?6_    -905+   :    906E   $ 0:0:5D?6M   5,   '   5-   #   5.      51      52      53      ? 55      $??1??6    57      ?? 58      $??* ?6'   ?? 59      $??20 ?6'    ? RowDefinitions 5;      ?? 5<      $??20 ?6$   ?? 5=      $??* ?6$   .+?5?      ?? -   5         ??Name$ sliderY??5?      $??1??6*   $??1??67    ?? Orientation$ Vertical=?6G    ? Minimum$	 -90Q?6^    ? Maximum$ 90Q?6l    ? Value$ 30Q?6y    ?? TickPlacement$ BottomRight=?5@       ?? TickFrequency$	 0.2Q?65   ?? 5A      $??1??6   .+?5B      ?? $??Center=?6    $??10,10,10,10q?6=   $
??Wrap=?5C      $??14(?6-   $
??Bold"?6;   $??Interactive Scaling??5D      ?? 5F      -   5        $ sliderX??5F      $	 -90Q?6.   $ 90Q?6<   $ 20Q?6I   $ BottomRight=?5G      $	 0.2Q?65   ?? 5I      $??10q?6   
???   ?$??1q?6=   #??[  5J      $
??Left=?5K      ._?5L      ?? $
}?True??6!   $	??240??65   $	??250??6A   .+?5M      ?? $ 90??6(   $ 63??69   $??Original shape??5N   %   ?? 5O      $ 80??6(   $	 100??68   $??50??6J   $??70??5P   %   
???   ?$??1??6@    ?? StrokeDashArray$	 3,1R?5Q   %   ?? 5R      $ 80??6(   $	 100??68   $??50??6J   $??70??5S   %   
???????$	 0.5Q?6C   
???   ?$??2??5T   4   z?5V   "   T? 5W   &    T? X 69   ??  ?? ElementName$ sliderX?? ?? Path$ Value? T? Y 5Y   )   ?? $ sliderY??$ Value?5\      5]      5_      5`      5a      5d      5e      5f      