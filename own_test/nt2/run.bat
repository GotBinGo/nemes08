rem RUN %1=TestDir %2=Feladatnev %3=teszteset
rem Set TK=\NT2
If Exist %2.st%3 GoTo VOLT
If Exist %2.ki Del %2.ki >Nul
If Exist %2.ki%3 Del %2.ki%3 >Nul
If Exist %2.exe GoTo EXE
\NT2\stime %2.st%3
Echo %2.exe nem található!
Goto VOLT
:EXE

Copy %1\%2.be%3 %2.be >Nul
rem Cls
\NT2\fut.exe %2 %3

\NT2\stime.exe %2.st%3
%2.exe > %2.so%3
\NT2\ftime.exe %2.st%3
Copy %2.ki %2.ki%3 >Nul

rem Echo                                        befejezõdött.

:VOLT
