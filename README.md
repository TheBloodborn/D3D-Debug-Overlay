# D3D-Debug-Overlay
Debug overlay for DirectX 3D games.

Version 1.2
 ~ Compatibility not guaranteed.
 
Run instructions:
 - Run "D3D Debug Overlay/bin/Release/D3D Debug Overlay.exe".
 - Fill in the correct EXE name for your game and press "Inject".
 - (Optional) Change settings to customize the overlay to your liking.
 - (Optional) Configure the door finding tool to your liking.
 - Fill in correct address offsets for the coordinates in your game and press "Display".
 - Hotkeys in game are "Ctrl" to hide the overlay and "Ctrl + Shift" to stop and start the display.

Door Finding Tool List Instructions:
 - Create a .txt file in "D3D Debug Overlay/bin/Release" with the same name as the game exe (ex: LEGOlotr.exe.txt).
 - Add each door to a new line as such: "Name;X Margin 1;X Margin 2;Y Margin 1;Y Margin 2;Z Margin 1;Z Margin 2".
 
Bug Log:
 - Alt-tabbing into a fullscreen application with a display will crash the application.
    - Workaround: Use hotkeys or DxWnd to window the game. 
 - Transitioning through a load screen will freeze the overlay updates.
    - Workaround: Use hotkeys or buttons to turn the display off and on again after transitions. 
 - Overflow errors in certain games (i.e. LEGO Marvel Super Heroes 2).
    - Requires further testing. 
 
Change Log (1.1):
 - Fixed overflow on memory addresses.
 - Added customization options for the overlay text.
 - Added hotkeys to hide the overlay text and to enable/disable the overlay entirely.
 - Misc. code cleanup and minor fixes.

Change Log (1.2):
 - Force changed to 64-bit to resolve overflow errors
 - Added door finding tool.
 - Added saving and loading for settings.
 - Misc. code cleanup and minor fixes.
