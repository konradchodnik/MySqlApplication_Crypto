   M S B A M L   `   `   `  ����C  ?MySqlApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MySqlApp.ViewModelsMySqlApp.ViewModels  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   1clr-namespace:MySqlApp.ModelsMySqlApp.Models  5   	   #clr-namespace:MySqlAppMySqlApp  5	   	       MySqlApp.NowaRola   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0vm!clr-namespace:MySqlApp.ViewModels     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -srcclr-namespace:MySqlApp.Models     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MySqlApp     5	   	     � Title$  NowaRola��5   	   $	��450��6   $	��500��6'   ���	#FF5088FF � 	Resources 5         
enumValues S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%|   &	        S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ src:Rola��6   6/   5      5      .��5      �� $��20q�6   ���#2e3137 �� CornerRadius$ 20��6.   ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5       $��* �6    .+�5"      �� $��0��6   5$      �� 5%      ���#2e3137$��1��5&      �� 5(      $��Twoj Login :��6   $��1��5)      $
��Left=�5*      $��35��5+      $��15(�5,      $��15q�5-      
�������5.      �� 50      $��1��6   $��Right=�51      $	��250��52      $��35��53      ���#545d6a
�������$��18(�5:      ��54      �� *Przesyl.Login+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors	 . 
 �� Mode$
 TwoWay=�5:      �� 5=      $��Twoje Imie :��6   $��2��5>      $
��Left=�5?      $��35��5@      $��15q�5A      $��15(�5B      
�������5C      �� 5E      $��2��6   $��Right=�5F      $	��250��5G      $��35��5H      ���#545d6a
�������$��18(�5O      ��5I      �� *Przesyl.Imie+$ PropertyChanged=�	 . $
 TwoWay=�5O      �� 5R      $��Twoje Nazwisko :��6   $��3��5S      
�������$��Center=�5U      $
��Left=�5V      $��15q�5W      $��15(�5X      �� 5Z      $��3��6   $��Right=�5[      $	��250��5\      $��35��5]      ���#545d6a
�������$��18(�5d      ��5^      �� *Przesyl.Nazwisko+$ PropertyChanged=�	 . $
 TwoWay=�5d      �� 5g      $��Wybierz Nowa Role :��6   $��4��5h      
�������$��Center=�5j      $
��Left=�5k      $��15q�5l      $��15(�5m      �� 5q      $��4��6   $	��250��5r      $��25��5s      $��Right=�5t      
�������
���������5w      ��  �� Source# [   �� SelectedItem 5x      ��  �� Path$ Przesyl.Rola�$
 TwoWay=��� 5~      $��5��5      $��Zmien��5�      $��35��5�      $	��250��5�      $��Center=�5�      ���#545d6a
�������$��18(�5�      ��5~      �� *ButtonZmienRola+5�      5�      5�      5�      