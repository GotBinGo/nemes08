echo off
Set TK=\nt2
Set TD=\nt2\2
Set F1=tag
Set Te1=1 2 3 4 5 6 7 8
Set F2=ismer
Set Te2=1 2 3 4 5 6 7
Set F3=pakol
Set Te3=1 2 3 4 5 6 7 8
Set F4=vitorlas
Set Te4=1 2 3 4 5

If Exist %F1%.EXE GoTo R1

echo %F1%.EXE nem tal†lhat¢!
GoTo T2

:R1
Echo %F1% feladat futtat†sa ....
for %%x In (%Te1%) Do Call %TK%\RUN %TD% %F1% %%x
Echo %F1% feladat futtat†sa befejezãdîtt.

:T2
If Exist %F2%.EXE GoTo R2

echo %F2%.EXE nem tal†lhat¢!
GoTo T3
:R2
Echo %F2% feladat futtat†sa ....
for %%x In (%Te2%) Do Call %TK%\RUN %TD% %F2% %%x
Echo %F2% feladat futtat†sa befejezãdîtt.

:T3
If Exist %F3%.EXE GoTo R3

echo %F3%.EXE nem tal†lhat¢!
GoTo T4
:R3
Echo %F3% feladat futtat†sa ....
for %%x In (%Te3%) Do Call %TK%\RUN %TD% %F3% %%x
Echo %F3% feladat futtat†sa befejezãdîtt.

:T4
If Exist %F4%.EXE GoTo R4

echo %F4%.EXE nem tal†lhat¢!
GoTo T5
:R4
Echo %F4% feladat futtat†sa ....
for %%x In (%Te4%) Do Call %TK%\RUN %TD% %F4% %%x
Echo %F4% feladat futtat†sa befejezãdîtt.

:T5

:TV
echo FUTTATµS VêGETêRT

echo A %F1% feladat ÇrtÇkelÇse ....
%TD%\%F1% %TD% %F1%

echo A %F2% feladat ÇrtÇkelÇse ....
%TD%\%F2% %TD% %F2%

echo A %F3% feladat ÇrtÇkelÇse ....
%TD%\%F3% %TD% %F3%

echo A %F4% feladat ÇrtÇkelÇse ....
%TD%\%F4% %TD% %F4%


%TK%\osszes %TD%

echo AZ êRTêKELêS BEFEJEZäDôTT!
echo ***********************************************
echo A teljes ÇrtÇkelÇs az EREDMENY.TXT †llom†nyban.
echo ***********************************************

:VEGE
