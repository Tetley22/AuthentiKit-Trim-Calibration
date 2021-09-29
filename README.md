# AuthentiKit Trim Calibration
![Version Experimtal](https://img.shields.io/badge/Version-Exprimental-blue)

Windows Desktop Application to calbirate button-based peripherals (e.g. AuthentiKit Trim Wheels) for use in simulators (e.g Microsoft Flight Simulator 2020). 

**Requements**
* Windows 10
* vJoy 2.2.1 - [download here](https://github.com/njz3/vJoy/releases/download/v2.2.1.1/vJoySetup-2.2.1-signed.exe)

**Installer Download**

See our [releases page](https://github.com/Colmanian/AuthentiKit-Trim-Calibration/releases)


# Change Log

For now, features will be completely fluid and the latest release tagged as 'Experimental' until we reach a minimum viable product for wider sharing. After this point, releases will have version numbers and changes will be logged here accordingly. 

# Development & Build
This application is written in .NET CORE's WinForms framework as a Win32 Desktop app. This was choson over UWP so that the application doesn't run in a sandbox, and because UWP applications have 'application and lifecyle management control', meaning they pause when minimised or not in use which wouldn't work for this application. 

To develop and build, open up the soluiton found the `/AuthentiKitTrimCalibration` directory in Visual Studio 2019. It's written using a pretty standard pattern so if you're familar with the WinUI framework in .NET Core you should be able to dev and build with relative ease.

# Credits
* vJoy - https://sourceforge.net/projects/vjoystick/
* AuthentiKit - https://www.authentikit.org

# License

This project was written by Ian Colman for the AuthentiKit Community. The AuthentiKit brand/identity is owned by Phil Hulme.

This project is and is licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International license. Unde the terms of this license you are free to:

**Use and share** — run, copy and redistribute the material in any medium or format

The licensor cannot revoke these freedoms as long as you follow the following license terms:

* **Attribution** — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.

* **NonCommercial** — You may not use the material for commercial purposes.

* **NoDerivatives** — If you remix, transform, or build upon the material, you may not distribute the modified material. 

*Appropriate Credit Example*:

*The "AuthentKit Encoder Tool" was written by Ian Colman (Colmanian), licensed under CC BY NC ND 4.0*

[![CC BY-NC-ND 4.0][cc-by-nc-nd-image]][cc-by-nc-nd]

[cc-by-nc-nd]: http://creativecommons.org/licenses/by-nc-nd/4.0/
[cc-by-nc-nd-image]: https://licensebuttons.net/l/by-nc-nd/4.0/88x31.png
[cc-by-nc-nd-shield]: https://img.shields.io/badge/License-CC%20BY%20NC%20ND%204.0-lightgrey.svg