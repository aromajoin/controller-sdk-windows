[English](https://github.com/aromajoin/controller-sdk-windows) / [日本語](README-JP.md)

# ControllerSDK - Windows版

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)

**[Aroma Shooter](https://aromajoin.com/products/aroma-shooter)との通信に使用されるAromaShooterController SDKのWindows版です。**

# 目次
1. [対応デバイス](#対応デバイス)  
2. [前提条件](#前提条件)
3. [インストール](#インストール)
4. [使用法](#使用法)
    * [デバイスのセットアップと接続](#デバイスのセットアップと接続)
    * [香りを噴射する](#香りを噴射する)
    * [噴射を止める](#噴射を止める)
5. [ライセンス](#ライセンス)

## 対応デバイス
* Aroma Shooter USBタイプ

## 前提条件
* Windows版: 8+
* .NET Framework: 4.5+
* Aroma Shooter USBタイプの場合は、[ドライバ](http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip)をインストールしてください。

## インストール  
1. このリポジトリを複製するか、[.zipファイル](https://github.com/aromajoin/controller-sdk-windows/releases/)をダウンロードしてください。
2. [’libs’フォルダ](https://github.com/aromajoin/controller-sdk-windows/tree/master/libs)でライブラリバイナリファイル（.dll）を入手してください。
3. これらの.dllファイルをプロジェクトに*References*として追加してください。  

## サンプル
Visual Studioを使用して[サンプルアプリケーション](https://github.com/aromajoin/controller-sdk-windows/tree/master/sample)を試してみてください。

## 使用法  
 
*初めにAroma Shooter Controllerのリファレンスを入手してください。*
```C#
AromaShooterController aromaShooterController = AromaShooterController.SharedInstance;
```
### デバイスのセットアップと接続
```C#
aromaShooterController.Setup();
```
### 香りを噴射する

#### アロマシューターをすべて噴射する
```C#
/**
 * @param duration     噴射持続時間（ミリ秒）。
 * @param ports        カートリッジ番号を噴射する。値：1 ~ 6.
 * @param booster      ブースターが使用されているかどうかを判定する。(true: より強く噴射する, false: より弱く噴射する)
 */
aromaShooterController.Diffuse(durration, ports, booster);
``` 
例：以下のコードは、カートリッジ1,2および3を3秒間噴射します。
```C#
aromaShooterController.Diffuse(3000, new int[]{1, 2, 3}, true);
```
#### 特定のアロマシューターを噴射する
```C#
aromaShooterController.Diffuse(ports, duration, booster, aromashooter_serial);
```  
例：次のコードは、アロマシューター "ASN1UA0001"で3秒間カートリッジ1、2、および3を拡散させます。
```C#
aromaShooterController.Diffuse(new int[] { 1, 2, 3}, 3000, true, "ASN1UA0001");
```
### 噴射を止める
```
aromaShooterController.Stop();
```
**問題が発生したり、新機能が必要な場合は、[新しい問題](https://github.com/aromajoin/controller-sdk-windows/issues)を作成してください。**

## ライセンス
[こちら](https://github.com/aromajoin/controller-sdk-windows/blob/master/LICENSE.md)を参照してください。
