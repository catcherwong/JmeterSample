# JmeterSample

这个仓库包含了一些常见的 Jmeter 用法。

## WebApi

这个是测试接口，基于 ASP.NET Core Web API

## jmx

### sample1.jmx

一个入门级的使用案例，对应下面这篇博文：

[聊一聊Jmeter的简单使用](https://mp.weixin.qq.com/s/6v7Wf3I5nrjmF1zAbFHMuA)

### sample2.jmx

参数化的例子

1. 通过在 `BeanSheel PreProcessor` 进行硬编码；
2. 读取 **CSV** 文件作为请求参数；
3. 读取 **CSV** 文件，并用自定义jar包对密码进行HASH之后再作为请求参数；
4. 在 3 的基础上，并用 **CSV** 的参数判断接口是否成功；

### sample3.jmx

自动化测试接口，接口之间有依赖性，顺序性

## csv

存放参数化的数据

## jar

自定义的 jar 包
