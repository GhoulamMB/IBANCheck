   M S B A M L   `   `   `  ????E  AIBAN_Check, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:IBAN_Check
IBAN_Check  5   	   ;"clr-namespace:IBAN_Check.ViewModelIBAN_Check.ViewModel  5   	       IBAN_Check.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:IBAN_Check     5   	   1vm"clr-namespace:IBAN_Check.ViewModel     5   	     ? Title$  
MainWindow??5	   	   $	??400??6   $	??400??6)    ? 	Resources 5
      !   IBAN_Check.ViewModel.ibanVM   vm??%   &	          5   
   6   5      .??5      ??  ? DataContext# [  6   .+?5   
   ?? $??IBAN:??6   ?? 5   
   -   5         ??Name$
 IBAN??5      
???????$	??Top=?5      ??5      ?? *Iban+ ?? Mode$ TwoWay=??? 5   
   $??Get Data??6   $??Center=?5      $
??0 10q?5      ??5      ?? *FetchCommand+??5      ?? *Iban+?? 5   
   $
??0 10q?6   ?? 5   
   # [  6   .+?5      ?? ??6   ?? *	details+ ?? View 5      ?? 5      .P?5      ?? $??Country??5       ?? Width$
 auto??5        ?? DisplayMemberBinding 5      ?? *	Country+5       ?? 5!      $??	Bank Code??5"      $
 auto??5$       5#      ?? *
BankCode+5$      ?? 5%      $??
Account No??5&      $
 auto??5(       5'      ?? *	AccountNo+5(      ?? 5)      $??Branch??5*      $
 auto??5,       5+      ?? *Branch+5,      5-      5/      50      51      52      