   M S B A M L   `   `   `  ????E  AGeneralist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Generalist
Generalist  5      3clr-namespace:Generalist.PagesGeneralist.Pages  5      $    Generalist.Pages.Authorization   5      %controlsclr-namespace:Generalist  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Generalist.Pages     5        N? WindowTitle$  
Generalist??5	       N? Title$ Authorization??5       ? 	Resources 5         AuthStylePB ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius ??Name	 ?? Triggers
 P? Property P? Value??%0  &	        ?? 5   
   " G?6$   .?5      ??  ? ?? ?#FFFF6+   ?? 5       ? ??$ 40??6'   ?? 5       ? ??$ Center=?69   ?? 5       ? ??$ 20(?6)   ?? 5       ? ??$ Bahnschrift)?6+   -   5        ?? 5       ? ?? 5      ?? 5      " G?6&   .R?5      ?? $??0q?6!   #??z??5      $ 10??5      ._?5      ?? $ PART_ContentHost??6+   5      5      5!      	 5#      P? 5$      
 ?@J?IsMouseOver . . ?5%      ??  ? ?? ?#AFAFAF63   5&      5(      5)      .??5+      ?  ? RowDefinitions 5,   
   ?? 5-      $	??10* ?6   ?? 5.      $	??20* ?6   ?? 5/      $	??10* ?6    ? ColumnDefinitions 51   
   ?? 52      $??1* ?6   ?? 53      $??1* ?6   ?? 54      $??1* ?6   .+?56   
   ?? $ 20??6   $??1??6#   $??1??60   
???   ?._?57      ?? .+?58      ?? $??
10 30 10 0q?6   $??Авторизация??60   $??Center=?6C   $??35(?6`   
???????$??Bahnschrift)?6?   ?? 59      $??
40 30 40 0q?6#   .u?5:      ?? -   5         ??Name$ 
TBNickname??5:        	AuthStyle#???  62   .??6V   !   Generalist.WatermarkService   	Watermark 5;      ?? 5<      $??10 0 0 0q?6(   $??Center=?6:   $??20(?6U   $??Bahnschrift)?6c   $??Никнейм??6|   .??5=   ?   5>      5?      ? 5A      .+?5B      G? -   5         G?Name$ 
PBPassword??5B   9   $??Center=?6   #???   6M   $??
40 30 40 0q?6s   ?? 5C      -   5         ??Name$ 
TBPassword??5C       ???	#FF808080$??
50 30 50 0q?6K    J? IsHitTestVisible .  $??Center=?5D   $   $??20(?6?   $??Bahnschrift)?6M   $??Пароль??5E   %   5F      ?? 5J      -   5         ??Name$ Login??5J      $??
60 30 60 0q?6,     RoundedButton#???  6@   $??
Войти??6h   6x   ?? 5K      -   5        $ RegistrationRedirect??5K      $??
60 30 60 0q?67   #???  6K   $??Регистрация??6s   6?   5L      5M      5N      5O      