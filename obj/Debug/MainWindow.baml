   M S B A M L   `   `   `  ����I  EZahard_Student, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zahard_StudentZahard_Student  5   	       Zahard_Student.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   (localclr-namespace:Zahard_Student  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��600��6   $	��800��6)    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6D   ��5      �� 5   
    �� ImageSource$5 /pack://siteoforigin:,,,/Resources/Wallpaper.png��6   .��5      �� $
��Left=�6   $	��416��6(   $��394,116,0,0q�65   $	��Top=�6J   $	��305��6b   .+�5   
   �� -   5         ��Name$ text1��5      $��Create Account��6   $��36��5      $	��180��6   $	��Top=�5      $
��Left=�6$   ���	#FF37B593$��22(�5    #   $��Arial Rounded MT Bold)�61    �� Left$ 77��5!      
	 �� Top$	 5��6!   $
��Bold"�60   
 J� RenderTransformOrigin$
 0.5,0.5&�6B   �� 5$   
   -   5         ��Name$ txt_username��5$      $�� ��6   $	��263��5%      $ 32��6   $		 101��60   $��18(�5&      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Username��6    $��2q�6P     MaterialDesignDivider#���  5'       ! MaterialDesignOutlinedTextBox#��[ 6H   G� 5*   
   -   5         G�Name$ Pb_password��5*      $	��263��5+      $ 32��6#   $		 185��64   $��18(�5,      $ Enter Password��6$   $��2q�6T   #���  5-       % !MaterialDesignOutlinedPasswordBox#��[ 6L   G� 50   
   -   5        $ Rpb_password��50      $	��263��51      $ 32��6#   $		 263��64   $��18(�52      $ Rewrite Password��6$   $��2q�6V   #���  53      #��[ 6L   �� 56   
   $��
129,37,0,0q�6   $��Center=�6(   $��22(�6E   $
��Bold"�6S   $��Hello!��6e   ���	#FF3030306s   �� 58   
   -   5         ��Name$ text10��58      $��	46,67,0,0q�6$   $��15(�67   $��Center=�6F   $'��!username and password to registry��6c   ���	#FF6363636�   �� 5;   
   -   5         ��Name$ btu_log_or_sign��5;      $ 52��6*   $		 340��6;   $	��220��6L   $��45��6X   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5<   	   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5=   	   $��18(�67   $��Sign Up��6E   ���	#FF37B593
����������	#FF4BBF975A      �� 5B   
   $	��236��6   $
 -320��6   $	 67��61   $	��178��6A   .+�5C      �� -   5        $ textw��5C      $��
-15,37,0,0q�6'   $��Center=�6;   $��32(�6X   $
��Bold"�6f   $��Welcom Back!��6x   
�������6�   �� 5E      -   5        $ text2��5E      $��
-20,85,0,0q�6'   $��15(�6;   $��Center=�6I   $%��to keep conacted with us please��6f   ���	#FFE0E0E06�   �� 5F      -	   5        $ text3��5F      $��-12,106,0,0q�6'   $��15(�6<   $��Center=�6J   $#��login with your personal into��6g   ���	#FFE0E0E06�   5H      �� 5I   
   -
   5        $ btu_log_or_sign1��5I      $
 -330��6+   $		 215��6>   $	��190��6O   $��45��6[   $ Depth0=�5J      $ 10��5K      $��18(�6;   $��Login��6I   ���	#FF37B593
�������
�������5L   K   �� 5N   
   -   5        $ text10_Copy��5N      $��15(�6)   $��Center=�68   $�� ��6U   ���	#FFF50000$ 52��6t   $		 398��6�   $
��Bold"�6�   5R      5T      