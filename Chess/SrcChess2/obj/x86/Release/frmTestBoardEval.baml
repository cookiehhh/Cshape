   M S B A M L   `   `   `  ����   	SrcChess2     SrcChess2.frmTestBoardEval   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Test Board Evaluator��$	��300��$	��591�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=�.��]� -   $��
dockPanel1��$��Stretch=�$��0q�$��Stretch=�.+��� -   $��stackPanel1�� �� Orientation$ 
Horizontal=�$��Center=�$��Bottom=�$��Bottom=�.+��� -   $��butOk��$��Ok��$��23��$��75��$��10q� �� 	IsDefault . �� -   $��	butCancel��$��Cancel��$��23��$��75��$��10q� �� IsCancel . �� -   $��stackPanel2��.+��� -   $��	groupBox1��$��Board Evaluation��$
��5,22q�.��A�  A� Rows$ 1�� A� Columns$ 2��.+��� -   $��stackPanel4��.+��� -   $��label1��$��	Method #1��$��28��$��Center=��� -	   $��comboBoxWhiteBEval��$��23��$	��5,0q��� -
   $��stackPanel5��.+��� -   $��label2��$��	Method #2��$��28��$��Center=��� -   $��comboBoxBlackBEval��$��23��A� $ 1��$ 2��.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��label3��$��Number of Ply:��$��28��$��Center=��� -   $��	plyCount2��$��XX��$��28��$��Center=��� -   $��plyCount��$��23��$	��100�� �� SelectionEnd$ 8Q�	 �� SelectionStart$	 2Q�
 � SmallChange$
 1Q� �� TickPlacement$ BottomRight=�$	��5,0q� �� IsSnapToTickEnabled .  � Minimum$ 2Q� � Maximum$ 8Q��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��label4��$��Number of Games:��$��28��$��Center=��� -   $��
gameCount2��$��XXXXXX��$��28��$��Center=�$��55���� -   $��	gameCount��$��23��$	��100��$ 10000Q�$	 2Q�$
 2Q�$ BottomRight=�$	��5,0q� �� TickFrequency$
 1000Q�$ 10000Q�$ 2Q� .   �� IsSelectionRangeEnabled .   � LargeChange$ 2Q�