[English](https://github.com/aromajoin/controller-sdk-windows) / [日本語](README-JP.md)

# Controller SDK for Windows

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)  

**The Windows version of AromaShooterController SDK which is used to communicate with [Aroma Shooter devices](https://aromajoin.com/hardware/shooters/aroma-shooter-1).**  

# Table of Contents
1. [Supported devices](https://github.com/aromajoin/controller-sdk-windows#supported-devices)  
2. [Prerequisites](https://github.com/aromajoin/controller-sdk-windows#prerequisites)
3. [Installation](https://github.com/aromajoin/controller-sdk-windows#installation)
4. [Usage](https://github.com/aromajoin/controller-sdk-windows#usage)
    * [Setup and connect devices](https://github.com/aromajoin/controller-sdk-windows#setup-and-connect-devices)
    * [Diffuse scents](https://github.com/aromajoin/controller-sdk-windows#diffuse-scents)
    * [Stop diffusing](https://github.com/aromajoin/controller-sdk-windows#stop-diffusing)
5. [License](https://github.com/aromajoin/controller-sdk-windows#license)

## Supported devices
* Aroma Shooter USB

## Prerequisites
* Windows version: 8+.
* .NET Framework: 4.5+. 
* For Aroma Shooter USB, please install [device driver](http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip).

## Installation  
* Clone this repository or [download the .zip file](https://github.com/aromajoin/controller-sdk-windows/releases/).
* Get library binary files (.dll) at [`libs` folder](https://github.com/aromajoin/controller-sdk-windows/tree/master/libs).
* Add these .dll files into your project as *References*.  

**For Bluetooth version**, please connect Aroma Shooter via Bluetooth Settings section in Windows before starting application. If you restart your app, make sure to reconnect it again.  

## Sample
You might want to try the [sample app](https://github.com/aromajoin/controller-sdk-windows/tree/master/sample) by using Visual Studio.

## Usage  
 
*Firstly, get the reference of AromaShooterController*
```C#
AromaShooterController aromaShooterController = AromaShooterController.SharedInstance;
```
### Setup and connect devices
```C#
aromaShooterController.Setup();
```
### Diffuse scents 

#### Diffuse all Aroma Shooter
Using *Diffuse APIs*  :
```C#
aromaShooterController.Diffuse(durration, ports, booster);

For example, the following code will diffuse cartridge 1, 2, and 3 for 3 seconds.
```
aromaShooterController.Diffuse(3000, new int[]{1, 2, 3}, true);
```
#### Diffuse a specific Aroma Shooter
```C#
aromaShooterController.Diffuse(ports, duration, booster, aromashooter_serial);
```

For example, the following code will diffuse cartridge 1, 2, and 3 for 3 seconds at Aroma Shooter with serial id "ASN1UA0001"
```C#
aromaShooterController.Diffuse(new int[] { 1, 2, 3}, 3000, true, "ASN1UA0001");
```

### Stop diffusing
```C#
aromaShooterController.Stop();
```

**If you get any issues or require any new features, please create a [new issue](https://github.com/aromajoin/controller-sdk-windows/issues).**

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
