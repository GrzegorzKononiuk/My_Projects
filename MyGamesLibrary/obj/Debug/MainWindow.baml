   M S B A M L   `   `   `  ����I  EMyGamesLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyGamesLibraryMyGamesLibrary  5   	       MyGamesLibrary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MyGamesLibrary     5   	     � Title$  My Games Library��5   	    � WindowState$ 	Maximized=�6"    � WindowStyle$ SingleBorderWindow=�6:    � 	Resources 5
      $  MyGamesLibrary.SortTypeManager   sortTypeManager �� 
TargetType �� Property �� Value �� BasedOn  	TitleText �� 
StartPoint	 �� EndPoint
 � Offset � Color��%�  &	        '��      &	 �     7��  5   
   6    �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 4(�6)   5      �� 5   
   8   " ��5      .�5      ��  � ��$ 20(�6)   �� 5       � �� 5      �� 5      $ 0.5,0&�6*   $	 0.5,1&�6=   ��5      � $	
 0.0Q�6+   $ #000000��68   � 5      $	
 1.0Q�6+   $ #000000��68   5      5      5       5!      .��5#      �  � DataContext# [  6    � ColumnDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��* �6    � RowDefinitions 5(   
   �� 5)      $��2* �6   �� 5*      $
��0.2* �6   .+�5-   
   �� -   5        
����� ���5-   &   �� *SortQueries+��5.      �� 5/      .R�50      � $
��Left=�6    51      �� 52      $
��Auto �6/   �� 53      $
��Auto �6/   .+�55      �� $��35��6!   $��35��6,   ._�56      �� $��UniformToFill=�6=   ��6$   �� *Image+6=   57      �� 58      $��1��6%   $��10,0,0,0q�65   .+�59      �� $��22(�6?   $��NoWrap=�6M   ��6(   �� *Title+6M   5:      5;      5<      5>      �� 5@   
   
�������$��2��6-   ��6=   �� *CurrentQuery+��5A      �� 5B      .R�5C      �  5D      �� 5E      $��* �6/   �� 5F      $��* �6/   �� 5G      $	��333 �6/   .+�5I      �� ���	#FFDADFE1
�������$��1q�6S   $	��120��6g   $��Center=�6u   ._�5J      �� ��6$   �� *Image+5K      �� 5L      $��2��6%   $��Center=�66   .+�5M      �� $��
textblock1��6b   #��[ 6?   ��6(   �� *Hours+6v   �� 5O      $	��122��6@   ��6$   �� *
Platform+6@   5P      5Q      5R      5T      5U      5V      