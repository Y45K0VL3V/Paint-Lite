   M S B A M L   `   `   `  ����Q  Myakov.OOP.Drawing.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:yakov.OOP.Drawing.Viewyakov.OOP.Drawing.View  5   	   '    !yakov.OOP.Drawing.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:yakov.OOP.Drawing.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��950��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6      PrimaryHueDarkBrush#��[  6+   .��5      � .+�5      �� $��Color��6     SecondaryHueMidBrush#��[ 6)   $
��Left=�6\   $��16,0,0,0q�6w   �� 5       # MaterialDesignChoiceChipListBox#��[ 6   $��	150,0,0,0q�6S   $��Center=�6f   $	��725��6�   $��14(�6�    �� SelectedIndex 6�   �� *	UsingTool+.@�5      ��  �� 
IsSelected 6"   �� *IsPenSelected+ �� Mode$ OneWayToSource=�.��5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��Pen��6(   $��Center=�63   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Pencil=�66   $��Center=�6D   5      5      �� 5       6"   �� *IsPenSelected+$ OneWayToSource=�.��5      �� $ 
Horizontal=�6%   .+�5      �� $��Brush��6(   $��Center=�65     5      $ Brush=�66   $��Center=�6C   5       5!      �� 5"       6"   �� *IsLineSelected+$ OneWayToSource=�.��5#      �� $ 
Horizontal=�6%   .+�5$      �� $
��Line��6(   $��Center=�64     5%      $ Minus=�66   $��Center=�6C   5&      5'      �� 5(       6"   �� *IsRectSelected+$ OneWayToSource=�.��5)      �� $ 
Horizontal=�6%   .+�5*      �� $
��Rect��6(   $��Center=�64     5+      $ RectangleOutline=�66   $��Center=�6N   5,      5-      �� 5.       6"   �� *IsRectRoundedSelected+$ OneWayToSource=�.��5/      �� $ 
Horizontal=�6%   .+�50      �� $��Rect Rounded��6(   $��Center=�6<     51      $ SquareRoundedOutline=�66   $��Center=�6R   52      53      �� 54       6"   �� *IsSquareSelected+$ OneWayToSource=�.��55      �� $ 
Horizontal=�6%   .+�56      �� $��Square��6(   $��Center=�66     57      $ SquareOutline=�66   $��Center=�6K   58      59      �� 5:       6"   �� *IsEllipseSelected+$ OneWayToSource=�.��5;      �� $ 
Horizontal=�6%   .+�5<      �� $��Ellipse��6(   $��Center=�67     5=      $ EllipseOutline=�66   $��Center=�6L   5>      5?      �� 5@       6"   �� *IsCircleSelected+$ OneWayToSource=�.��5A      �� $ 
Horizontal=�6%   .+�5B      �� $��Circle��6(   $��Center=�66     5C      $ CircleOutline=�66   $��Center=�6K   5D      5E      5F      �� 5G      $��
950,0,15,0q�6   $��38��6.   $��Center=�6:   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Width��5H      $��14(�6A   $��0��6O   $��45��6\   $��Center=�5I   Z   $��Center=�6|   ��6   �� *	WidthText+ �� UpdateSourceTrigger$ PropertyChanged=�6|   5J      5K      �� 5N   
   -   5        	 ��Name$	 canvasDrawingSpace��5N      $��1��6-   $��Stretch=�6:   $��Stretch=�6V   
�������*  $Microsoft.Xaml.Behaviors.Interaction
   Triggers
 5O      +  %Microsoft.Xaml.Behaviors.EventTrigger  5P         	EventName$ MouseLeftButtonDown��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5Q      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *LeftButtonDown+5R        5S      $ MouseLeftButtonUp��6!   . 5T         6,   �� *LeftButtonUp+5U        5V      $ 	MouseMove��6!   . 5W         6,   �� *LeftButtonDrag+5X        5Y      $ 
MouseEnter��6!   . 5Z         6,   �� *MouseCanvasEnter+5[      5]      �� 5_   
   $ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   $��	60,16,0,0q�6a   .+�5`      �� $��38��6   $��38��6$    �� RadiusX$ 5��6/    �� RadiusY$ 5��6;   ��6G   �� *
PenColor+�� 5a      $��38��6   $��38��6$   $ 5��6/   $ 5��6;   $��10,0,0,0q�6G   ��6Y   �� *
BrushColor+5b      �� 5e   
   -   5         ��Name$ borderColorPick��5e      $��2��6*   $
��Left=�5f      $	��Top=�6,   $��16q�6D   $	��200��5g      $	��200��6!   $��38��60   
���   �$��1q�5h   %    �� CornerRadius$ 5��69   
������ ._�5k      *  $MaterialDesignThemes.Wpf.ColorPicker  -   5        $��	colorPick��5k   )      Color 6:   �� *
UsingColor+$ OneWayToSource=�5l      5m      5n      