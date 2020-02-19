#yum groupinstall "Development Tools"
yum install -y gcc-c++ mariadb-libs mariadb-devel
yum install -y screen tar wget unzip bzip2 bzip2-devel gmp-devel
ln -s /usr/lib64/mysql/libmysqlclient.so /usr/lib/libmysqlclient.so


# Installing Git New Version
yum remove -y git
yum install -y https://centos7.iuscommunity.org/ius-release.rpm
yum install -y git2u
git --version


cd /home
#wget https://github.com/b1glord/weplay/raw/master/repo/boost_1_54_0.tar.bz2
wget http://downloads.sourceforge.net/project/boost/boost/1.54.0/boost_1_54_0.tar.bz2
tar xjf boost_1_54_0.tar.bz2
cd /home/boost_1_54_0
./bootstrap.sh --with-libraries=filesystem,program_options,system,regex,thread,date_time --libdir=/usr/lib/
./bjam
./bjam install


cd /home
git clone https://github.com/b1glord/OHSystem.git
cd /home/OHSystem/ghost/src/bncsutil/src/bncsutil
make
make install
cd /home/OHSystem/ghost/src/StormLib/stormlib
make
make install
cd /home/OHSystem/ghost/src
make


# Final Step Copy Building Files...
cd /home/OHSystem/ghost
mkdir bot
cp src/ghost++ bot/
cp config/* bot -R
#cp plugins bot/ -R
cp mapcfgs/ bot/ -R
cp w3/ bot/ -R
mkdir bot/maps/ bot/replays/ bot/savegames/
