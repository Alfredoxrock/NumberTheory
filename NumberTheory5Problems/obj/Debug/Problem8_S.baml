   M S B A M L   `   `   `  ����P  LNumberTheory5Problems, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:NumberTheory5ProblemsNumberTheory5Problems  5   	   &     NumberTheory5Problems.Problem8_S   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:NumberTheory5Problems     5   	     � Title$  
Problem8_S��5   	   $	��800��6   $
��1250��6)    � WindowState$ 	Maximized=�66   .��5	      � ��5
   
   �� 5       �� ImageSource$ 
MathWP.jpg��6   .+�5   
   �� $��	PROBLEM 8��6   $��Center=�6$   $	��top=�6A   $��90(�6Y   $��Army Buster)�6}   ���	#FFF6FFED$	��111��6�   $��433,0q�6�   ��6g   Z� 6�   �� 5   
   -   5         ��Name$ Textbox_Output��5      $��15(�6,   $
��Left=�6:   $��154,152,0,0q�6U   $
��Wrap=�6j   $'��!WAITING FOR USER TO INSERT VALUES��6~    �� Padding$ 20,20,20,20q�6�   $	��Top=�6�   $	��477��6�   $
��1007��6�   
���   ����	#FF00FF17$��Courier New)�6  �� 5   
   -   5         ��Name$ 	Textbox_n��5      $��Center=�6%   $��Center=�6I   
���   �$��25(�6~   $
��Left=�6�   $��154,692,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��50��6�   $	��132��6�   ���	#FF29FF00$��Courier New)�6  �� 5   
   -   5        $ 	Textbox_k��5      $��Center=�6%   $��Center=�6I   
���   �$��25(�6~   $
��Left=�6�   $��307,692,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��50��6�   $	��132��6�   ���	#FF29FF00$��Courier New)�6  �� 5   
   -   5        $ Textbox_powN��5      $��Center=�6(   $��Center=�6L   
���   �$��25(�6�   $
��Left=�6�   $��459,692,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��50��6�   $	��164��6�   ���	#FF29FF00$��Courier New)�6"  �� 5   
   -   5        $ Textbox_PowK��5      $��Center=�6(   $��Center=�6L   
���   �$��25(�6�   $
��Left=�6�   $��640,692,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��50��6�   $	��164��6�   ���	#FF29FF00$��Courier New)�6"  �� 5   
   -   5         ��Name$ Label_n��5      $��Center=�6!   $��Center=�6C   $��N MAX��6g   
�������$��25(�6�   $
��Left=�6�   $��154,634,0,0q�6�   $	��Top=�6�   $��50��6�   $	��132��6�   
���   �$��Courier New)�6  $
��Bold"�6$  �� 5   
   -   5        $ Label_n_Copy��5      $��Center=�6&   $��Center=�6H   $��K MAX��6l   
�������$��25(�6�   $
��Left=�6�   $��307,634,0,0q�6�   $	��Top=�6�   $��50��6�   $	��132��6�   
���   �$��Courier New)�6  $
��Bold"�6)  �� 5   
   -   5        $ Label_n_Copy1��5      $��Center=�6'   $��Center=�6I   $��
POWER OF N��6m   
�������$��25(�6�   $
��Left=�6�   $��459,634,0,0q�6�   $	��Top=�6�   $��50��6�   $	��164��6�   
���   �$��Courier New)�6  $
��Bold"�6/  �� 5   
   -	   5        $ Label_n_Copy2��5      $��Center=�6'   $��Center=�6I   $��
POWER OF K��6m   
�������$��25(�6�   $
��Left=�6�   $��640,634,0,0q�6�   $	��Top=�6�   $��50��6�   $	��164��6�   
���   �$��Courier New)�6  $
��Bold"�6/  �� 5   
   -
   5         ��Name$ Button_Next��5      $	��RUN��6&   $��25(�64   $
��Left=�6B   $��833,634,0,0q�6]   $	��Top=�6r   $	��249��6�   $��50��6�   6�   �� 5   
   -   5        $ Button_Next1��5      $
��NEXT��6'   $��25(�66   $
��Left=�6D   $��833,692,0,0q�6_   $	��Top=�6t   $	��249��6�   $��50��6�   ���	#FF0B57196�   5      5      