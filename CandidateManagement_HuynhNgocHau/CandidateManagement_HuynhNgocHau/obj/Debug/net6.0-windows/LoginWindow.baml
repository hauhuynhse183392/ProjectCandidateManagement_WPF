   M S B A M L   `   `   `  ����[  WCandidateManagement_HuynhNgocHau, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:PRN221PE_FA22_TrialTest_WPF_HuynhNgocHau(PRN221PE_FA22_TrialTest_WPF_HuynhNgocHau  5   	   :    4PRN221PE_FA22_TrialTest_WPF_HuynhNgocHau.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:PRN221PE_FA22_TrialTest_WPF_HuynhNgocHau     5   	     � Title$  LoginWindow��5   	   $	��600��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�67   .��5	      � ��5
   
   �� 5       �� ImageSource$0 */9676_3c1b0f70d986fd4e324cb43331b33b81.png��6    � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ txtEmail��5      $
��Left=�6$   $��416,181,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��308��6�   $��43��6�   $��admin@hr.com.vn��6�   $��Center=�6�   $��20(�6�   ���	#FFDFF5D96  �� 5   
   $��Password��6   $
��Left=�6#   $��260,287,0,0q�6>   $	��Top=�6S   $��43��6k   $��20(�6w   $��92��6�   ���	#FF1094AD
�������6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��416,287,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��308��6�   $��43��6�   $
��123@��6�   $��Center=�6�   $��20(�6�   ���	#FFDFF5D96�   �� 5   
   $��Email��6   $
��Left=�6    $��Center=�6;   $��260,181,0,0q�6]   $	��Top=�6r   $��43��6�   $��20(�6�   $��92��6�   ���	#FF1094AD
�������6�   �� 5   
   $��Login Screen��6   $��Center=�6'   $��Center=�6I   $��0,48,0,0q�6f   $	��Top=�6x   $��48��6�   $��30(�6�   $	��192��6�   $
��Bold"�6�   ���	#FF88AD10
�������6�   �� 5   
   -   5         ��Name$ BtnLogin��5      $��Login��6#   $
��Left=�63   $��256,420,0,0q�6N   $	��Top=�6c   $��48��6�   $��96��6�   $��16(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF2279C6��6#    � Offset$ 0.013Q�65   � 5      $
 	#FF31FFD2��6#   $ 1Q�65   5      5      �� 5    
   -   5        $ 	BtnCancel��5       $��Cancel��6$   $
��Left=�65   $��640,420,0,0q�6P   $	��Top=�6e   $��48��6}   $��98��6�   $��16(�6�   ��5!      �� 5"      $ 0.5,1&�6&   $	 0.5,0&�67   .��5#      � $
 	#FF952A2A��6#   � 5$      $
 	#FFFF6060��6#   $ 1Q�65   5%      5'      �� 5(   
   -   5        $ btnRegister��5(      $��Register��6&   $��Center=�69   $��	0,420,0,0q�6V   $	��Top=�6i   $��48��6�   $��96��6�    J� RenderTransformOrigin$ 1.385,0.584&�6�   $��16(�6�   ��5)      �� 5*      $ 0.5,1&�6&   $	 0.5,0&�67   .��5+      � $
 	#FF7F9B08��6#   � 5,      $
 	#FFE3E06A��6#   $ 1Q�65   5-      5/      51      52      