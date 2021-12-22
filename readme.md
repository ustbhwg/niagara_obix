

# 说明

这个代码是基于在 **Tridium技术支持公众号** 上发布的培训视频中，关于oBIX系列相关的资料，包括2个站点，一个Postman脚本，还有Python客户端源码，以及c#客户端源码。

查看培训视频大家请先关注微信公众号：

![Tridium技术支持公众号二维码](Tridium技术支持公众号二维码.jpg)



# Postman脚本

## 位置

[postman\oBIX - Training.postman_collection.json](postman/oBIX - Training.postman_collection.json)



## 使用方法

该脚本通过Postman v9.6.1导出。

先安装Postman软件，点击菜单File--Import，点击Upload Files按钮，选择该文件，即可打开所有的脚本。



# C# Demo

## 位置

[csharp\oBIXClient](csharp/oBIXClient)

## 说明

本项目使用 Microsoft Visual Studio Community 2019 Preview创建，.Net Framework使用的版本是4.7.2。使用了第三方库RestSharp，如何安装找百度

 

## 运行

运行前确保 obixServer411站点运行，如果想得到查询历史数据的结果，需要先生成模拟历史数据



# Python Demo

## 位置

[python\obixBatchRead.py](python/obixBatchRead.py)

## 说明

在Python 3.9.6下测试没有问题，因为使用到requests库，通常需要安装



## 安装 requests 库

Windows安装

```
pip install requests
```

Linux下安装

```
sudo  pip install requests
```



## 运行

运行前确保 obixServer411站点运行

```
python obixBatchRead.py
```

运行结果

```
Ramp1: 102.3
Ramp2: 62.3
Ramp3: 106.9
```



# 站点

[AX3.5站点](stations/obixServer35)

[N4.11站点](stations/obixServer411)