echo Compiling C#
msbuild DragonVM.sln

echo Running file
EXE=DragonVM/bin/Debug/DragonVM.exe

mono $EXE