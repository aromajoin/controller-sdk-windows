[English](https://github.com/aromajoin/controller-sdk-windows) / [日本語](README-JP.md)

# ControllerSDK - Windows版

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)

**[Aroma Shooter](https://aromajoin.com/hardware/shooters/aroma-shooter-1)との通信に使用されるAromaShooterController SDKのWindows版です。**

# 目次
1. [対応デバイス](#対応デバイス)  
2. [前提条件](#前提条件)
3. [インストール](#インストール)
4. [使用法](#使用法)
    * [デバイスのセットアップと接続](#デバイスのセットアップと接続)
    * [香りを拡散する](#香りを拡散する)
5. [ライセンス](#ライセンス)

## 対応デバイス
* Aroma Shooter Bluetooth BLE  
* Aroma Shooter USB

## 前提条件
* Windows版: 8+
* .NET Framework: 4.5+
* Aroma Shooter USBの場合は、「ドライバ」(http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip)をインストールしてください。
* Aroma Shooter の場合は, WindowsのBluetooth接続ガイドを確認してください: [日本語](https://s3-ap-northeast-1.amazonaws.com/aromajoin-downloads/software/aroma-player/AromaPlayer_Manual_Windows8_BLE_JP.pdf)/[English](https://www.makeuseof.com/tag/set-up-bluetooth-windows-10/)。

## インストール  
1. このリポジトリを複製するか、[.zipファイル](https://github.com/aromajoin/controller-sdk-windows/releases/)をダウンロードしてください。
2. [libs`フォルダ]（https://github.com/aromajoin/controller-sdk-windows/tree/master/libs）でライブラリバイナリファイル（.dll）を入手してください。
3. これらの.dllファイルをプロジェクトに*References*として追加してください。  

** Bluetoothバージョン**では、アプリケーションを起動する前に、WindowsのBluetooth設定セクションからAroma Shooterに接続してください。 アプリを再起動した場合は、もう一度再接続してください。

## サンプル
Visual Studioを使用して[サンプルアプリケーション]（https://github.com/aromajoin/controller-sdk-windows/tree/master/sample）を試してみてください。

## 使用法  
 
*まずにAroma Shooter Controllerのリファレンスを入手してください。*
```C#
AromaShooterController aromaShooterController = AromaShooterController.sharedInstance;
```
### デバイスのセットアップと接続
```C#
aromaShooterController.setup();
```
### 香りを拡散する

「Diffuse」APIを使用してください。
```C#
aromaShooterController.diffuse(durration, ports, booster);
``` 
例：以下のコードは、カートリッジ1,2および3を3秒間拡散します。
```
aromaShooterController.diffuse(3000, new int[]{1, 2, 3}, true);
```

**問題が発生したり、新機能が必要な場合は、[新しい問題]（https://github.com/aromajoin/controller-sdk-windows/issues）を作成してください。**

## ライセンス
[こちら](https://github.com/aromajoin/controller-sdk-windows/blob/master/LICENSE.md)を参照してください。
