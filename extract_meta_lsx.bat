"./DOS_export_tool-v1.14.1/divine.exe" -a extract-single-file -s "H:\Games\games\SteamApps\common\Divinity Original Sin Enhanced Edition\Data\Main.pak" -d "%CD%/Dos4Player/Resources/meta.lsx" -f "Mods/Main/meta.lsx" 
powershell -Command "(gc "%CD%/Dos4Player/Resources/meta.lsx") -replace 'NumPlayers\" value=\"2', 'NumPlayers\" value=\"4' | Out-File -encoding ASCII "%CD%/Dos4Player/Resources/meta.lsx"
powershell -Command "Copy-Item ./Dos4Player/Resources/meta.lsx -Destination ./Dos4Player/Resources/meta.lsx.txt"
REM https://github.com/Norbyte/lslib
pause