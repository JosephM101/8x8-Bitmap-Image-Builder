# 8x8 Bitmap Image Builder
The "8x8 Bitmap Image Builder" is an application developed with the Raspberry Pi Sense HAT in mind. Specifically, it's 8x8 RGB LED matrix.

When you run the program, you are greeted with an 8x8 array of panels. Each panel represents a pixel. The array is a (crude) representation meant to give you an idea of what the finished bitmap would look like on the Sense HAT. You can choose a color from the right, and click on one of the pixels to change it's color. When you're done, simply navigate to File > Save to export to BMP.

As of writing, file load support has not been implemented yet. Working on it, though. Also planning to add a feature that generates an executable python file that, when run, will immediately load the bitmap and display it on the Sense HAT.

The software can run on Linux using compatibility layers such as "Wine", even if thorough compatibility is not going to be a thing. However, I tested it in Pop!_OS and Linux Mint, and everything worked as intended. Good luck!
