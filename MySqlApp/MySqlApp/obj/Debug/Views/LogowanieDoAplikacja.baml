   M S B A M L   `   `   `  ����C  ?MySqlApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MySqlApp.ViewModelsMySqlApp.ViewModels  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   1clr-namespace:MySqlApp.ModelsMySqlApp.Models  5   	   /clr-namespace:MySqlApp.ViewsMySqlApp.Views  5	   	   )    #MySqlApp.Views.LogowanieDoAplikacja   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0vm!clr-namespace:MySqlApp.ViewModels     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -srcclr-namespace:MySqlApp.Models     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MySqlApp.Views     5	   	     � Title$  	Logowanie��5      $	��550��6   $	��500��6'   ���	#FF5088FF � DataContext 5      0   *MySqlApp.ViewModels.ViewModelLogowanieCoon  5   
    � 	Resources 5         
enumValues S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ src:LogDoServa��6   65   5      5      .��5      �� ���#2e3137 �� CornerRadius$ 20��6"   $��20q�64   ._�5   
   �� $��20q�6   .+�5      �� $��Logowanie do Bazy��6   
�������$��25(�6C   $��Center=�6Q   �� 5      6   �� 5      $��Witaj w panelu Logowania ��6   
�������$��Center=�6K   �� 5      $��Wybierz Serwer:��6   
�������6.   �� 5      -   5         ��Name$ TxLogin��5      ���#545d6a
�������$��18(�5&      ��5!      �� *LogowanieDoSerwera.server+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� ValidatesOnDataErrors
 .  �� Mode$ TwoWay=�5&      �� 5)      $��Nazwa Uzytkownika:��6   
�������61   �� 5*      -   5        $ TxHaslo��5*      ���#545d6a
�������$��18(�5/   >   ��5+      �� *LogowanieDoSerwera.user+$	 PropertyChanged=�
 . $ TwoWay=�5/   >   �� 50      $��Nazwa Bazy Danych: ��6   
�������62   �� 51      -   5        $ TxHaslos��51      ���#545d6a
�������$��18(�56   >   ��52      �� *LogowanieDoSerwera.bazadanych+$	 PropertyChanged=�
 . $ TwoWay=�56   >   �� 57      $��Haslo: ��6   
�������6&   �� 59      -   5        $ 	TxHaslosg��59      ���#545d6a
�������$��18(�5>   >   ��5:      �� *LogowanieDoSerwera.password+$	 PropertyChanged=�
 . $ TwoWay=�5>   >   �� 5A      ���	#FF2B2B2B
�������$��Center=�5C      $��28��5D      
�������$��60q�5F      $��Zaloguj Sie��5I   	   $	��150��6   ��5G   	   �� *ZalogujDoAplikacji+$	 PropertyChanged=���5K      �� 5L       �� 
TargetType" ��6   .�5M      ��  �� Property � {� �� Value . 5N       �� Triggers 5O      ^� 5P       ^� 
Conditions 5Q   "   �� 5R   &    �� Binding 60   ��  �� ElementName$ TxLogin�� �� Value true5T      �� 5U   &    60   �� $ TxHaslo�� true5W      .0�5Y   "   ��  � {� . 6>   5Z      5\      5^      5`      5a      5b      