RTCSetup

PC-Arduino application to setup an RTC (Real Time Clock) module.

Project description on my blog:
http://www.lucadentella.it/2013/11/27/rtcsetup/

Uses RTCLib from Adafruit:
https://github.com/adafruit/RTClib

-----

## Chinese Readme

原有的RTCSetup.exe在win10上测试，报错

![](Python/img/exe-crush.png)

看了下arduino目录下的源码，知道实现原理后就用python写了一个命令行版本的上位机，可以准确地把电脑的当前时间同步到arduino/ESP接的RTC模块里。

如果对准确性要求不是很高，可以在单片机烧录了[RTCSetup.ino](https://github.com/def-fun/RTCSetup/blob/master/Arduino/RTCSetup/RTCSetup.ino)之后，用串口调试工具手动发送设置时间的指令。

波特率57600，发送`!T16102022112708\n`即表示把时间设置为`2022年10月16日 11时27分08秒`,`\n`表示换行符。

发送`?T\n` 表示查询RTC模块当前的时间。
