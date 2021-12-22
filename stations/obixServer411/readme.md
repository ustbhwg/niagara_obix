# 站点说明

本站点是在Niagara 4.11.0.142 下创建，使用较低版本可能会无法打开站点，或者有一些警告提示。

因为passphrase原因，ObixNetwork下的device的密码会丢失，需要你重新设置。



# 站点用户

admin/Admin12345，用于Workbench和网页登录

obix/Admin12345，用于oBIX访问



# 关于历史数据

站点中有一个模拟历史数据的，在slot:/publicData/temp/aa下，把它使能（Enabled设置为true）后，站点会生成一个历史文件，会占用大约300+M硬盘空间，总共有365 x 24 x 3600 = 31,536,000（三千多万）条历史记录，生成时间比较长，根据硬盘速度，可能会需要半个小时到一两个小时左右。这个历史数据用于历史部分





# jQuery + oBIX

站点下的 html\bar-simple.html 和 html\pie-simple.html 是 jQuery 和 oBIX结合，将数据喂给echarts，显示柱状图和饼状图的例子。



