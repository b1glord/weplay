  echo -n "Removing Git Old Version... "
  yum remove -y git firewalld
  echo -n "Installing Git New Version... "
  yum install -y https://centos7.iuscommunity.org/ius-release.rpm
  yum install -y git2u
  git --version
  
yum -y install epel-release centos-release-scl wget nano
yum -y install mariadb-devel zlib-devel lua-devel


  echo -n "development tools daki cmake varken cmake3 ü yüklemede hata veriyor o yuzden siliyoruz"
yum remove cmake
  echo -n "cmake3 yukluyoruz"
yum -y install cmake3 
sudo ln -s /usr/bin/cmake3 /usr/bin/cmake

  echo -n "devtoolset-4 ile devtoolset-7 degisim yaptım"
#yum -y install devtoolset-4
yum -y install devtoolset-7

  echo -n "download pvpgn server"
cd /home
git clone https://github.com/b1glord/pvpgn-server.git
cd pvpgn-server

CC=/opt/rh/devtoolset-7/root/usr/bin/gcc CXX=/opt/rh/devtoolset-7/root/usr/bin/g++ cmake -D WITH_LUA=true -D WITH_MYSQL=true -G "Unix Makefiles" -H./ -B./build
cd build && make
make install


#change bnetd.conf
cd /usr/local/etc/pvpgn/
rm -r -f bnetd.conf
wget https://raw.githubusercontent.com/b1glord/weplay/master/install2/bnetd.conf

# Add TR Language
mkdir /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/bnhelp.conf -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/bnmotd.txt -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/chathelp-war3.txt -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/common.xml -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/newaccount.txt -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/termsofservice.txt -P /usr/local/etc/pvpgn/i18n/trTR
wget -nc https://raw.githubusercontent.com/b1glord/weplay/master/kurulum/dil%20dosyas%C4%B1/trTR/w3motd.txt -P /usr/local/etc/pvpgn/i18n/trTR


#start server (-f optional)
#/usr/local/sbin/bnetd
