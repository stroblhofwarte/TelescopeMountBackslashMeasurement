# TelescopeMountBackslashMeasurement
This is a simple application to measure the backslash of a mount. This program use a ASCOM camera and a ASCOM mount. 
For a more detailed description see https://astro.stroblhof-oberrohrbach.de.

# How it works

Preconditions: This application requires daylight. 
The telescope points to a landmark and the camera is in focus.
Telescope mount and camera are connected to your computer setup via ASCOM.
Check wich axis (x,y) is RA and which is DEC. 

Step 1:
Select and connect to your camera device (upper right corner).
Select and connect to your mount.

If camera and mount are connected, the focal length (in mm) and diameter (in mm) are filled from the mount settings 
and the pixelsize (in µm) is filled from the camera settings. The resolution (in ''/pixel) is calculated out of the 
other values (Formula: ( (pixelsize [µm] / focallength [mm]) * 206.265) = resolution [''/pixel] ).

Step 2:
Take a picture (adjust the exposure time to get a useable image of your landmark selected before).

Step 3:
Press "set reference" and click on the reference point in your image, a yellow cross appears.

Step 4: 
Press the telescope move button, the scope will move and return back (the mount is unparked if it is parked).

Step 5:
Take a picture, this picture will be shifted regarding the backslash of the mount.

Step 6:
Press "measure" and click on the reference point in the image taken in Step 5 (green cross). 
The value of "Difference X:" and "Difference Y:" gives you the backslash values in arcsec for the RA and
DEC axis (remember the precondition step which axis is RA and which is DEC). Fill this values in the
mount setup (e.g. OnStep supports this) and repeat this steps to check if your backslash is gone.


# Development

This application is developt with VisualStudio 2019 community. It is a simple Forms-Application. 
The ASCOM SDK is required to compile this application. A simple precompiled setup package can be found under 
TelescopeMountBackslashMeasurementSetup\Release.

This application was tested with a OnStep mount (LXD600), a C9.25 with focal reducer (f/6.3) and an ASI1600MM Pro
camera. This application was never tested with a on shot color camera. 


