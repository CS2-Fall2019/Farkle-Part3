   M S B A M L   `   `   `  ����A  =farkle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:farklefarkle  5   	       farkle.Winner   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:farkle     5   	     � Title$  Winner��5   	   $	��450��6   $	��800��6%   ���	#FF36DA81.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      .+�5   
   �� -   5         ��Name$ 	lblWinner��5      $$��Congradulations Player 1 wins!��6#   $
��Left=�6L   $��
120,76,0,0q�6g   $	��Top=�6{   $
��Bold"�6�   $��36(�6�   $	��543��6�   $��61��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
btnNewGame��5      $��Start New Game��6%   $
��Left=�6>   $��120,305,0,0q�6Y   $	��Top=�6n   $	��122��6�   $��55��6�   6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $
��Left=�61   $��326,305,0,0q�6L   $	��Top=�6a   $	��122��6y   $��55��6�   6�   	� 5   
   -   5         	�Name$ rdoOnePlayer��5      $��1 Player��6,   $
��Left=�6?   $��120,142,0,0q�6Z   $	��Top=�6o    d� 	IsChecked$
 TrueY�6�   $��22(�6�    	� 	GroupName$ 	PlayerAmt��6�   	� 5   
   -   5        $ rdoThreePlayers��5      $��	3 Players��6/   $
��Left=�6C   $��235,142,0,0q�6^   $	��Top=�6s   $��22(�6�   $ 	PlayerAmt��6�   	� 5   
   -   5        $ rdoTwoPlayer��5      $��	2 Players��6,   $
��Left=�6@   $��120,177,0,0q�6[   $	��Top=�6p   $��22(�6�   $ 	PlayerAmt��6�   	� 5   
   -   5        $ rdoFourPlayers��5      $��	4 Players��6.   $
��Left=�6B   $��235,177,0,0q�6]   $	��Top=�6r   $��22(�6�   $ 	PlayerAmt��6�   	� 5   
   -   5        $ rdoNoAI��5      $��No AI��6'   $
��Left=�67   $��375,230,0,0q�6R   $	��Top=�6g   $��22(�6   $ AiAmt��6�   $
 TrueY�6�   	� 5   
   -	   5        $ rdoOneAI��5      $
��1 AI��6(   $
��Left=�67   $��120,231,0,0q�6R   $	��Top=�6g   $��22(�6   $ AiAmt��6�   	� 5   
   -
   5        $ 
rdoThreeAI��5      $
��3 AI��6*   $
��Left=�69   $��235,230,0,0q�6T   $	��Top=�6i   $��22(�6�   $ AiAmt��6�   $
 TrueY�6�   	� 5   
   -   5        $ rdoTwoAI��5      $
��2 AI��6(   $
��Left=�67   $��120,261,0,0q�6R   $	��Top=�6g   $��22(�6   $ AiAmt��6�   	� 5   
   -   5        $ 	rdoFourAI��5      $
��4 AI��6)   $
��Left=�68   $��235,261,0,0q�6S   $	��Top=�6h   $��22(�6�   $ AiAmt��6�   	� 5   
   -   5        $ rdoEasy��5      $
��Easy��6'   $��1��66   $
��Left=�6F   $��
45,205,0,0q�6a   $	��Top=�6u   $��22(�6�   $ 
Difficulty��6�   $
 TrueY�6�   	� 5   
   -   5        $ rdoHard��5      $
��Hard��6'   $��1��66   $
��Left=�6F   $��
45,258,0,0q�6a   $	��Top=�6u   $��22(�6�   $ 
Difficulty��6�   5      5      