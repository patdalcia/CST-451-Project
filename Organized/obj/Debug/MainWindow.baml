   M S B A M L   `   `   `  ����D  @Organized, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Organized	Organized  5   	       Organized.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Organized     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   6/   -   5          � Title$  	Dashboard��5   	   $	��700��6   $	��400��6(    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ Black��6'    � Offset$	 0.0Q�65   � 5      $ DarkGray��6'   $ 1Q�68   5      5      �� 5       $��Center=�6   $��Center=�5!      .+�5$      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5%      $	��400��5&      $��60��5'      .+�5*      .  (MahApps.Metro.IconPacks.PackIconMaterial  -   5        	   Kind$	 WindowMinimize=�5*   1   
��� ���$��
290,0,25,0q�5,   1   $��30��5-   1   $��30��5.   1   5/   1     52      -   5        $	 Close=�52   1   
��� ���$��0,0,0,0q�54   1   $��30��55   1   $��30��56   1   57   1   59      �� 5;      $��Center=�6   $	��250��6:   .+�5<      �� $��Images/resizedLogo.png��6   $��-63,5,-85,-80q�5=      $��Bottom=�5>      $	��250��67   �� 5@      $��Login��6    $��Light"�6-   $��40(�6@   $��	helvetica)�6N   ���#f9ed05$��Center=�5A   2   5B      5C      �� 5G      $��1��6   .+�5I      �� $ 
Horizontal=�6   .+�5L      � .+�5M      �� -   5        
 ��Name$
 UsernameTextBox��5Q      $	��300��5M   #   $��25��5N      $��Center=�5O      $��Center=�5P      $��
50,0,-25,7q�5R      
������ $��0q�5T      $��25(�5U      $��	Helvetica)�5V      ���#f9ed05 J� Opacity$	 0.8Q�5X      �� 5Z       J� IsHitTestVisible .  $��Username��5[       $��Center=�5\       $
��Left=�5]       ���#f9ed05$	 0.8Q�5_       $��
55,0,-25,7q�5`       ��5a      �� 5b   "    �� 
TargetType" ��6(   .�5c   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C   �� 5d   &    � ��$ 	Helvetica)�6C   �� 5e   &    � ��$ Light"�6C   �� 5f   &    � ��$ 25(�6A    �� Triggers 5g   &   �� 5h   *    �� Binding 66   �� *Text+ �� ElementName$ UsernameTextBox�� �� Value  6l   .a�5i   .   ��  � y�$ Visible=�6K   5j   +   5l   #   5n      5o        5q      $	 Account=�61   $��Center=�5r   1   $
��Left=�5s   1   ���#f9ed055t   1   5u      �� 5y      $	��300��6   $��2��5z      
��� ���$	 0.7Q�5|      �� 5�      $ 
Horizontal=�6   $��0,40,0,0q�66   .+�5�      G� -   5         G�Name$ PasswordTextBox��5�      $��	Helvetica)�5�   "   $��Light"�5�       G� Password$ Password��5�      $��25(�5�      $��Center=�5�      ���#f9ed05
������ $��0q�5�      $	��300��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��
50,0,-25,7q�5�      5�        5�      $		 Key=�61   $��Center=�5�   1   $
��Left=�5�   1   ���#f9ed055�   1   5�      �� 5�      $	��300��6   $��2��5�      
��� ���$	 0.7Q�5�      �� 5�      $ 
Horizontal=�6   $��0,50,0,0q�66   .+�5�      �� -   5        $	��100��5�      $��40��5�      $��LOGIN��5�      $��	60,0,60,0q�5�      5�      �� 5�      -   5        $	��100��5�      $��40��5�      $��REGISTER��5�      5�      5�      5�      5�      5�      5�      