#yum groupinstall "Development Tools"
yum install -y gcc-c++ mariadb-libs mariadb-devel
yum install -y screen tar wget unzip bzip2 bzip2-devel gmp-devel
ln -s /usr/lib64/mysql/libmysqlclient.so /usr/lib/libmysqlclient.so

# Installing Git New Version
yum install -y https://centos7.iuscommunity.org/ius-release.rpm
yum install -y git2u
git --version


cd /home
wget -nc http://downloads.sourceforge.net/project/boost/boost/1.54.0/boost_1_54_0.tar.bz2
tar xjf boost_1_54_0.tar.bz2
cd /home/boost_1_54_0
./bootstrap.sh --with-libraries=filesystem,program_options,system,regex,thread,date_time --libdir=/usr/lib/
./bjam
./bjam install

ldconfig

cd /home
git clone https://github.com/b1glord/OHSystem.git
cd /home/OHSystem/ghost/src/bncsutil/src/bncsutil
make
make install
cp /home/OHSystem/ghost/src/bncsutil/src/bncsutil/libbncsutil.so /usr/lib/libbncsutil.so
ln -s /usr/lib/libbncsutil.so /usr/lib64/libbncsutil.so

cd /home/OHSystem/ghost/src/StormLib/stormlib
make
make install
cp /home/OHSystem/ghost/src/StormLib/stormlib/libStorm.so /usr/lib/libStorm.so
ln -s /usr/lib/libStorm.so /usr/lib64/libStorm.so

cd /home/OHSystem/ghost/src
make

ldconfig

# Final Step Copy Building Files... (Uyari! Sadece Kok [root] dizinde calisiyor)
cd /home/OHSystem/ghost
mkdir ~root/bot1 ~root/bot1/maps/ ~root/bot1/replays/ ~root/bot1/savegames/
cp src/ghost++ ~root/bot1/
cp config/* ~root/bot1 -R
cp plugins ~root/bot1/ -R
cp mapcfgs/ ~root/bot1/ -R
cp w3/ ~root/bot1/ -R

# Make Log File DIR...
mkdir /usr/local/var/ghost

wget -nc https://raw.githubusercontent.com/b1glord/Configs/master/Warcraft%20III/ghost/examples/weplay.cfg -P ~root/bot1/
wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/ip-to-country.csv -P ~root/bot1/

wget -nc https://raw.githubusercontent.com/b1glord/Configs/master/Warcraft%20III/ghost/ghost%2B%2B/mapcfgs/dota.cfg -P ~root/bot1/mapcfgs

wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/maps/DotA%20v6.85n%20Allstars.w3x -P ~root/bot1/maps


wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/Game.dll -P ~root/bot1/w3
wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/War3Patch.mpq -P ~root/bot1/w3
wget -nc https://raw.githubusercontent.com/b1glord/Configs/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/blizzard.j -P ~root/bot1/w3
wget -nc https://raw.githubusercontent.com/b1glord/Configs/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/common.j -P ~root/bot1/w3
wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/storm.dll -P ~root/bot1/w3
wget -nc https://github.com/b1glord/Configs/raw/master/Warcraft%20III/ghost/ghost%2B%2B/war3data/war3.exe -P ~root/bot1/w3
