   M S B A M L   `   `   `  ����K  GCollegeInventory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:CollegeInventory.Views.CRUD.Furniture%CollegeInventory.Views.CRUD.Furniture  5   	   >    8CollegeInventory.Views.CRUD.Furniture.AddFurnitureWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:CollegeInventory.Views.CRUD.Furniture     5   	     � Title$  AddFurnitureWindow��5   	   $	��450��6$   $	��800��61   .��5	      �� ���#2b2b2e � 	Resources 5
   
    �� 
TargetType �� Property �� Value��%J  '��       '�� �     '�� �     �� 5      " ��6   .�5      ��  � ��$ 22(�6-   �� 5       � �� �#F8F8F86/   �� 5       � ��$ DemiBold"�6/   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      5      .+�5   
   �� $��Center=�6   $��Center=�6-   $'��!Инвентарный номер��5      �� 5   
   
�������$	��300��6)   ��5      �� *Furniture.InventoryNumber+�� 5   
   $��Center=�6   $��Center=�6-   $(��"Элемент из матрицы��5      �� 5   
   
�������$	��300��6*   ��5      �� *
Matrices+ �� SelectedItem 5      �� *Furniture.Matrix+��5       �� 5!      .R�5"      �� ��6    �� *Name+5#      5%      �� 5&   
   $��Center=�6   $��Center=�6-   $��Дата покупки��5'      �� 5(   
   
�������$	��300��6)    �� 
IsReadOnly$
 True��65   ��5)      �� *Furniture.PurchaseDate+�� 5+   
    �� Orientation$ 
Horizontal=�6   $��Center=�5,      $
��0 50q�5-      .+�5.      �� $��Сохранить��6   �� 5/      $��50 0 0 0q�6   $��Отменить��6'   50      51      52      