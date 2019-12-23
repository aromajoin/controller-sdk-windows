[English](https://github.com/aromajoin/controller-sdk-windows) / [日本語](README-JP.md)

# Controller SDK for Windows

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)  

**The Windows version of AromaShooterController SDK which is used to communicate with [Aroma Shooter devices](https://aromajoin.com/products/aroma-shooter).**  

# Table of Contents
1. [Supported devices](https://github.com/aromajoin/controller-sdk-windows#supported-devices)  
2. [Prerequisites](https://github.com/aromajoin/controller-sdk-windows#prerequisites)
3. [Installation](https://github.com/aromajoin/controller-sdk-windows#installation)
4. [Usage](https://github.com/aromajoin/controller-sdk-windows#usage)
    * [Setup and connect devices](https://github.com/aromajoin/controller-sdk-windows#0-connecting)
    * [Functions that compatible with both Aroma Shooter 1 & 2](https://github.com/aromajoin/controller-sdk-windows#1-functions-that-compatible-with-both-aroma-shooter-1--2)
    * [Functions that compatible with Aroma Shooter 2 only](https://github.com/aromajoin/controller-sdk-windows#2-functions-that-compatible-with-aroma-shooter-2-only)
5. [License](https://github.com/aromajoin/controller-sdk-windows#license)

## Supported devices
* Aroma Shooter 1 USB Type
* Aroma Shooter 2 (via USB only)

## Prerequisites
* Windows version: 10+.
* .NET Framework: 4.6+. 
* Please install [device driver](http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip).

## Installation  
* Clone this repository or [download the .zip file](https://github.com/aromajoin/controller-sdk-windows/releases/).
* Get library binary files (.dll) at [`libs` folder](https://github.com/aromajoin/controller-sdk-windows/tree/master/libs).
* Add these .dll files into your project as *References*.  

## Sample
You might want to try the [sample app](https://github.com/aromajoin/controller-sdk-windows/tree/master/sample) by using Visual Studio.

## Usage  

#### 0. Connecting  

##### Firstly, get the reference of AromaShooterController

```C#
AromaShooterController aromaShooterController = AromaShooterController.SharedInstance;
```
##### Setup and connect devices
```C#
aromaShooterController.Setup();
```
#### 1. Functions that compatible with both Aroma Shooter 1 & 2  

##### a. Diffuse from all connected Aroma Shooters.
```C#
aromaShooterController.Diffuse(int durrationMillisecs, int[] ports, bool booster);
*@param durationMillisecs		diffusing time (ms).
*@param ports					array of cartridge number to diffuse, value: 1~6.
*@param booster                 true = use booster, false = not use booster.
```

For example, the following code will diffuse cartridge **1**, **2**, and **3** for **3** seconds **with booster**.
```C#
aromaShooterController.Diffuse(3000, new int[]{1, 2, 3}, true);
```

##### b. Diffuse from a specific Aroma Shooter.
```C#
aromaShooterController.Diffuse(int durationMillisecs, int[] ports, bool booster, string shooterName);
```
For example, the following code will diffuse cartridge **1**, **2**, and **3** for **3** seconds at Aroma Shooter with serial number "**ASN1UA0001**".
```C#
aromaShooterController.Diffuse(3000, new int[] { 1, 2, 3}, true, "ASN1UA0001");
```

##### c. Stop diffusing from all connected Aroma Shooters.

```C#
aromaShooterController.Stop();
```

##### d. Stop diffusing from a specific Aroma Shooters.

```C#
aromaShooterController.Stop(string shooterName);
```

##### e. Get the list of connected Aroma Shooters
```C#
List<string> connectedAromaShooters = ASController.getConnectedDevices();
```

#### 2. Functions that compatible with Aroma Shooter 2 only  

##### a. Diffuse from all connected Aroma Shooters with intensity control.
```C#
ASController.DiffuseAll(int durationMillisecs, List<AromaPort> ports, int boosterIntensity, int fanIntensity);
```
AromaPort class has two members: number and intensity, in which number is the port to
diffuse, intensity is the strength of diffusing (0~100).

##### b. Diffuse from a specific Aroma Shooter with intensity control.
```C#
ASController.Diffuse(int durationMillisecs, List<AromaPort> ports, int boosterIntensity, int fanIntensity, string shooterName);
```

##### c. Stop diffusing from all connected Aroma Shooters on specific ports.
```C#
ASController.Stop(int[] ports, bool stopBooster, bool stopFan);
```
When stopBooster is true, booster is stopped. When stopFan is true the attached fan is
stopped.

##### d. Stop diffusing from a specific Aroma Shooter on specific ports.
```C#
ASController.Stop(string shooterName, int[] ports, bool stopBooster, bool stopFan);
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