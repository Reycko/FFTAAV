echo FFMpeg dir? (Leave empty to leave as default)
echo.
set /p ffmpeg=
echo.
echo Input file? (Insert inside of "" symbols)
echo.
set /p input=
echo.
echo Output file? (Insert inside of "" symbols)
echo.
set /p output=
echo.
echo Output resolution? (Will not affect the raw data scaling, leave empty for default of 240x240)
echo.
set /p outputres=
echo.
if outputres=="" (set outputres=240x240)
if ffmpeg=="" (set ffmpeg=ffmpeg) 

rem Command line input.
%ffmpeg% -f rawvideo -pixel_format rgb32 -video_size 32x32 -framerate 10.766666 -i %input% -f u8 -ar 44100 -ac 1 -i %input% -sws_flags neighbor -s %outputres% %output%