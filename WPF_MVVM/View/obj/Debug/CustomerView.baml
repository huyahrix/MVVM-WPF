   M S B A M L   `   `   `  ����D  @ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:ViewModel;assembly=ViewModel	ViewModel  5   
    View   View.CustomerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <local*clr-namespace:ViewModel;assembly=ViewModel     5   
     � Title$  Customer��5   	   $��607.362��6   $��835.702��6+    � DataContext 5      !   ViewModel.CustomerViewModel  5   
   6$   .��5	      �� .+�5
   
   �� -   5         ��Name$ lstShow��5
      $	��410��6G   
���������6$   �� *	Customers+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� CellTemplate 5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   �� $��X��6-   5   '   �� 5   &   $�� ��60   �� 5   &   {�.  �� 
IsReadOnly . ��6?   �� *	AccountID+6Z   5   #   5      5      �� 5      $
��Name��6%    5      �� 5      .R�5   "   � .+�5   &   �� {�.  . ��6?   �� *AccountNameU+6]   5   #   5      5!      5"      5$      �� 5%   
   �� 5&   
   $��10,0,0,0q�6   .+�5'      �� -   5         ��Name$ AddEditPanel��5'      .+�5(      �� $
��ID: ��6    �� 5)      -   5         ��Name$ txtID��5)   B   $
��Left=�6   $	��292��66   ��6Q   �� *SelectedItem.AccountID+	 �� ElementName$	 lstShow��
 �� Mode$
 OneWay=��� 5*      $��Name: ��6!   �� 5+      -   5        $ txtName��5+   A   $
��Left=�6   $	��300��65   ��6T   �� *SelectedItem.AccountNameU+$	 lstShow��$
 OneWay=�5,      �� 5-      �� 5.      $ 
Horizontal=�6   .+�5/      �� -   5        $��btnAdd��5/      $	��Add��6(   ��50   )   �� *AddCommnand+��51   (   �� *
Children+$	 AddEditPanel���� 52      -   5        $��
btnDlelete��52      $��Delete��6+   ��53   )   �� *DeleteCommand+��54   )   �� *SelectedItem+$	 lstShow���� 55      -   5        $��btnEdit��55      $
��Edit��6(   ��56   )   �� *EditCommmand+��57   )   �� *
Children+$	 AddEditPanel��58      59      5:      5;      