# JmeterSample

这个仓库包含了一些常见的 Jmeter 用法。

## WebApi

这个是测试接口，基于 ASP.NET Core Web API

## jmx

### sample1.jmx

一个入门级的使用案例。

1. HTTP 请求
2. 断言
3. 监听
4. CLI + HTML报告

对应下面这篇博文：

[聊一聊Jmeter的简单使用](https://mp.weixin.qq.com/s/6v7Wf3I5nrjmF1zAbFHMuA)

### sample2.jmx

两个参数化的例子

一、零散的内容

1. 通过在 `BeanSheel PreProcessor` 进行硬编码；
2. 读取 **CSV** 文件作为请求参数；
3. 读取 **CSV** 文件，并用自定义jar包对密码进行HASH之后再作为请求参数；
4. 在 3 的基础上，并用 **CSV** 的参数判断接口是否成功；

二、完整的例子

登录例子 + 自定义jar包处理密码

对应下面这篇博文：

[聊一聊Jmeter的参数化](https://mp.weixin.qq.com/s/5IrfGOfihiOZvF9YBzobpg)

### sample3.jmx

多接口测试，接口之间有依赖性，顺序性

对应下面这篇博文：

[聊一聊Jmeter的多接口测试](https://mp.weixin.qq.com/s/TT_BA3iqzdagj0yAkc73_Q)

### sample4.jmx

接 sample3，接口有依赖，但是要根据上一个接口的返回再决定下一个接口

对应下面这篇博文：

[聊一聊Jmeter用IF控制器处理接口依赖](https://mp.weixin.qq.com/s/oflxwRt3hdaoPjqd8Jehig)

### sample5.jmx

多用户登录，获取token后，再请求对应的业务接口

对应下面这篇博文：

[聊一聊Jmeter多用户token使用问题](https://mp.weixin.qq.com/s/UOBDmtouoBjd5BQvp2FNTg)

## csv

存放参数化的数据

## jar

自定义的 jar 包
