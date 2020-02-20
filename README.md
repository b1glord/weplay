# WePlay War3 Test Server and Client Files

### Centos 7 Installer

```
yum install -y wget
cd /home

wget https://raw.githubusercontent.com/b1glord/weplay/master/pvpgn_centos7.sh
chmod a+x ./pvpgn_centos7.sh
./pvpgn_centos7.sh

wget https://raw.githubusercontent.com/b1glord/weplay/master/ohs_install_centos.sh
chmod a+x ./ohs_install_centos.sh
./ohs_install_centos.sh
```
```
#Start Server First Run (-f optional)
/usr/local/sbin/bnetd -f

#Sart Ghost++ First Run
#You can pass a command-line argument to use a different secondary configuration filename, instead of ghost.cfg:
#./ghost++ /opt/myconfig.cfg
#start ghost++
cd /home/OHSystem/ghost/bot
chmod +x ./ghost++
./ghost++
```
```
/usr/local/sbin/bnetd
/home/OHSystem/ghost/bot/ghost++ /home/OHSystem/ghost/bot/weplay.cfg
```
