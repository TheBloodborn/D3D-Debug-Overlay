# D3D-Debug-Overlay
Debug overlay for DirectX 3D games.

Version 1.1
 ~ Compatibility not guaranteed.
 
Run instructions:
 - Run "D3D Debug Overlay/bin/Release/D3D Debug Overlay.exe".
 - Fill in the correct EXE name for your game and press "Inject".
 - (Optional) Change settings to customize the overlay to your liking.
 - Fill in correct address offsets for the coordinates in your game and press "Display".
 - Hotkeys in game are "Ctrl" to stop and start the display, and "Alt" to hide the overlay.
 
Bug Log:
 - Alt-tabbing into a fullscreen application with a display will crash the application.
    - Workaround: Use hotkeys or DxWnd to window the game. 
 - Transitioning through a load screen will freeze the overlay updates.
    - Workaround: Use hotkeys or buttons to turn the display off and on again after transitions. 
 - Overflow errors on certain addresses in certain games (i.e. LEGO Marvel Super Heroes 2).
    - Requires further testing. 
 
Change Log (1.1):
 - Fixed overflow on memory addresses.
 - Added customization options for the overlay text.
 - Added hotkeys to hide the overlay text and to enable/disable the overlay entirely
 - Misc. code cleanup and minor fixes
