[English](https://github.com/aromajoin/controller-sdk-windows) / [日本語](README-JP.md)

# ControllerSDK - Windows版

[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg?style=flat-square)](https://www.apache.org/licenses/LICENSE-2.0.html)

**[Aroma Shooter](https://aromajoin.com/products/aroma-shooter)との通信に使用されるAromaShooterController SDKのWindows版です。**

# 目次
1. [対応デバイス](#対応デバイス)  
2. [前提条件](#前提条件)
3. [インストール](#インストール)
4. [使い方](https://github.com/aromajoin/controller-sdk-windows/blob/master/README-JP.md#使い方)
    * [接続](https://github.com/aromajoin/controller-sdk-windows/blob/master/README-JP.md#0-接続)
    * [Aroma Shooter 1 & 2のどちらも使える関数](https://github.com/aromajoin/controller-sdk-windows/blob/master/README-JP.md#1-aroma-shooter-1--2のどちらも使える関数)
    * [Aroma Shooter 新バージョンのみ使える関数](https://github.com/aromajoin/controller-sdk-windows/blob/master/README-JP.md#2-aroma-shooter-新バージョンのみ使える関数)
5. [ライセンス](https://github.com/aromajoin/controller-sdk-windows/blob/master/README-JP.md#ライセンス)

## 対応デバイス
* Aroma Shooter 1 USBタイプ
* Aroma Shooter 2 （USB接続の場合）

## 前提条件
* Windows版: 10+
* .NET Framework: 4.6+
* [ドライバ](http://www.ftdichip.com/Drivers/CDM/CDM21224_Setup.zip)をインストールしてください。

## インストール  
1. このリポジトリを複製するか、[.zipファイル](https://github.com/aromajoin/controller-sdk-windows/releases/)をダウンロードしてください。
2. [’libs’フォルダ](https://github.com/aromajoin/controller-sdk-windows/tree/master/libs)でライブラリバイナリファイル（.dll）を入手してください。
3. これらの.dllファイルをプロジェクトに*References*として追加してください。  

## サンプル
Visual Studioを使用して[サンプルアプリケーション](https://github.com/aromajoin/controller-sdk-windows/tree/master/sample)を試してみてください。

## 使い方

### 0. 接続

#### 初めにAroma Shooter Controllerのリファレンスを作る。
```C#
AromaShooterController aromaShooterController = AromaShooterController.SharedInstance;
```
#### デバイスのセットアップと接続
```C#
aromaShooterController.Setup();
```
### 1. Aroma Shooter 1 & 2のどちらも使える関数

#### a. 接続されたアロマシューターすべて噴射
```C#
ASController.DiffuseAll(int durationMillisecs, int[] ports, bool booster);
/**
 * @param durationMillisecs     噴射持続時間（ミリ秒）。
 * @param ports        噴射する カートリッジ番号。値： 1 ~ 6.
 * @param booster      ブースターを使用するかどうかを判定する。(true: より強く噴射する , false: より弱く噴射する )
 */
```
例：以下のコードは、カートリッジ 1,2 および 5 を 3 秒間噴射します。
```C#
ASController.DiffuseAll(3000, new int[]{1, 2, 5}, true);
```
#### b. アロマシューターの名前を指定して噴射
```C#
ASController.Diffuse(int durationMillisecs, int[] ports, bool booster, string shooterName);
```
例：
```C#
ASController.Diffuse(3000, new int[]{1, 2, 5}, true,”ASN1UA0150”);
ASController.Diffuse(3000, new int[]{1, 2, 5}, true,”ASN2A00001”);
```
#### c. 接続されたアロマシューター全て噴射停止
```C#
ASController.StopAll();
```

#### d.   アロマシューターの名前を指定して噴射停止  
```C#
ASController.Stop(string shooterName);
```

#### e. 接続されたアロマシューターリスト取得

```C#
List<String> connectedAromaShooters = ASController.GetConnectedDevices();
```

### 2. Aroma Shooter 新バージョンのみ使える関数

#### a. 接続されたアロマシューター全て強度制御付き噴射
```C#
ASController.DiffuseAll(int durationMillisecs, List<AromaPort> ports, int boosterIntensity, int fanIntensity);
```

AromaPort クラスに number と intensity というメンバーがあります。 number は噴
射するポート番号で、 intensity は強度（0~100）です。

#### b. アロマシューターの名前を指定して強度制御付き噴射
```C#
ASController.Diffuse(int durationMillisecs, List<AromaPort> ports, int boosterIntensity, int fanIntensity, string shooterName);
```

#### c. 接続されたアロマシューター全て特定のポートなど噴射停止
```C#
ASController.Stop(int[] ports, bool stopBooster, bool stopFan);
```

stopBooster が true の時 booster が停止されます。 stopFan が true の時外部について
いるファンが停止されます。

#### d. アロマシューターの名前を指定して特定のポートなど噴射停止
```C#
ASController.Stop(string shooterName, int[] ports, bool stopBooster, bool stopFan);	
```
**問題が発生したり、新機能が必要な場合は、[新しい問題](https://github.com/aromajoin/controller-sdk-windows/issues)を作成してください。**

## ライセンス

[こちら](https://github.com/aromajoin/controller-sdk-windows/blob/master/LICENSE.md)を参照してください。
