   M S B A M L   `   `   `  ����D  @RecipeGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RecipeGUI	RecipeGUI  5   	       RecipeGUI.RecipeViewer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RecipeGUI     5   	   X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  RecipeViewer��5	   	   $	��450��6   $	��640��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $
��209* �6   �� 5      $
��225* �6   .+�5   
   �� -   5         ��Name$ Title��5      $��Recipe Name��6   $��20,24,280,0q�65   $	��Top=�6J   $��50��6b   $��26(�6n   ���	#FFBDE3FF$��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ steps��5      $��340,105,20,112q�6%   $��2��6=   . �5      /� .T�5      J� .*�6   .*�5      �� $�RichTextBox��6   5      5      5      �� 5   
   -   5        $
��Back��5      $��10,190,540,10q�6    $��1��67   6D   �� 5   
   -   5        $ lSteps��5      $��Steps��6    $��480,24,60,149q�60   �� 5   
   -   5        $ 	lCalories��5      $��Calories��6#   $��380,24,180,146q�66   �� 5   
   -   5        $ rIngredients��5      $��20,105,340,112q�6,   $��2��6D   . �5      /� .T�5      J� .*�6   .*�5      �� $�RichTextBox��6   5      5      5       �� 5!   
   $
��Left=�6   $��319,139,0,55q�6.     Xceed.Wpf.Toolkit.Pie  5#   
   $
��Left=�6   $	��100��6.   $��
690,39,0,0q�6;   
���   �$	��Top=�6^   $	��100��6v   �� 5$   
   $
��Left=�6   $��319,171,0,23q�6.    J� RenderTransformOrigin$ 0.497,0.519&�6D   �� 5%   
   $
��Left=�6   $��319,204,0,0q�6.   $	��Top=�6C   $ 0.497,0.519&�6[   $��2��6   �� 5&   
   $
��Left=�6   $��319,30,0,180q�6.   $ 0.497,0.519&�6D   $��1��6h   �� 5'   
   $
��Left=�6   $��319,65,0,145q�6.   $ 0.497,0.519&�6D   $��1��6h   �� 5(   
   $����Calorie Ranges:
Low: Typically under 300 calories per serving.
Moderate: Ranging from 300 to 600 calories per serving.
High: Above 600 calories per serving.��6   $��305,130,25,10q�6�   $��1��6�   5*      5+      