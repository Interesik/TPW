   M S B A M L   `   `   `  ����M  IMarblesKKViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:MarblesKKViewModel;assembly=MarblesKKViewModelMarblesKKViewModel  5   	    	MarblesKK   MarblesKK.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmw<clr-namespace:MarblesKKViewModel;assembly=MarblesKKViewModel     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1000��6)    � 
ResizeMode$ NoResize=�66    � DataContext 5	      #   MarblesKKViewModel.MViewModel  5
   
   .��5      � ���	#FF71FF08.+�5   
   �� $��
Rozpocznij��6,   $
��Left=�6A   $��800,650,0,0q�6\   $	��Top=�6q   $��50��6�   $	��105��6�   ��6   �� *Start+6�   �� 5   
   $��Resetuj��6.   $��Center=�6@   $��150,650,0,0q�6]   $	��Top=�6r   $��50��6�   $	��104��6�   ��6   �� *	Restart+6�   �� 5   
   $
��Stop��6+   $��Center=�6:   $��-400,650,0,0q�6W   $	��Top=�6m   $��50��6�   $	��104��6�   ��6   �� *Stop+6�   �� 5   
   -   5        $��TextBoxMain��5      $
��Left=�6|   $��100,670,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�    �� TextAlignment$ Center=�6�   $	��108��6�   $��18��6�    J� RenderTransformOrigin$ 
0.546,0.28&�6  ��6%   ��  �� Path$ AmountOfMurbles� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5   
   ��6   �� $ marbles���5      �� 5      .R�5      �� $��Canvas_Main��6   $	��640��60   $	��480��6<   $��	0,0,0,100q�6J   
��� ���6]   5      ��5      �� 5      	 �� 
TargetType"	 ��6   .�5      �� 
 �� Property
 �@��Left �� Value 64   �� *Posx+�� 5      
 �@��Top 63   �� *Posy+5      ��5      �� 5      .R�5       A� 
���  ����6   �� *Radius+��67   �� *Radius+6Q   5!      5#      �� 5$   
   $��100,693,0,0q�6   $
��Left=�6)   $	��Top=�6D   $��Liczba kul:��6\   �� 5%      �6   �� $ marbles.Count�$ OneWay=�5&      5'      5(      