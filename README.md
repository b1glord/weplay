# WePlay War3 Test Server and Client Files
---

### Start Server First Run (-f optional)
```
/usr/local/sbin/bnetd
```

### Start Ghost++ First Run
---
### You can pass a command-line argument to use a different secondary configuration filename, instead of ghost.cfg:
### ./ghost++ /opt/myconfig.cfg (bu örnek ile denedim dosyalarin root klasorunde olmasi gerekli!)

### start ghost++ first run
```
cd ~root/bot1
chmod a+x ~root/bot1/ghost++
./ghost++
```

### Start pvpgn and ghost++
---
```
/usr/local/sbin/bnetd
cd ~root/bot1
./ghost++ weplay.cfg
```
