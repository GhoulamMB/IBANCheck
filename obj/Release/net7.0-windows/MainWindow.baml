   M S B A M L   `   `   `  ???? E  AIBAN_Check, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:IBAN_Check
IBAN_Check  ;"clr-namespace:IBAN_Check.ViewModelIBAN_Check.ViewModel      IBAN_Check.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:IBAN_Check     1vm"clr-namespace:IBAN_Check.ViewModel       ? Title$  
MainWindow??$	??400??$	??400?? ? 	Resources !   IBAN_Check.ViewModel.ibanVM   vm??%   &	          .????  ? DataContext# [  .+??? $??IBAN:???? -    ??Name$
 IBAN??
???????$	??Top=????? *Iban+ ?? Mode$ TwoWay=??? $??Get Data??$??Center=?$
??0 10q????? *FetchCommand+???? *Iban+?? $
??0 10q??? # [  .+??? ???? *	details+ ?? View ?? .P??? $??Country?? ?? Width$
 auto?? ?? DisplayMemberBinding ?? *	Country+?? $??	Bank Code??$
 auto?? ?? *
BankCode+?? $??
Account No??$
 auto?? ?? *	AccountNo+?? $??Branch??$
 auto?? ?? *Branch+