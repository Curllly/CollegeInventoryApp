   M S B A M L   `   `   `  ����K  GCollegeInventory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:CollegeInventory.Views.CRUD.Room CollegeInventory.Views.CRUD.Room  5   	   4    .CollegeInventory.Views.CRUD.Room.AddRoomWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:CollegeInventory.Views.CRUD.Room     5   	     � Title$  AddRoomWindow��5   	   $	��450��6   $	��800��6,   .��5	      �� ���#2b2b2e � 	Resources 5
   
    �� 
TargetType �� Property �� Value��%J  '��       '�� �     '�� �     �� 5      " ��6   .�5      ��  � ��$ 22(�6-   �� 5       � �� �#F8F8F86/   �� 5       � ��$ DemiBold"�6/   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      �� 5      " ��6   .�5      ��  � ��$ 22(�6-   5      5      .+�5   
   �� $��Center=�6   $��Center=�6-   $#��Номер помещения��5      �� 5   
   
�������$	��300��6)   ��5      �� *Room.Number+�� 5   
   $��Center=�6   $��Center=�6-   $��Тип помещения��5      �� 5   
   
�������$	��300��6*   ��5      �� *	RoomTypes+ �� SelectedItem 5      �� *Room.RoomType+��5       �� 5!      .R�5"      �� �� 5#      �6   �� *Name+5$      5%      5'      �� 5(   
   $��Center=�6   $��Center=�6-   $ ��Ответственный��5)      �� 5*   
   
�������$	��300��6)   ��5+      �� *Room.Responsible+�� 5,   
    �� Orientation$ 
Horizontal=�6   $��Center=�5-      $
��0 50q�5.      .+�5/      �� $��Сохранить��6   ��50      �� *	AddOrEdit+�� 51      $��50 0 0 0q�6   $��Отменить��6'   ��52      �� *Exit+53      54      55      