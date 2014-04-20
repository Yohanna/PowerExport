# About #

Ever had to save your PowerPoint slides as a picture and wasn't satisfied of the resolution of files? PowerExport provide an easy way to change the default export resolution (96 dpi) of PowerPoint slides.

# How it works #

It creates/changes a certain registry value in Windows Registry according to the Office version and the required resolution.


# Limitations #

The following export resolutions are supported:

|Full-screen pixels (horizontal × vertical) | Widescreen pixels (horizontal × vertical) | per inch (horizontal and vertical) |
|:------------:|:--------------:|:-------------:|
|500 × 375	 | 667 × 375	|	50 dpi			|
|960 × 720	 | 1280 × 720 	|	96 dpi (default)|
|1000 × 750	 | 1333 × 750	| 100 dpi 			|
|1500 × 1125 | 2000 × 1125	| 150 dpi			|
|2000 × 1500 | 2667 × 1500	| 200 dpi 			|
|2500 × 1875 | 3333 × 1875	| 250 dpi 			|
|3000 × 2250 | 4000 × 2250	| 300 dpi 			| 

# Note #

In order for PowerExport to detect resolution settings correctly you need to run PowerPoint at least once since certain registry values are created when PowerPoint run for the first time on the computer. 