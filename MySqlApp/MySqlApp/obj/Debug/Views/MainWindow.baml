   M S B A M L   `   `   `  ����C  ?MySqlApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MySqlApp.ViewModelsMySqlApp.ViewModels  5   	   1clr-namespace:MySqlApp.ModelsMySqlApp.Models  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   #clr-namespace:MySqlAppMySqlApp  5	   	       MySqlApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0vm!clr-namespace:MySqlApp.ViewModels     5   	   -srcclr-namespace:MySqlApp.Models     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MySqlApp     5	   	     � Title$  Panel Sterowania��5   	   $	��750��6"   $
��1125��6/   ���	#FF5088FF � 	Resources 5         
enumValues S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%|   &	        S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ src:Rola��6   6/   5      5      .��5      �� ���#2e3137 �� CornerRadius$ 20��6"   $��20q�64   ._�5   
   � $��10q�6   ���#2e3137 � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $	��350 �6   �� 5      $��55 �6   �� 5      $��* �6    � ColumnDefinitions 5!   
   �� 5"      $��25 �6   �� 5#      $��* �6   �� 5$      $��25 �6   .+�5'      �� $��1��6   $��3��5(      $ 10��5)      ._�5*      � $��3��6   $��1��5+      $��2��5,      ���	#FF5088FF$��Center=�5.      $��Center=�5/      .+�52      �� 
�������$��Usuń��54      $	��140��55      $��35��56      $��10q�57      ���#545d6a
�������$��18(�5>      {�58      �� *SelectedItems.Count+	 �� ElementName$	 ListaWyswietlenie����5:      �� *Usuń+
 �� UpdateSourceTrigger$
 PropertyChanged=�5>      �� 5B      
�������$��	Odśwież��5D      $	��140��5E      $��35��5F      $��10q�5G      ���#545d6a
�������$��18(�5M      ��5I      �� *	Odśwież+$
 PropertyChanged=�5M      �� 5O      
�������$��	Wyczyść��5Q      $	��140��5R      $��35��5S      $��10q�5T      ���#545d6a
�������$��18(�5Y      ��5U      �� *	Wyczyść+$
 PropertyChanged=�5Y      �� 5]      
�������$��
Zmien Role��5_      $	��140��5`      $��35��5a      $��10q�5b      ���#545d6a
�������$��18(�5i      {�5c      �� *SelectedItems.Count+$	 ListaWyswietlenie����5e      �� *
Zmienianie+$
 PropertyChanged=�5i      �� 5k      
�������$��Zmień Hasło��5m      $	��140��5n      $��35��5o      $��10q�5p      ���#545d6a
�������$��18(�5u      ��5q      �� *
ZmienHaslo+$
 PropertyChanged=�{�5v      �� *SelectedItems.Count+$	 ListaWyswietlenie���� 5y      
�������$��Zresetuj Hasło��5{      $	��160��5|      $��35��5}      $��10q�5~      ���#545d6a
�������$��18(�5�      ��5      �� *ZmienHaslaVol2+$
 PropertyChanged=�{�5�      �� *SelectedItems.Count+$	 ListaWyswietlenie���� 5�      
�������$��Dodaj��5�      $	��140��5�      $��35��5�      $��10q�5�      ���#545d6a
�������$��18(�5�      ��5�      �� *	DodajVM+$
 PropertyChanged=�5�      5�      5�      �� 5�      -   5         ��Name$ ListaWyswietlenie��5�      
�������$��1��5�      $��2��5�      $��1��5�       �� AlternationCount$ 2��5�       �� SelectedItem 5�      �� *Zaznaczenie+��5�      �� *PrzeslaneDane+$
 PropertyChanged=� �� View 5�      �� 5�      .P�5�      �� $
��Imie��6%    �� Width$ 90��63    �� DisplayMemberBinding 6>   �� *Imie+�� 5�      $��Nazwisko��6%   $ 90��67    6C   �� *
Nazwisko+�� 5�      $��Login��6%   $ 90��64    6?   �� *Login+�� 5�      $��Haslo��6%   $	 220��64    6@   �� *Haslo+�� 5�      $��	HasloSalt��6%   $	 220��68    6D   �� *	HasloSalt+�� 5�      $
��Data��6%   $	 140��63    6?   �� *Data+�� 5�      $
��Rola��6%   $	 120��63    6?   �� *Rolax+5�      5�      5�      5�      5�      