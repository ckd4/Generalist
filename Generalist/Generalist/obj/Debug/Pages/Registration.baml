   M S B A M L   `   `   `  ????E  AGeneralist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Generalist
Generalist  5      3clr-namespace:Generalist.PagesGeneralist.Pages  5      #    Generalist.Pages.Registration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      +controlsclr-namespace:Generalist    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Generalist.Pages     5        N? Title$  Registration??5
       ? 	Resources 5         AuthStylePB ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius ??Name ?? Triggers	 P? Property
 P? Value??%0  &	        ?? 5   
   " G?6$   .?5      ??  ? ?? ?#FFFF6+   ?? 5       ? ??$ 40??6'   ?? 5       ? ??$ Center=?69   ?? 5       ? ??$ 20(?6)   ?? 5       ? ??$ Bahnschrift)?6+   -   5        ?? 5       ? ?? 5      ?? 5      " G?6&   .R?5      ?? $??0q?6!   #??z??5      $ 10??5      ._?5      ?? $ PART_ContentHost??6+   5      5      5        5"      P? 5#      	 ?@J?IsMouseOver
 . . ?5$      ??  ? ?? ?#AFAFAF63   5%      5'      5(      .??5*      ?  ? RowDefinitions 5+   
   ?? 5,      $	??10* ?6   ?? 5-      $	??20* ?6   ?? 5.      $	??10* ?6    ? ColumnDefinitions 50   
   ?? 51      $??1* ?6   ?? 52      $??1* ?6   ?? 53      $??1* ?6   .+?55   
   ?? $ 20??6   $??1??6#   $??1??60   
???   ?._?56      ?? .+?57      ?? $??
10 30 10 0q?6   $??Регистрация??60   $??Center=?6C   $??35(?6`   
???????$??Bahnschrift)?6?   ?? 58      $??
40 20 40 0q?6#   .u?59      ?? -   5         ??Name$ TBNicknameReg??59        	AuthStyle#???  65   .??6Y   !   Generalist.WatermarkService   	Watermark 5:      ?? 5;      $??10 0 0 0q?6(   $??Center=?6:   $??20(?6U   $??Bahnschrift)?6c   $??Никнейм??6|   .??5<   ?   5=      5>      ? 5@      .+?5A      G? -   5         G?Name$ PBPassword1??5A   =   $??Center=?6"   #???   6R   $??
40 20 40 0q?6x   ?? 5B      -   5         ??Name$ TBPassword1??5B       ???	#FF808080$??
50 20 50 0q?6L    J? IsHitTestVisible .  $??Center=?5C   $   $??20(?6?   $??Bahnschrift)?6M   $??Пароль??5D   %   5E      ? 5F      .+?5G      G? -   5        $ PBPassword2??5G   =   $??Center=?6"   #???   6R   $??
40 20 40 0q?6x   ?? 5H      -   5        $ TBPassword2??5H       ???	#FF808080$??
50 20 50 0q?6L    .  $??Center=?5I   $   $??20(?6?   $??Bahnschrift)?6M   $)??#Подтвердите Пароль??5J   %   5K      ?? 5M      -   5         ??Name$ BTNRegistration??5M      $??
60 20 60 0q?62     RoundedButton#???  6F   $*??$Зарегистрироваться??6n   6?   ?? 5O      -   5        $ BTNAuth??5O      $??
60 20 60 0q?6*   #???  6>   $$??Уже есть аккаунт??6f   6?   5Q      5R      5S      5T      