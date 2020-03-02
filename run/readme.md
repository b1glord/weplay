### Start pvpgn and ghost++
---

```
/usr/local/sbin/bnetd
```
### Download Start ghost++ Background
```
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/run/start.sh -P ~root/bot1
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/run/stop.sh -P ~root/bot1
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/run/restart.sh -P ~root/bot1
chmod +x ~root/bot1/start.sh ~root/bot1/stop.sh ~root/bot1/restart.sh
```
### Start ghost++ Background
```
~root/bot1/start.sh
~root/bot1/stop.sh
~root/bot1/restart.sh
```




### Ref: http://suchdichsatt.de/tutorial/warcraft3-ghost
