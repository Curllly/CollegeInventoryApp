   M S B A M L   `   `   `  ����K  GCollegeInventory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:CollegeInventory.Views.CRUD.Location$CollegeInventory.Views.CRUD.Location  5   	   <    6CollegeInventory.Views.CRUD.Location.AddLocationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >local2clr-namespace:CollegeInventory.Views.CRUD.Location  5   	     � Title$  AddLocationWindow��5	   	   $	��450��6#   $	��800��60   .��5
      �� ���#2b2b2e � 	Resources 5   
    �� 
TargetType �� Property �� Value��%J  '��       '�� �     '�� �     �� 5      " ��6   .�5      ��  � ��$ 22(�6-   �� 5       � �� �#F8F8F86/   �� 5       � ��$ DemiBold"�6/   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      5      .+�5   
   �� $��Center=�6   $��Center=�6-   $'��!Инвентарный номер��5      �� 5   
   
�������$	��300��6)   ��5      �� *InventoryNumber+�� 5   
   $��Center=�6   $��Center=�6-   $#��Номер помещения��5      �� 5   
   
�������$	��300��6*   ��5      �� *Rooms+ �� SelectedItem 5       �� *Room+��5!      �� 5"      .R�5#      �� ��6    �� *Number+5$      5&      �� 5'   
   $��Center=�6   $��Center=�6-   $��Дата покупки��5(      �� 5)   
   
�������$	��300��6)    �� 
IsReadOnly$
 True��5*   ,   ��6   �� *LocationDate+6,   �� 5,   
    �� Orientation$ 
Horizontal=�6   $��Center=�5-      $
��0 50q�5.      .+�5/      �� $��Сохранить��6   ��50      �� *	AddOrEdit+�� 51      $��50 0 0 0q�6   $��Отменить��6'   ��6:   �� *Exit+52      53      54      