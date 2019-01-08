Detector for Windows 1.0
================

Detector and libVM are a proof-of-concept (PoC) code to detect if Detector is run inside a virtual machine and/or debugger.

Code is written in CSharp and project solution file is for VS2017. Code has been tested in Windows 7/8/10.

The code is, as said before, a PoC to test anti-re techniques, and provided "as is". The code is Open Source so use and play with it freely.

Finally a word of warning. If you do get a mysterious "unable to copy file from obj\... to bin\..." error, it is your AV that is blocking compiler to copy object file to binary. Some heuristic engines may detect the code as malicious and block it. A simple solution for that is to whitelist source code folders in your AV product.
