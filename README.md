# Controller SDK for Windows

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)


**The Windows version of AromaShooterController SDK which is used to communicate with [Aroma Shooter devices](https://aromajoin.com/hardware/shooters/aroma-shooter-1)**  

# Table of Contents
1. [Supported devices](https://github.com/aromajoin/controller-sdk-windows#supported-devices)  
2. [Prerequisites](https://github.com/aromajoin/controller-sdk-windows#prerequisites)
3. [Installation](https://github.com/aromajoin/controller-sdk-windows#installation)
4. [Usage](https://github.com/aromajoin/controller-sdk-windows#usage)
    * [Setup and connect devices](https://github.com/aromajoin/controller-sdk-windows#setup-and-connect-devices)
    * [Diffuse scents](https://github.com/aromajoin/controller-sdk-windows#diffuse-scents)
5. [License](https://github.com/aromajoin/controller-sdk-windows#license)

---

## Supported devices
* Aroma Shooter Bluetooth version  
* Aroma Shooter USB version  

---
## Prerequisites
* Windows version: 8+ 
* .NET Framework: 4.5+ 
* [Device driver installation](http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip)

---
## Installation  

* Please [download the .zip file](https://github.com/aromajoin/controller-sdk-windows/releases/).
* Extract it to grab .dll files.
* Add these .dll files into your project as *References*. 
* **For Bluetooth version**, please connect Aroma Shooter via Bluetooth Settings section in Windows before starting application. If you restart your app, make sure to reconnect it again.
---
## Usage  
 
*Firstly, get the reference of AromaShooterController*
```C#
AromaShooterController aromaShooterController = AromaShooterController.sharedInstance;
```
### Setup and connect devices
```C#
aromaShooterController.setup();
```
### Diffuse scents 

Using *Diffuse APIs*  :
```C#
aromaShooterController.diffuse(durration, ports, booster);
``` 


**For more information, please checkout this repository and refer to the [sample project](https://github.com/aromajoin/controller-sdk-windows/tree/master/sample).**  
**If you get any issues or require any new features, please create a [new issue](https://github.com/aromajoin/controller-sdk-windows/issues).**

---
## License  

The Apache License (Apache)

    Copyright (c) 2017 Aromajoin Corporation

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
